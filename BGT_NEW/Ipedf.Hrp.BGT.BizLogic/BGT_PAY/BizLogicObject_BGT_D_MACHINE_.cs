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
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_D_MACHINE
    {
     
        #region 导入导出功能
        public List<string> CheckService1(EntityObject_BGT_D_MACHINE obj, DataTable data)
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
                            colMsg = CheckImpl1(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_MACHINE> smgr = new ServiceManager<ServiceContract_BGT_D_MACHINE>(ServiceUri))
                {
                    return smgr.Service.CheckService1(obj, data);
                }
            }
        }
        public BizLogicMsg ImportService1(EntityObject_BGT_D_MACHINE obj, DataTable data)
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
                            ImportImpl1(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_MACHINE> smgr = new ServiceManager<ServiceContract_BGT_D_MACHINE>(ServiceUri))
                {
                    return smgr.Service.ImportService1(obj, data);
                }
            }
        }
        private List<string> CheckImpl1(EntityObject_BGT_D_MACHINE obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出明细未填写");
                    errNum++;
                }
                if (dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim()))
                {
                    strResult.Append("申请金额未填写");
                    errNum++;
                }
                else
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim())) ? "0" : dataRow[1].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append("申请金额有误 ");
                    } 
                }
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("依据说明未填写");
                    errNum++;
                }
            }
            return colMsg;
        }
        private void ImportImpl1(EntityObject_BGT_D_MACHINE obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_MACHINE fundD = new EntityObject_BGT_D_MACHINE();
                SystemLogic.Proxy.AuditAdd(fundD);
                //fundD.BASE_ID = obj.ID;
                //fundD.FUND_NAME = data.Rows[i][0].ToString().Trim();
                //fundD.MONEY = ResolveDataCellNumber(data.Rows[i][1]);
                //fundD.DECLARE_CAUSE = data.Rows[i][2].ToString().Trim();
                HelperObject_BGT_D_MACHINE.Save(fundD, transaction);
            }
        }
        public List<string> CheckService2(EntityObject_BGT_D_MACHINE obj, DataTable data)
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
                            colMsg = CheckImpl2(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_MACHINE> smgr = new ServiceManager<ServiceContract_BGT_D_MACHINE>(ServiceUri))
                {
                    return smgr.Service.CheckService2(obj, data);
                }
            }
        }
        public BizLogicMsg ImportService2(EntityObject_BGT_D_MACHINE obj, DataTable data)
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
                            ImportImpl2(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_MACHINE> smgr = new ServiceManager<ServiceContract_BGT_D_MACHINE>(ServiceUri))
                {
                    return smgr.Service.ImportService2(obj, data);
                }
            }
        }
        private List<string> CheckImpl2(EntityObject_BGT_D_MACHINE obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出明细未填写");
                    errNum++;
                }
                if (dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim()))
                {
                    strResult.Append("计划金额未填写");
                    errNum++;
                }
                else
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim())) ? "0" : dataRow[1].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append("计划金额有误 ");
                    }
                }
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("计划时间未填写");
                    errNum++;
                }
                else
                {
                    DateTime tmpDate = DateTime.Today;
                    if (!DateTime.TryParse(dataRow[2].ToString().Trim(), out tmpDate))
                    {
                        errNum++;
                        strResult.Append("计划时间有误");
                    }
                }
                if (dataRow[3] == null || string.IsNullOrEmpty(dataRow[3].ToString().Trim()))
                {
                    strResult.Append("依据说明未填写");
                    errNum++;
                }
            }
            return colMsg;
        }
        private void ImportImpl2(EntityObject_BGT_D_MACHINE obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_MACHINE fundD = new EntityObject_BGT_D_MACHINE();
                SystemLogic.Proxy.AuditAdd(fundD);
                //fundD.BASE_ID = obj.ID;
                //fundD.BUILDING_NAME = data.Rows[i][0].ToString().Trim();
                //fundD.MONEY = ResolveDataCellNumber(data.Rows[i][1]);
                //fundD.COMPLETE_TIME = DateTime.Parse(data.Rows[i][2].ToString().Trim());
                //fundD.DECLARE_CAUSE = data.Rows[i][3].ToString().Trim();
                HelperObject_BGT_D_MACHINE.Save(fundD, transaction);
            }
        }
        public List<string> CheckService3(EntityObject_BGT_D_MACHINE obj, DataTable data)
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
                            colMsg = CheckImpl3(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_MACHINE> smgr = new ServiceManager<ServiceContract_BGT_D_MACHINE>(ServiceUri))
                {
                    return smgr.Service.CheckService3(obj, data);
                }
            }
        }
        public BizLogicMsg ImportService3(EntityObject_BGT_D_MACHINE obj, DataTable data)
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
                            CauseObject_BGT_D_MACHINE CB = new CauseObject_BGT_D_MACHINE();
                            CB.BASEID = obj.BASEID;
                            int amount = HelperObject_BGT_D_MACHINE.Delete(CB, transaction);
                            ImportImpl3(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_MACHINE> smgr = new ServiceManager<ServiceContract_BGT_D_MACHINE>(ServiceUri))
                {
                    return smgr.Service.ImportService3(obj, data);
                }
            }
        }
        private List<string> CheckImpl3(EntityObject_BGT_D_MACHINE obj, DataTable data, IDbTransaction transaction)
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
                    strResult.Append("设备名称未填写");
                    errNum++;
                }
                if (dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim()))
                {
                    strResult.Append("单价未填写");
                    errNum++;
                }
                else
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim())) ? "0" : dataRow[1].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append("单价有误 ");
                    }
                }
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("设备数量未填写");
                    errNum++;
                }
                else
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim())) ? "0" : dataRow[2].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append("设备数量有误 ");
                    }
                }
               
                if (dataRow[3] == null || string.IsNullOrEmpty(dataRow[3].ToString().Trim()))
                {
                    strResult.Append("依据说明未填写");
                    errNum++;
                }
            }
            return colMsg;
        }
        private void ImportImpl3(EntityObject_BGT_D_MACHINE obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = data.Rows.Count-1; i >=0; i--)
            {
                EntityObject_BGT_D_MACHINE fundD = new EntityObject_BGT_D_MACHINE();
                SystemLogic.Proxy.AuditAdd(fundD);
                fundD.ID = System.Guid.NewGuid().ToString();
                fundD.BASEID = obj.BASEID;
                fundD.NO = data.Rows[i][0].ToString().Trim();
                fundD.BUY = data.Rows[i][1].ToString().Trim();
                fundD.PRICE = data.Rows[i][2].ToString().Trim();
                fundD.NUM = data.Rows[i][3].ToString().Trim();
                fundD.PROJECT = data.Rows[i][4].ToString().Trim();
                fundD.INSTALL = data.Rows[i][5].ToString().Trim();
                fundD.MAN = data.Rows[i][6].ToString().Trim();
                fundD.CONDITION = data.Rows[i][7].ToString().Trim();
                fundD.FREQUENCY = data.Rows[i][8].ToString().Trim();
                fundD.SPEC = data.Rows[i][9].ToString().Trim();
                fundD.NEED = data.Rows[i][10].ToString().Trim();
                HelperObject_BGT_D_MACHINE.Save(fundD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
        #endregion 
    }
}
