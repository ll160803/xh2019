
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Web.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
using Ipedf.Common;
using System.Collections.Generic;
using System.Text;
namespace Ipedf.Web.BizLogic
{
	public partial class BizLogicObject_BGT_D_BUDGET_DEPT
	{
        /// <summary>
        /// 编制年份 使用以前的方法
        /// </summary>
        /// <param name="departId"></param>
        /// <returns></returns>
        public DisplayObject_BGT_D_BUDGET_DEPT[] GetBusinessBudgetDepartByDept(string departId)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
                p.DEPT_ID = departId;
                p.IS_FUNCTION = (decimal)是否状态.否;
                p.BUDGET_YEAR = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
                //平台自动生成代码
                return HelperObject_BGT_D_BUDGET_DEPT.Query(p);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.GetBusinessBudgetDepartByDept(departId);
                }
            }
        }
        public DisplayObject_BGT_D_BUDGET_DEPT[] GetFunctionBudgetDepartByDept(string departId)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
                p.DEPT_ID = departId;
                p.IS_FUNCTION = (decimal)是否状态.是;
                p.BUDGET_YEAR = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
                //平台自动生成代码
                return HelperObject_BGT_D_BUDGET_DEPT.Query(p);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.GetFunctionBudgetDepartByDept(departId);
                }
            }
        }

        public DisplayObject_BGT_D_BUDGET_DEPT[] GetFunctionBudgetDepartByDept(string departName,string budgetYear)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
                p.NAME = departName;
                p.IS_FUNCTION = (decimal)是否状态.是;
                p.BUDGET_YEAR = budgetYear;
                //平台自动生成代码
                return HelperObject_BGT_D_BUDGET_DEPT.Query(p);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.GetFunctionBudgetDepartByDept(departName,budgetYear);
                }
            }
        }
        public List<string> CheckImportService(DataTable data)
        {
            if (LocalMode)
            {
                List<string> colMsg = null;
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            colMsg = CheckImportImpl(data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            colMsg = new List<string>();
                            colMsg.Add("Failed");
                            throw new Exception("读取数据失败, 请检查重试.");
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return colMsg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(data);
                }
            }
        }
        public BizLogicMsg ImportDataService(string budgetYear, DataTable data)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            ImportDataImpl(budgetYear, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(budgetYear, data);
                }
            }
        }
        private List<string> CheckImportImpl(DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, decimal> dicIsFun = new Dictionary<string, decimal>();         //用于保存是否职能科室检测参考信息
            Dictionary<string, string> dicProperty = new Dictionary<string, string>();        //用于保存科室属性,需要保证属性名称唯一
            Dictionary<string, string> dicDeptType = new Dictionary<string, string>();        //用于保存科室类别,需要保证类别名称唯一
            Dictionary<string, string> dicDept = new Dictionary<string, string>();            //用于保存部门信息,需要保证部门名称唯一

            dicIsFun.Add("是", (decimal)Ipedf.Common.是否状态.是);
            dicIsFun.Add("否", (decimal)Ipedf.Common.是否状态.否);

            CauseObject_COM_TYPE pProperty = new CauseObject_COM_TYPE();
            pProperty.PARENT_ID = "0004";
            EntityObject_COM_TYPE[] properties = HelperObject_COM_TYPE.Query(pProperty, transaction);
            foreach (EntityObject_COM_TYPE property in properties)
            {
                dicProperty.Add(property.NAME, property.ID);
            }

            CauseObject_COM_TYPE pDeptType = new CauseObject_COM_TYPE();
            pDeptType.PARENT_ID = "0003";
            EntityObject_COM_TYPE[] deptTypes = HelperObject_COM_TYPE.Query(pDeptType, transaction);
            foreach (EntityObject_COM_TYPE deptType in deptTypes)
            {
                dicDeptType.Add(deptType.NAME, deptType.ID);
            }

            CauseObject_COM_DEPART pDept = new CauseObject_COM_DEPART();
            EntityObject_COM_DEPART[] depts = HelperObject_COM_DEPART.Query(pDept, transaction);
            foreach (EntityObject_COM_DEPART dept in depts)
            {
                if (!dicDept.ContainsKey(dept.NAME))
                {
                    dicDept.Add(dept.NAME, dept.ID);
                }
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第三列数据 科室属性
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("科室属性未填写 ");
                }
                else
                {
                    string itemName = dataRow[2].ToString().Trim();
                    if (!dicProperty.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("科室属性不存在 ");
                    }
                }
                //检测第四列数据 科室类别
                if (dataRow[3] == null || string.IsNullOrEmpty(dataRow[3].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("科室类别未填写 ");
                }
                else
                {
                    string itemName = dataRow[3].ToString().Trim();
                    if (!dicDeptType.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("科室类别不存在 ");
                    }
                }
                //检测第五列数据 是否职能科室
                if (dataRow[4] == null || string.IsNullOrEmpty(dataRow[4].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("是否职能科室未填写 ");
                }
                else
                {
                    string itemName = dataRow[4].ToString().Trim();
                    if (!dicIsFun.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("是否职能科室填写有误 ");
                    }
                }
                //检测第六列数据 部门
                if (dataRow[5] == null || string.IsNullOrEmpty(dataRow[5].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("部门未填写 ");
                }
                else
                {
                    string itemName = dataRow[5].ToString().Trim();
                    if (!dicDept.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("所填部门不存在 ");
                    }
                }
                //查看最终错误数量
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportDataImpl(string budgetYear, DataTable data, IDbTransaction transaction)
        {
            string cpnID = SystemLogic.Proxy.CurrentUser.DATA_ORGANISE_ID;                    //当前用户所在单位作为所导入数据的单位

            Dictionary<string, decimal> dicIsFun = new Dictionary<string, decimal>();         //用于保存是否职能科室检测参考信息
            Dictionary<string, string> dicProperty = new Dictionary<string, string>();        //用于保存科室属性,需要保证属性名称唯一
            Dictionary<string, string> dicDeptType = new Dictionary<string, string>();        //用于保存科室类别,需要保证类别名称唯一
            Dictionary<string, string> dicDept = new Dictionary<string, string>();            //用于保存部门信息,需要保证部门名称唯一

            dicIsFun.Add("是", (decimal)Ipedf.Common.是否状态.是);
            dicIsFun.Add("否", (decimal)Ipedf.Common.是否状态.否);

            CauseObject_COM_TYPE pProperty = new CauseObject_COM_TYPE();
            pProperty.PARENT_ID = "0004";
            EntityObject_COM_TYPE[] properties = HelperObject_COM_TYPE.Query(pProperty, transaction);
            foreach (EntityObject_COM_TYPE property in properties)
            {
                dicProperty.Add(property.NAME, property.ID);
            }

            CauseObject_COM_TYPE pDeptType = new CauseObject_COM_TYPE();
            pDeptType.PARENT_ID = "0003";
            EntityObject_COM_TYPE[] deptTypes = HelperObject_COM_TYPE.Query(pDeptType, transaction);
            foreach (EntityObject_COM_TYPE deptType in deptTypes)
            {
                dicDeptType.Add(deptType.NAME, deptType.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_BUDGET_DEPT budgetDept = new EntityObject_BGT_D_BUDGET_DEPT();
                SystemLogic.Proxy.AuditAdd(budgetDept);
                CauseObject_COM_DEPART pDept = new CauseObject_COM_DEPART();
                pDept.NAME = data.Rows[i][5].ToString().Trim();
                EntityObject_COM_DEPART[] depts = HelperObject_COM_DEPART.Query(pDept, transaction);
                budgetDept.DEPT_ID = depts[0].ID;
                budgetDept.CPN_ID = cpnID;
                budgetDept.BUDGET_YEAR = budgetYear;
                budgetDept.CODE = data.Rows[i][0].ToString().Trim();
                budgetDept.NAME = data.Rows[i][1].ToString().Trim();
                budgetDept.DEPT_PROPERTY_ID = dicProperty[data.Rows[i][2].ToString().Trim()];
                budgetDept.DEPT_TYPE_ID = dicDeptType[data.Rows[i][3].ToString().Trim()];
                budgetDept.IS_FUNCTION = dicIsFun[data.Rows[i][4].ToString().Trim()];
                HelperObject_BGT_D_BUDGET_DEPT.Save(budgetDept, transaction);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departId"></param>
        /// <param name="stage">1是编制2是执行3是归档</param>
        /// <returns></returns>
        public DisplayObject_BGT_D_BUDGET_DEPT[] GetBusinessBudgetDepartByDept(string departId,decimal stage)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
                p.DEPT_ID = departId;
                p.IS_FUNCTION = (decimal)是否状态.否;
                p.BUDGET_YEAR = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(stage);
                //平台自动生成代码
                return HelperObject_BGT_D_BUDGET_DEPT.Query(p);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.GetBusinessBudgetDepartByDept(departId);
                }
            }
        }
        /// <summary>
        /// 根据当前用户的部门ID获取智能部门ID
        /// </summary>
        /// <param name="departId"></param>
        /// <param name="stage">1是编制2是执行3是归档</param>
        /// <returns></returns>
        public DisplayObject_BGT_D_BUDGET_DEPT[] GetFunctionBudgetDepartByDept(string departId,decimal stage)
        {
            if (LocalMode)
            {
                CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
                p.DEPT_ID = departId;
                p.IS_FUNCTION = (decimal)是否状态.是;
                p.BUDGET_YEAR = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(stage);
                //平台自动生成代码
                return HelperObject_BGT_D_BUDGET_DEPT.Query(p);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT>(ServiceUri))
                {
                    return smgr.Service.GetFunctionBudgetDepartByDept(departId);
                }
            }
        }
	}
}
