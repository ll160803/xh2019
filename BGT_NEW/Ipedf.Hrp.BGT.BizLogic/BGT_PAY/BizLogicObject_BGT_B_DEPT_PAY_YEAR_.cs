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

	public partial class BizLogicObject_BGT_B_DEPT_PAY_YEAR
	{
        public BizLogicMsg Calculate(EntityObject_BGT_B_DEPT_PAY_YEAR obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string retMsg = string.Empty;
                int succeed = HelperObject_BGT_B_DEPT_PAY_YEAR.Calculate(obj.ID, out retMsg);
                msg.Message = retMsg;
                msg.Succeed = succeed == 1;
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR>(ServiceUri))
                {
                    return smgr.Service.Calculate(obj);
                }
            }

        }
        /// <summary>
        /// 科室支出年度预算,是否需要进行BudgetData读写操作
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public bool BudgetDataRequest(EntityObject_BGT_B_DEPT_PAY_YEAR entity, IDbTransaction transaction)
        {
            //获取预算模式设置
            CauseObject_BGT_D_BUDGET_PATTERN pPattern = new CauseObject_BGT_D_BUDGET_PATTERN();
            pPattern.BUDGET_YEAR = entity.BUDGET_YEAR;
            DisplayObject_BGT_D_BUDGET_PATTERN[] patterns = HelperObject_BGT_D_BUDGET_PATTERN.Query(pPattern, transaction);
            if (patterns.Length != 0)
            {
                if (patterns[0].PAY_PATTERN_ID.Trim() == "00170002")//支出编制模式为自下而上
                {
                    //自下而上模式,如果是职能科室入口,则只有当前科室是职能科室时才写入
                    if (patterns[0].PAY_PATTERN_ENTRY_ID.Trim() == "00260001")//职能科室编制入口
                    {                        
                        return entity.IS_FUNCTION == (decimal)是否状态.是;
                    }
                    //自下而上模式,如果是业务科室入口,则只有当前科室是业务科室是才写入
                    if (patterns[0].PAY_PATTERN_ENTRY_ID.Trim() == "00260002")//业务科室编制入口
                    {
                        return entity.IS_FUNCTION == (decimal)是否状态.否;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public override void PostUndoSubmit(EntityObject_BGT_B_DEPT_PAY_YEAR entity, IDbTransaction transaction)
        {
            if (BudgetDataRequest(entity, transaction))
            {
                //删除对应明细项
                CauseObject_BGT_B_BUDGET_DATA_D pDelete = new CauseObject_BGT_B_BUDGET_DATA_D();
                pDelete.REF_TAB_NAME = "BGT_B_DEPT_PAY_YEAR_D";
                CauseObject_BGT_B_DEPT_PAY_YEAR_D pDetail = new CauseObject_BGT_B_DEPT_PAY_YEAR_D();
                pDetail.BASE_ID = entity.ID;
                DisplayObject_BGT_B_DEPT_PAY_YEAR_D[] detailResult = HelperObject_BGT_B_DEPT_PAY_YEAR_D.Query(pDetail, transaction);
                foreach (DisplayObject_BGT_B_DEPT_PAY_YEAR_D detail in detailResult)
                {
                    pDelete.SetINValue("REF_TAB_ID", detail.ID);
                }
                HelperObject_BGT_B_BUDGET_DATA_D.Delete(pDelete, transaction);
            }
        }
        public override void PostSubmit(EntityObject_BGT_B_DEPT_PAY_YEAR entity, IDbTransaction transaction)
        {
            if (BudgetDataRequest(entity, transaction))
            {
                //检查主项是否存在
                CauseObject_BGT_B_BUDGET_DATA pbase = new CauseObject_BGT_B_BUDGET_DATA();
                pbase.BUDGET_CONTENTS_ID = "00120003";
                pbase.BUDGET_YEAR = entity.BUDGET_YEAR;
                pbase.TEMPLET_ID = entity.TEMPLET_ID;
                DisplayObject_BGT_B_BUDGET_DATA[] result = HelperObject_BGT_B_BUDGET_DATA.Query(pbase, transaction);
                EntityObject_BGT_B_BUDGET_DATA baseEntity = new EntityObject_BGT_B_BUDGET_DATA();
                if (result.Length == 0)
                {
                    //不存在则创建
                    baseEntity.BUDGET_CONTENTS_ID = "00120003";
                    baseEntity.BUDGET_YEAR = entity.BUDGET_YEAR;
                    baseEntity.TEMPLET_ID = entity.TEMPLET_ID;
                    baseEntity.STATE = (decimal)数据状态.编辑中;
                    HelperObject_BGT_B_BUDGET_DATA.Save(baseEntity, transaction);
                }
                else
                {
                    baseEntity = result[0];
                }
                //复制明细项
                CauseObject_BGT_B_DEPT_PAY_YEAR_D pDetail = new CauseObject_BGT_B_DEPT_PAY_YEAR_D();
                pDetail.BASE_ID = entity.ID;
                DisplayObject_BGT_B_DEPT_PAY_YEAR_D[] detailResult = HelperObject_BGT_B_DEPT_PAY_YEAR_D.Query(pDetail, transaction);
                foreach (DisplayObject_BGT_B_DEPT_PAY_YEAR_D detail in detailResult)
                {
                    EntityObject_BGT_B_BUDGET_DATA_D detailEntity = new EntityObject_BGT_B_BUDGET_DATA_D();
                    detailEntity.BASE_ID = baseEntity.ID;
                    //detailEntity.BUDGET_BASE = detail.BUDGET_BASE;
                    detailEntity.ITEM_ID = detail.ITEM_ID;
                    detailEntity.ITEM_VALUE = detail.ITEM_VALUE;
                    detailEntity.REF_TAB_ID = detail.ID;
                    detailEntity.REF_TAB_NAME = "BGT_B_DEPT_PAY_YEAR_D";
                    HelperObject_BGT_B_BUDGET_DATA_D.Save(detailEntity, transaction);
                }
                //向科室跟踪写入
                CauseObject_BGT_B_BUDGET_DATA_DEPT pDept = new CauseObject_BGT_B_BUDGET_DATA_DEPT();
                pDept.BASE_ID = baseEntity.ID;
                pDept.BUDGET_DEPT_ID = entity.BUDGET_DEPT_ID;
                DisplayObject_BGT_B_BUDGET_DATA_DEPT[] depts = HelperObject_BGT_B_BUDGET_DATA_DEPT.Query(pDept, transaction);
                if (depts.Length == 0)
                {
                    EntityObject_BGT_B_BUDGET_DATA_DEPT dataEntity = new EntityObject_BGT_B_BUDGET_DATA_DEPT();
                    dataEntity.BASE_ID = baseEntity.ID;
                    dataEntity.BUDGET_DEPT_ID = entity.BUDGET_DEPT_ID;
                    dataEntity.CREATE_DATE = System.DateTime.Now;
                    dataEntity.REF_TAB_ID = entity.ID;
                    dataEntity.REF_TAB_NAME = "BGT_B_DEPT_PAY_YEAR";
                    HelperObject_BGT_B_BUDGET_DATA_DEPT.Save(dataEntity, transaction);
                }
            }
        }
        public List<string> CheckImportService(EntityObject_BGT_B_DEPT_PAY_YEAR obj, DataTable data)
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
                            colMsg = CheckImportImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportDataService(EntityObject_BGT_B_DEPT_PAY_YEAR obj, DataTable data)
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
                            ImportDataImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_YEAR>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(obj, data);
                }
            }
        }
        private List<string> CheckImportImpl(EntityObject_BGT_B_DEPT_PAY_YEAR obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 预算项目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.ITEM_TYPE_ID = "00180005";//支出科目
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("支出科目不存在 ");
                    }
                }
                //对数值数据进行检测
                decimal res = 0;
                if (!decimal.TryParse((dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim())) ? "0" : dataRow[1].ToString().Trim(), out res))
                {
                    errNum++;
                    strResult.Append("科目值有误 ");
                }
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportDataImpl(EntityObject_BGT_B_DEPT_PAY_YEAR obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_DEPT_PAY_YEAR_D deptYearD = new EntityObject_BGT_B_DEPT_PAY_YEAR_D();
                SystemLogic.Proxy.AuditAdd(deptYearD);
                deptYearD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.ITEM_TYPE_ID = "00180005";//支出科目
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                deptYearD.ITEM_ID = items[0].ID;
                deptYearD.ITEM_VALUE = ResolveDataCellNumber(data.Rows[i][1]);
                HelperObject_BGT_B_DEPT_PAY_YEAR_D.Save(deptYearD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
	}
}
