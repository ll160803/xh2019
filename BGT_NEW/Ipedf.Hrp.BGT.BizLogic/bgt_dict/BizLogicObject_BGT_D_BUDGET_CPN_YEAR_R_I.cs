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
	[CauseObject(typeof(CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I))]
	public partial class BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I: BizLogicBase<EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I>,ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I
	{	
		#region Proxy 
		public BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I() { }
        private static ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I singleton;
        public static ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I Get(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I[] Query(CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I[] Query(CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] objs)
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
							foreach(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] objs)
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
							foreach(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] objs)
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
					foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj)
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
							int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I Load(string id , out EntityObject_COM_TYPE resolve_method_id, out EntityObject_BILL_WORK_FLOW base_id, out EntityObject_BGT_D_PLAN_ITEM item_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
				
			//平台自动生成代码
			resolve_method_id = new EntityObject_COM_TYPE() ; 
			base_id = new EntityObject_BILL_WORK_FLOW() ; 
			item_id = new EntityObject_BGT_D_PLAN_ITEM() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  resolve_method_id, out  base_id, out  item_id);                
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.Load(id , out resolve_method_id, out base_id, out item_id);
                }
			}
		}
		public EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I Load(IDbTransaction transaction,string id , out EntityObject_COM_TYPE resolve_method_id, out EntityObject_BILL_WORK_FLOW base_id, out EntityObject_BGT_D_PLAN_ITEM item_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
				
			//平台自动生成代码
			resolve_method_id = new EntityObject_COM_TYPE() ; 
			base_id = new EntityObject_BILL_WORK_FLOW() ; 
			item_id = new EntityObject_BGT_D_PLAN_ITEM() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.RESOLVE_METHOD_ID))
						{
							resolve_method_id.ID = obj.RESOLVE_METHOD_ID;
							resolve_method_id = HelperObject_COM_TYPE.Get(resolve_method_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.BASE_ID))
						{
							base_id.ID = obj.BASE_ID;
							base_id = HelperObject_BILL_WORK_FLOW.Get(base_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ITEM_ID))
						{
							item_id.ID = obj.ITEM_ID;
							item_id = HelperObject_BGT_D_PLAN_ITEM.Get(item_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] saveEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] updateEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] deleteEntities)
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
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj in deleteEntities)
                            {
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I saveBaseEntity, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D[] saveDetailEntities)
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
                            HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Save(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I deleteBaseEntity)
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
                            CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I_D p = new CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I_D();
                            p.BASE_ID = deleteBaseEntity.ID;
                            HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Delete(p, transaction);
                            HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                   return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I updateBaseEntity, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D[] saveDetailEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D[] updateDetailEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D[] deleteDetailEntities)
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
                            HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I_D obj in deleteDetailEntities)
                            {
                                HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I_D.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
