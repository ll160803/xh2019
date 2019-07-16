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

	public partial class BizLogicObject_BGT_B_CPN_INC_BASIC
	{
        public BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_BASIC saveBaseEntity, EntityObject_BGT_B_CPN_INC_BASIC_D[] saveDetailEntities)
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
                            SystemLogic.Proxy.AuditAdd(saveBaseEntity);
                            HelperObject_BGT_B_CPN_INC_BASIC.Save(saveBaseEntity, transaction);
                            decimal money = 0;
                            decimal control_money = 0;
                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_CPN_INC_BASIC_D obj in saveDetailEntities)
                            {
                                money += obj.MONEY;
                                control_money += obj.CONTROL_MONEY;
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_CPN_INC_BASIC_D.Save(obj, transaction);
                            }
                            saveBaseEntity.MONEY = money;
                            saveBaseEntity.CONTROL_MONEY = control_money;
                            saveBaseEntity.SetUpdate("MONEY", "CONTROL_MONEY");
                            HelperObject_BGT_B_CPN_INC_BASIC.Update(saveBaseEntity, transaction);
                            PostSave(saveBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_CPN_INC_BASIC> smgr = new ServiceManager<ServiceContract_BGT_B_CPN_INC_BASIC>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_BASIC updateBaseEntity, EntityObject_BGT_B_CPN_INC_BASIC_D[] saveDetailEntities, EntityObject_BGT_B_CPN_INC_BASIC_D[] updateDetailEntities, EntityObject_BGT_B_CPN_INC_BASIC_D[] deleteDetailEntities)
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
                            HelperObject_BGT_B_CPN_INC_BASIC.Update(updateBaseEntity, transaction);
                            decimal money = 0;
                            decimal control_money = 0;
                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_CPN_INC_BASIC_D obj in saveDetailEntities)
                            {
                                money += obj.MONEY;
                                control_money += obj.CONTROL_MONEY;
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_CPN_INC_BASIC_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_BASIC_D obj in updateDetailEntities)
                            {
                                money += obj.MONEY;
                                control_money += obj.CONTROL_MONEY;
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_CPN_INC_BASIC_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_CPN_INC_BASIC_D obj in deleteDetailEntities)
                            {
                                HelperObject_BGT_B_CPN_INC_BASIC_D.Delete(obj, transaction);
                            }
                            updateBaseEntity.CONTROL_MONEY = control_money;
                            updateBaseEntity.MONEY = money;
                            updateBaseEntity.SetUpdate("MONEY", "CONTROL_MONEY");
                            HelperObject_BGT_B_CPN_INC_BASIC.Update(updateBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_CPN_INC_BASIC> smgr = new ServiceManager<ServiceContract_BGT_B_CPN_INC_BASIC>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
	}
}
