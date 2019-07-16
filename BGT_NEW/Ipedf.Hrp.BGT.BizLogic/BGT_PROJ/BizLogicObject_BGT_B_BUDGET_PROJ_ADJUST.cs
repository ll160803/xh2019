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
	[CauseObject(typeof(CauseObject_BGT_B_BUDGET_PROJ_ADJUST))]
	public partial class BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST: BizLogicBase<EntityObject_BGT_B_BUDGET_PROJ_ADJUST>,ServiceContract_BGT_B_BUDGET_PROJ_ADJUST
	{	
		#region Proxy 
		public BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST() { }
        private static ServiceContract_BGT_B_BUDGET_PROJ_ADJUST singleton;
        public static ServiceContract_BGT_B_BUDGET_PROJ_ADJUST Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							SystemLogic.Proxy.AuditAdd(obj);
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Save(obj, transaction);
					//平台自动生成代码
							PostSave(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							SystemLogic.Proxy.AuditEdit(obj);
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码
							PostSave(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(obj, transaction);
					//平台自动生成代码
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_B_BUDGET_PROJ_ADJUST Get(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_B_BUDGET_PROJ_ADJUST[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_B_BUDGET_PROJ_ADJUST[] Query(CauseObject_BGT_B_BUDGET_PROJ_ADJUST cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_PROJ_ADJUST cause)
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
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(cause, transaction);
					//平台自动生成代码
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_B_BUDGET_PROJ_ADJUST[] Query(CauseObject_BGT_B_BUDGET_PROJ_ADJUST cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_PROJ_ADJUST[] objs)
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
							foreach(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in objs)
					{
						amount += HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_PROJ_ADJUST[] objs)
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
							foreach(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in objs)
					{
						amount += HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_PROJ_ADJUST[] objs)
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
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in objs)
					{
						amount += HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							SystemLogic.Proxy.AuditCancel(obj);
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码                       
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码
							PostAudit(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
	                        
							SystemLogic.Proxy.AuditUndoAudit(obj);
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码
							PostUndoAudit(obj, transaction);
							//ִ�г��ز���
							msg = SystemLogic.Proxy.BillUndoAudit(obj, transaction);
							if (!msg.Succeed) throw new Exception(msg.Message);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							SystemLogic.Proxy.AuditSubmit(obj);
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码
							PostSubmit(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj)
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
							SystemLogic.Proxy.AuditUndoSubmit(obj);
							int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码
							PostUndoSubmit(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_B_BUDGET_PROJ_ADJUST cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_B_BUDGET_PROJ_ADJUST Load(string id , out EntityObject_BGT_B_BUDGET_PROJ project_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST();
				
			//平台自动生成代码
			project_id = new EntityObject_BGT_B_BUDGET_PROJ() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  project_id);                
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return obj;
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.Load(id , out project_id);
                }
			}
		}
		public EntityObject_BGT_B_BUDGET_PROJ_ADJUST Load(IDbTransaction transaction,string id , out EntityObject_BGT_B_BUDGET_PROJ project_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj = new EntityObject_BGT_B_BUDGET_PROJ_ADJUST();
				
			//平台自动生成代码
			project_id = new EntityObject_BGT_B_BUDGET_PROJ() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.PROJECT_ID))
						{
							project_id.ID = obj.PROJECT_ID;
							project_id = HelperObject_BGT_B_BUDGET_PROJ.Get(project_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ_ADJUST[] saveEntities, EntityObject_BGT_B_BUDGET_PROJ_ADJUST[] updateEntities, EntityObject_BGT_B_BUDGET_PROJ_ADJUST[] deleteEntities)
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
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST obj in deleteEntities)
                            {
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_B_BUDGET_PROJ_ADJUST saveBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D[] saveDetailEntities)
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
                            HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Save(obj, transaction);
                            }
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                  return  smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_B_BUDGET_PROJ_ADJUST deleteBaseEntity)
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
                            //ƽ̨�Զ����ɴ���
                            CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D p = new CauseObject_BGT_B_BUDGET_PROJ_ADJUST_D();
                            p.BASE_ID = deleteBaseEntity.ID;
                            HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Delete(p, transaction);
                            HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ_ADJUST updateBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D[] saveDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D[] updateDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D[] deleteDetailEntities)
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
                            HelperObject_BGT_B_BUDGET_PROJ_ADJUST.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj in deleteDetailEntities)
                            {
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Delete(obj, transaction);
                            }
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST>(ServiceUri))
                {
                   return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
