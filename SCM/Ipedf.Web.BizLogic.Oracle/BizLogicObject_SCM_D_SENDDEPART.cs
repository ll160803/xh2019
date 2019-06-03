
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
	[CauseObject(typeof(CauseObject_SCM_D_SENDDEPART))]
	public partial class BizLogicObject_SCM_D_SENDDEPART: BizLogicBase<EntityObject_SCM_D_SENDDEPART>,ServiceContract_SCM_D_SENDDEPART
	{	
		#region Proxy 
		public BizLogicObject_SCM_D_SENDDEPART() { }
        private static ServiceContract_SCM_D_SENDDEPART singleton;
        public static ServiceContract_SCM_D_SENDDEPART Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_SCM_D_SENDDEPART();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_SCM_D_SENDDEPART Get(EntityObject_SCM_D_SENDDEPART obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_SCM_D_SENDDEPART.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_SCM_D_SENDDEPART[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_SCM_D_SENDDEPART.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_SCM_D_SENDDEPART[] Query(CauseObject_SCM_D_SENDDEPART cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_SCM_D_SENDDEPART.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_SCM_D_SENDDEPART cause)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_SCM_D_SENDDEPART[] Query(CauseObject_SCM_D_SENDDEPART cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_SCM_D_SENDDEPART.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_SCM_D_SENDDEPART[] objs)
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
							foreach(EntityObject_SCM_D_SENDDEPART obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_SCM_D_SENDDEPART obj in objs)
					{
						amount += HelperObject_SCM_D_SENDDEPART.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_SCM_D_SENDDEPART[] objs)
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
							foreach(EntityObject_SCM_D_SENDDEPART obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_SCM_D_SENDDEPART obj in objs)
					{
						amount += HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_SCM_D_SENDDEPART[] objs)
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
					foreach (EntityObject_SCM_D_SENDDEPART obj in objs)
					{
						amount += HelperObject_SCM_D_SENDDEPART.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
					//平台自动生成代码
							PostAudit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已提交);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
					//平台自动生成代码
							PostUndoAudit(obj, transaction);
							//执行撤回操作
							msg = SystemLogic.Proxy.BillUndoAudit(obj, transaction);
							if (!msg.Succeed) throw new Exception(msg.Message);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已审核);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_SCM_D_SENDDEPART obj)
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
							SystemLogic.Proxy.AuditArchive(obj);
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
					//平台自动生成代码
							PostArchive(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已审核);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
					//平台自动生成代码
							PostSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.编辑中);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_SCM_D_SENDDEPART obj)
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
							int amount = HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
					//平台自动生成代码
							PostUndoSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已提交);
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_SCM_D_SENDDEPART obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_SCM_D_SENDDEPART.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_SCM_D_SENDDEPART obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_SCM_D_SENDDEPART obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_SCM_D_SENDDEPART.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_SCM_D_SENDDEPART cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_SCM_D_SENDDEPART.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_SCM_D_SENDDEPART Load(string id )
		{
			if (LocalMode)
			{
				EntityObject_SCM_D_SENDDEPART obj = new EntityObject_SCM_D_SENDDEPART();
				
			//平台自动生成代码

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id );                
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
				using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.Load(id );
                }
			}
		}
		public EntityObject_SCM_D_SENDDEPART Load(IDbTransaction transaction,string id )
		{
			if (LocalMode)
			{
				EntityObject_SCM_D_SENDDEPART obj = new EntityObject_SCM_D_SENDDEPART();
				
			//平台自动生成代码
     
				
						obj.ID= id;
						obj = HelperObject_SCM_D_SENDDEPART.Get(obj,transaction);  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_SCM_D_SENDDEPART[] saveEntities, EntityObject_SCM_D_SENDDEPART[] updateEntities, EntityObject_SCM_D_SENDDEPART[] deleteEntities)
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
                            //平台自动生成代码
                            foreach (EntityObject_SCM_D_SENDDEPART obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_SCM_D_SENDDEPART.Save(obj, transaction);
                            }
                            foreach (EntityObject_SCM_D_SENDDEPART obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_SCM_D_SENDDEPART.Update(obj, transaction);
                            }
                            foreach (EntityObject_SCM_D_SENDDEPART obj in deleteEntities)
                            {
                                HelperObject_SCM_D_SENDDEPART.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_SCM_D_SENDDEPART saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_SCM_D_SENDDEPART.Save(saveBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
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
                using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_SCM_D_SENDDEPART deleteBaseEntity)
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
                            //平台自动生成代码
                            CauseObject_ p = new CauseObject_();
                            p. = deleteBaseEntity.ID;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_SCM_D_SENDDEPART.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_SCM_D_SENDDEPART updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_SCM_D_SENDDEPART.Update(updateBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
                            }
                            foreach (EntityObject_ obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_.Update(obj, transaction);
                            }
                            foreach (EntityObject_ obj in deleteDetailEntities)
                            {
                                HelperObject_.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_SCM_D_SENDDEPART> smgr = new ServiceManager<ServiceContract_SCM_D_SENDDEPART>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
