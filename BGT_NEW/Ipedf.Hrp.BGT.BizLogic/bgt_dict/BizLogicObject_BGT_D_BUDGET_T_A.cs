﻿
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
	[CauseObject(typeof(CauseObject_BGT_D_BUDGET_T_A))]
	public partial class BizLogicObject_BGT_D_BUDGET_T_A: BizLogicBase<EntityObject_BGT_D_BUDGET_T_A>,ServiceContract_BGT_D_BUDGET_T_A
	{	
		#region Proxy 
		public BizLogicObject_BGT_D_BUDGET_T_A() { }
        private static ServiceContract_BGT_D_BUDGET_T_A singleton;
        public static ServiceContract_BGT_D_BUDGET_T_A Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_D_BUDGET_T_A();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_D_BUDGET_T_A Get(EntityObject_BGT_D_BUDGET_T_A obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_T_A.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_D_BUDGET_T_A[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_T_A.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_D_BUDGET_T_A[] Query(CauseObject_BGT_D_BUDGET_T_A cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_T_A.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_T_A cause)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_D_BUDGET_T_A[] Query(CauseObject_BGT_D_BUDGET_T_A cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_T_A.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_T_A[] objs)
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
							foreach(EntityObject_BGT_D_BUDGET_T_A obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_BUDGET_T_A obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_T_A.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_T_A[] objs)
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
							foreach(EntityObject_BGT_D_BUDGET_T_A obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_BUDGET_T_A obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_T_A[] objs)
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
					foreach (EntityObject_BGT_D_BUDGET_T_A obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_T_A.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
					//平台自动生成代码
							PostArchive(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_T_A obj)
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
							int amount = HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_D_BUDGET_T_A obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_D_BUDGET_T_A.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_D_BUDGET_T_A obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_D_BUDGET_T_A obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_BUDGET_T_A.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_D_BUDGET_T_A cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_BUDGET_T_A.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_D_BUDGET_T_A Load(string id , out EntityObject_BGT_D_BUDGET_T base_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_BUDGET_T_A obj = new EntityObject_BGT_D_BUDGET_T_A();
				
			//平台自动生成代码
			base_id = new EntityObject_BGT_D_BUDGET_T() ; 
			budget_dept_id = new EntityObject_BGT_D_BUDGET_DEPT() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  base_id, out  budget_dept_id);                
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.Load(id , out base_id, out budget_dept_id);
                }
			}
		}
		public EntityObject_BGT_D_BUDGET_T_A Load(IDbTransaction transaction,string id , out EntityObject_BGT_D_BUDGET_T base_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_BUDGET_T_A obj = new EntityObject_BGT_D_BUDGET_T_A();
				
			//平台自动生成代码
			base_id = new EntityObject_BGT_D_BUDGET_T() ; 
			budget_dept_id = new EntityObject_BGT_D_BUDGET_DEPT() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_D_BUDGET_T_A.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.BASE_ID))
						{
							base_id.ID = obj.BASE_ID;
							base_id = HelperObject_BGT_D_BUDGET_T.Get(base_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.BUDGET_DEPT_ID))
						{
							budget_dept_id.ID = obj.BUDGET_DEPT_ID;
							budget_dept_id = HelperObject_BGT_D_BUDGET_DEPT.Get(budget_dept_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T_A[] saveEntities, EntityObject_BGT_D_BUDGET_T_A[] updateEntities, EntityObject_BGT_D_BUDGET_T_A[] deleteEntities)
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
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_T_A.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in deleteEntities)
                            {
                                HelperObject_BGT_D_BUDGET_T_A.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_T_A saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_BGT_D_BUDGET_T_A.Save(saveBaseEntity, transaction);

                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
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
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_T_A deleteBaseEntity)
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
                            CauseObject_ p = new CauseObject_();
                            p. = deleteBaseEntity.ID;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_BGT_D_BUDGET_T_A.Delete(deleteBaseEntity, transaction);
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
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T_A updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_BGT_D_BUDGET_T_A.Update(updateBaseEntity, transaction);

                            //ƽ̨�Զ����ɴ���
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
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
