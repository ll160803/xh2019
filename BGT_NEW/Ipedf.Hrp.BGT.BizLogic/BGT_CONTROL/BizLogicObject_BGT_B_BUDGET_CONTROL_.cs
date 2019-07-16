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

	public partial class BizLogicObject_BGT_B_BUDGET_CONTROL
    {
        public List<string> CheckImportService(EntityObject_BGT_B_BUDGET_CONTROL obj, DataTable data)
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_CONTROL> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_CONTROL>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportDataService(EntityObject_BGT_B_BUDGET_CONTROL obj, DataTable data)
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_CONTROL> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_CONTROL>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(obj, data);
                }
            }
        }
        private List<string> CheckImportImpl(EntityObject_BGT_B_BUDGET_CONTROL obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, string> dicCtrl= new Dictionary<string, string>();          //用于保存控制类型
            Dictionary<string, string> dicEdition = new Dictionary<string, string>();       //用于保存控制版本

            CauseObject_COM_TYPE pCtrl = new CauseObject_COM_TYPE();
            pCtrl.PARENT_ID = "0201";
            EntityObject_COM_TYPE[] ctrlTypes = HelperObject_COM_TYPE.Query(pCtrl, transaction);
            foreach (EntityObject_COM_TYPE ctrlType in ctrlTypes)
            {
                dicCtrl.Add(ctrlType.NAME, ctrlType.ID);
            }
            CauseObject_COM_TYPE pEdition = new CauseObject_COM_TYPE();
            pEdition.PARENT_ID = "0202";
            EntityObject_COM_TYPE[] editionTypes = HelperObject_COM_TYPE.Query(pEdition, transaction);
            foreach (EntityObject_COM_TYPE editionType in editionTypes)
            {
                dicEdition.Add(editionType.NAME, editionType.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 支出科目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.NAME = itemName;
                    pItem.ITEM_TYPE_ID = "00180005";//支出科目
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("支出科目不存在 ");
                    }
                }
                //检测第二列数据 控制类型
                if (dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim()))
                {
                    strResult.Append("控制类型未填写");
                    errNum++;
                }
                else
                {
                    if(!dicCtrl.ContainsKey(dataRow[1].ToString().Trim()))
                    {
                        errNum++;
                        strResult.Append("支出科目不存在 ");
                    }
                }
                //检测第三列数据 浮动比例
                decimal res = 0;
                if (!decimal.TryParse((dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim())) ? "0" : dataRow[2].ToString().Trim(), out res))
                {
                    errNum++;
                    strResult.Append("浮动比例有误 ");
                }
                //检测第四列数据 控制版本
                if (dataRow[3] == null || string.IsNullOrEmpty(dataRow[3].ToString().Trim()))
                {
                    strResult.Append("控制版本未填写");
                    errNum++;
                }
                else
                {
                    if (!dicEdition.ContainsKey(dataRow[3].ToString().Trim()))
                    {
                        errNum++;
                        strResult.Append("控制版本不存在 ");
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
        private void ImportDataImpl(EntityObject_BGT_B_BUDGET_CONTROL obj, DataTable data, IDbTransaction transaction)
        {
            Dictionary<string, string> dicCtrl = new Dictionary<string, string>();          //用于保存控制类型
            Dictionary<string, string> dicEdition = new Dictionary<string, string>();       //用于保存控制版本

            CauseObject_COM_TYPE pCtrl = new CauseObject_COM_TYPE();
            pCtrl.PARENT_ID = "0201";
            EntityObject_COM_TYPE[] ctrlTypes = HelperObject_COM_TYPE.Query(pCtrl, transaction);
            foreach (EntityObject_COM_TYPE ctrlType in ctrlTypes)
            {
                dicCtrl.Add(ctrlType.NAME, ctrlType.ID);
            }
            CauseObject_COM_TYPE pEdition = new CauseObject_COM_TYPE();
            pEdition.PARENT_ID = "0202";
            EntityObject_COM_TYPE[] editionTypes = HelperObject_COM_TYPE.Query(pEdition, transaction);
            foreach (EntityObject_COM_TYPE editionType in editionTypes)
            {
                dicEdition.Add(editionType.NAME, editionType.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_BUDGET_CONTROL_D ctrlD = new EntityObject_BGT_B_BUDGET_CONTROL_D();
                SystemLogic.Proxy.AuditAdd(ctrlD);
                ctrlD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.ITEM_TYPE_ID = "00180005";//支出科目
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                ctrlD.ITEM_ID = items[0].ID;
                ctrlD.TYPE_ID = dicCtrl[data.Rows[i][1].ToString().Trim()];
                ctrlD.SLIDING_SCALES = ResolveDataCellNumber(data.Rows[i][2]);
                ctrlD.EDITION_ID = dicEdition[data.Rows[i][3].ToString().Trim()];
                HelperObject_BGT_B_BUDGET_CONTROL_D.Save(ctrlD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
	}
}
