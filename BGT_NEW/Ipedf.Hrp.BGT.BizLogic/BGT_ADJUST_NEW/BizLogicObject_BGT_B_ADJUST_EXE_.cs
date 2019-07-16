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
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_B_ADJUST_EXE
    {
        public BizLogicMsg CommitUpdate(EntityObject_BGT_B_ADJUST_EXE updateBaseEntity, EntityObject_BGT_B_ADJUST_EXE_D[] saveDetailEntities, EntityObject_BGT_B_ADJUST_EXE_D[] updateDetailEntities, EntityObject_BGT_B_ADJUST_EXE_D[] deleteDetailEntities)
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
                            SystemLogic.Proxy.AuditEdit(updateBaseEntity);
                            HelperObject_BGT_B_ADJUST_EXE.Update(updateBaseEntity, transaction);

                            var total_EXE_MONEY = 0m;
                            var total_CHANGEMONEY = 0m;
                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_ADJUST_EXE_D obj in saveDetailEntities)
                            {
                                total_EXE_MONEY += obj.EXE_MONEY;
                                total_CHANGEMONEY += obj.CHANGE_MONEY;
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_ADJUST_EXE_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_ADJUST_EXE_D obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                total_EXE_MONEY += obj.EXE_MONEY;
                                total_CHANGEMONEY += obj.CHANGE_MONEY;
                                HelperObject_BGT_B_ADJUST_EXE_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_ADJUST_EXE_D obj in deleteDetailEntities)
                            {
                                HelperObject_BGT_B_ADJUST_EXE_D.Delete(obj, transaction);
                            }
                            updateBaseEntity.EXE_TOTAL_MONEY = total_EXE_MONEY;
                            updateBaseEntity.TOTAL_MONEY = total_CHANGEMONEY;
                            updateBaseEntity.SetUpdate("TOTAL_MONEY");
                            HelperObject_BGT_B_ADJUST_EXE.Update(updateBaseEntity, transaction);
                            PostSave(updateBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }

        public BizLogicMsg CommitSaveMainAndSub(EntityObject_BGT_B_ADJUST_EXE updateBaseEntity, EntityObject_BGT_B_ADJUST_EXE_D[] saveDetailEntities)
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
                            updateBaseEntity = HelperObject_BGT_B_ADJUST_EXE.Get(updateBaseEntity);

                            var total_EXE_MONEY = 0m;
                           
                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_ADJUST_EXE_D obj in saveDetailEntities)
                            {
                                total_EXE_MONEY += obj.EXE_MONEY;
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_ADJUST_EXE_D.Save(obj, transaction);
                            }

                            updateBaseEntity.EXE_TOTAL_MONEY =updateBaseEntity.EXE_TOTAL_MONEY + total_EXE_MONEY;
                            updateBaseEntity.SetUpdate("EXE_TOTAL_MONEY");
                            HelperObject_BGT_B_ADJUST_EXE.Update(updateBaseEntity, transaction);
                            PostSave(updateBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.CommitSaveMainAndSub(updateBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_B_ADJUST_EXE obj)
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
                            SystemLogic.Proxy.AuditAudit(obj);
                            int amount = HelperObject_BGT_B_ADJUST_EXE.Update(obj, transaction);
                            //平台自动生成代码
                            PostAudit(obj, transaction);

                            #region 修改执性表
                            var list = HelperObject_BGT_B_ADJUST_EXE_D.Query(new CauseObject_BGT_B_ADJUST_EXE_D { BASE_ID = obj.ID });

                            foreach (var item in list)
                            {
                                var en = new EntityObject_BGT_B_DEPT_FUND_EXE { ID = item.REF_TAB_ID, NEW_FUND_MONEY = item.CHANGE_MONEY };
                                en.SetUpdate("NEW_FUND_MONEY");
                                HelperObject_BGT_B_DEPT_FUND_EXE.Update(en, transaction);
                            }

                            #endregion


                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            SystemLogic.Proxy.AuditState(obj, Ipedf.Common.数据状态.已提交);
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
                using (ServiceManager<ServiceContract_BGT_B_ADJUST_EXE> smgr = new ServiceManager<ServiceContract_BGT_B_ADJUST_EXE>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
    }
}
