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
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_SCM_B_QUOTEDPRICE
    {


        public BizLogicMsg DeleteQUOTEDPRICE(string base_id, string GysAccount, string GysName)
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
                            var cause_d = new CauseObject_SCM_B_QUOTEDPRICE_D();
                            cause_d.SetCustomCondition(string.Format(" and SCM_B_QUOTEDPRICE_D.BASE_ID in (select ID  from SCM_B_QUOTEDPRICE where BASE_ID='{0}' and GYSACCOUNT='{1}' )", base_id, GysAccount));
                            HelperObject_SCM_B_QUOTEDPRICE_D.Delete(cause_d, transaction);

                            var cause = new CauseObject_SCM_B_QUOTEDPRICE();
                            cause.SetCustomCondition(string.Format(" and SCM_B_QUOTEDPRICE.BASE_ID ='{0}' and GYSACCOUNT='{1}' ", base_id, GysAccount));
                            HelperObject_SCM_B_QUOTEDPRICE.Delete(cause, transaction);
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
                using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE>(ServiceUri))
                {
                    return smgr.Service.DeleteQUOTEDPRICE(base_id, GysAccount, GysName);
                }
            }
        }
        public BizLogicMsg SaveQUOTEDPRICE(string base_id, List<DisplayObject_SCM_B_QUOTEDPRICE> data, int state, string GysAccount, string GysName)
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
                            #region 删除已经存在的数据
                            var cause_d = new CauseObject_SCM_B_QUOTEDPRICE_D();
                            cause_d.SetCustomCondition(string.Format(" and SCM_B_QUOTEDPRICE_D.BASE_ID in (select ID  from SCM_B_QUOTEDPRICE where BASE_ID='{0}' and GYSACCOUNT='{1}' )", base_id, GysAccount));
                            HelperObject_SCM_B_QUOTEDPRICE_D.Delete(cause_d, transaction);

                            var cause = new CauseObject_SCM_B_QUOTEDPRICE();
                            cause.SetCustomCondition(string.Format(" and SCM_B_QUOTEDPRICE.BASE_ID ='{0}' and GYSACCOUNT='{1}' ", base_id, GysAccount));
                            HelperObject_SCM_B_QUOTEDPRICE.Delete(cause, transaction);
                            #endregion
                            foreach (var item in data)
                            {
                                EntityObject_SCM_B_QUOTEDPRICE en = new EntityObject_SCM_B_QUOTEDPRICE
                                {
                                    BASE_ID = base_id,
                                    DISPLAY_INDEX = item.DISPLAY_INDEX,
                                    GYSACCOUNT = GysAccount,
                                    GYSNAME = GysName,
                                    PRODUCT_NAME = item.PRODUCT_NAME,
                                    QUOTED_PRICE = item.QUOTED_PRICE,
                                    SUPPLY_AMOUNT = item.SUPPLY_AMOUNT,
                                    COMMENTS = item.COMMENTS
                                };
                                SystemLogic.Proxy.AuditAdd(en);
                                en.STATE = state;
                                HelperObject_SCM_B_QUOTEDPRICE.Save(en, transaction);
                                foreach (var item_d in item.Hospitals)
                                {
                                    EntityObject_SCM_B_QUOTEDPRICE_D en_d = new EntityObject_SCM_B_QUOTEDPRICE_D
                                    {
                                        BASE_ID = en.ID,
                                        COMMENTS_D = item_d.COMMENTS_D,
                                        DISPLAY_INDEX = item_d.DISPLAY_INDEX,
                                        HOSPITAL_NAME = item_d.HOSPITAL_NAME,
                                        PRICE = item_d.PRICE,
                                        COM_FILE_ID = item_d.COM_FILE_ID
                                    };
                                    HelperObject_SCM_B_QUOTEDPRICE_D.Save(en_d, transaction);
                                }
                            }
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
                using (ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUOTEDPRICE>(ServiceUri))
                {
                    return smgr.Service.SaveQUOTEDPRICE(base_id, data, state, GysAccount, GysName);
                }
            }
        }
    }
}
