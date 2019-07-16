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
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_BGT_B_CPN_INC_PERSONFUND
    {
        public BizLogicMsg CommitSaveExt(EntityObject_BGT_B_CPN_INC_PERSONFUND entity, EntityObject_BGT_B_CPN_INC_PF_D pfD1, EntityObject_BGT_B_CPN_INC_PF_D pfD2, EntityObject_BGT_B_CPN_INC_PF_D_D[] detail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] detail2)
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
                            SystemLogic.Proxy.AuditAdd(entity);
                            HelperObject_BGT_B_CPN_INC_PERSONFUND.Save(entity, transaction);

                            pfD1.BASE_ID = entity.ID;
                            HelperObject_BGT_B_CPN_INC_PF_D.Save(pfD1, transaction);
                            pfD2.BASE_ID = entity.ID;
                            HelperObject_BGT_B_CPN_INC_PF_D.Save(pfD2, transaction);

                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D detail in detail1)
                            {
                                detail.BASE_ID = pfD1.ID;
                                SystemLogic.Proxy.AuditAdd(detail);
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Save(detail, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D detail in detail2)
                            {
                                detail.BASE_ID = pfD2.ID;
                                SystemLogic.Proxy.AuditAdd(detail);
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Save(detail, transaction);
                            }
                            PostSave(entity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_CPN_INC_PERSONFUND> smgr = new ServiceManager<ServiceContract_BGT_B_CPN_INC_PERSONFUND>(ServiceUri))
                {
                    return smgr.Service.CommitSaveExt(entity, pfD1, pfD2, detail1, detail2);
                }
            }
        }
        public BizLogicMsg CommitUpdateExt(EntityObject_BGT_B_CPN_INC_PERSONFUND entity, EntityObject_BGT_B_CPN_INC_PF_D pfD1, EntityObject_BGT_B_CPN_INC_PF_D pfD2, EntityObject_BGT_B_CPN_INC_PF_D_D[] saveDetail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] updateDetail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] deleteDetail1, EntityObject_BGT_B_CPN_INC_PF_D_D[] saveDetail2, EntityObject_BGT_B_CPN_INC_PF_D_D[] updateDetail2, EntityObject_BGT_B_CPN_INC_PF_D_D[] deleteDetail2)
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
                            SystemLogic.Proxy.AuditEdit(entity);
                            HelperObject_BGT_B_CPN_INC_PERSONFUND.Update(entity, transaction);

                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D obj in saveDetail1)
                            {
                                obj.BASE_ID = pfD1.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D obj in updateDetail1)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D obj in deleteDetail1)
                            {
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Delete(obj, transaction);
                            }

                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D obj in saveDetail2)
                            {
                                obj.BASE_ID = pfD2.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D obj in updateDetail2)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_PF_D_D obj in deleteDetail2)
                            {
                                HelperObject_BGT_B_CPN_INC_PF_D_D.Delete(obj, transaction);
                            }
                            PostSave(entity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_CPN_INC_PERSONFUND> smgr = new ServiceManager<ServiceContract_BGT_B_CPN_INC_PERSONFUND>(ServiceUri))
                {
                    return smgr.Service.CommitUpdateExt(entity, pfD1, pfD2, saveDetail1, updateDetail1, deleteDetail1, saveDetail2, updateDetail2, deleteDetail2);
                }
            }
        }
        public override void PostSave(EntityObject_BGT_B_CPN_INC_PERSONFUND entity, IDbTransaction transaction)
        {
            HelperObject_BGT_B_CPN_INC_PERSONFUND.UpdatePfDD(entity, transaction);
            HelperObject_BGT_B_CPN_INC_PERSONFUND.UpdatePfD(entity, transaction);
            HelperObject_BGT_B_CPN_INC_PERSONFUND.UpdateTotalMoney(entity, transaction);
        }
    }
}
