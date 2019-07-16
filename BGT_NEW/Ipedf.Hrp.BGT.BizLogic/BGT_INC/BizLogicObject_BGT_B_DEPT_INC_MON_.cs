#define NESTING
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
using System.Collections.Generic;
using System.Text;
namespace Ipedf.Web.BizLogic
{

	public partial class BizLogicObject_BGT_B_DEPT_INC_MON
	{
        public BizLogicMsg Calculate(EntityObject_BGT_B_DEPT_INC_MON obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string retMsg = string.Empty;
                int succeed = HelperObject_BGT_B_DEPT_INC_MON.Calculate(obj.BUDGET_YEAR, obj.BUDGET_DEPT_ID, out retMsg);
                msg.Message = retMsg;
                msg.Succeed = succeed == 1;
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_MON> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_MON>(ServiceUri))
                {
                    return smgr.Service.Calculate(obj);
                }
            }
        }
        public List<string> CheckImportService(EntityObject_BGT_B_DEPT_INC_MON obj, DataTable data)
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_MON> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_MON>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportDataService(EntityObject_BGT_B_DEPT_INC_MON obj, DataTable data)
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_MON> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_MON>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(obj, data);
                }
            }
        }
        private List<string> CheckImportImpl(EntityObject_BGT_B_DEPT_INC_MON obj, DataTable data, IDbTransaction transaction)
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
                    strResult.Append("收入科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.ITEM_TYPE_ID = "00180004";//收入科目
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("收入科目不存在 ");
                    }
                }
                //对月份数据进行检测
                for (int j = 1; j < data.Columns.Count - 1; j++)
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[j] == null || string.IsNullOrEmpty(dataRow[j].ToString().Trim())) ? "0" : dataRow[j].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append(j + "月数据有误 ");
                    }
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
        private void ImportDataImpl(EntityObject_BGT_B_DEPT_INC_MON obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_DEPT_INC_MON_D deptMonD = new EntityObject_BGT_B_DEPT_INC_MON_D();
                SystemLogic.Proxy.AuditAdd(deptMonD);
                deptMonD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.ITEM_TYPE_ID = "00180004";//收入科目
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                deptMonD.ITEM_ID = items[0].ID;
                deptMonD.M_1_VALUE = ResolveDataCellNumber(data.Rows[i][1]);
                deptMonD.M_2_VALUE = ResolveDataCellNumber(data.Rows[i][2]);
                deptMonD.M_3_VALUE = ResolveDataCellNumber(data.Rows[i][3]);
                deptMonD.M_4_VALUE = ResolveDataCellNumber(data.Rows[i][4]);
                deptMonD.M_5_VALUE = ResolveDataCellNumber(data.Rows[i][5]);
                deptMonD.M_6_VALUE = ResolveDataCellNumber(data.Rows[i][6]);
                deptMonD.M_7_VALUE = ResolveDataCellNumber(data.Rows[i][7]);
                deptMonD.M_8_VALUE = ResolveDataCellNumber(data.Rows[i][8]);
                deptMonD.M_9_VALUE = ResolveDataCellNumber(data.Rows[i][9]);
                deptMonD.M_10_VALUE = ResolveDataCellNumber(data.Rows[i][10]);
                deptMonD.M_11_VALUE = ResolveDataCellNumber(data.Rows[i][11]);
                deptMonD.M_12_VALUE = ResolveDataCellNumber(data.Rows[i][12]);
                HelperObject_BGT_B_DEPT_INC_MON_D.Save(deptMonD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
	}
}
