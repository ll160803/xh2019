
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
	[CauseObject(typeof(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL))]
	public partial class BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL: BizLogicBase<EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL>,ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL
	{	
		#region Proxy 
		public BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL() { }
        private static ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL singleton;
        public static ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_SCM_B_QUOTEDPRICE_DETAIL();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Get(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs)
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
							foreach(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in objs)
					{
						amount += HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs)
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
							foreach(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in objs)
					{
						amount += HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs)
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
					foreach (EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in objs)
					{
						amount += HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
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
							int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Load(string id )
		{
			if (LocalMode)
			{
				EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj = new EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				
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
				using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.Load(id );
                }
			}
		}
		public EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Load(IDbTransaction transaction,string id )
		{
			if (LocalMode)
			{
				EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj = new EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				
			//平台自动生成代码
     
				  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] saveEntities, EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] updateEntities, EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] deleteEntities)
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
                            foreach (EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Save(obj, transaction);
                            }
                            foreach (EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(obj, transaction);
                            }
                            foreach (EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj in deleteEntities)
                            {
                                HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Save(saveBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.COMMENTS_D;
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
                using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL deleteBaseEntity)
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
                            p. = deleteBaseEntity.COMMENTS_D;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL.Update(updateBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = updateBaseEntity.COMMENTS_D;
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
                using (ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL> smgr = new ServiceManager<ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
