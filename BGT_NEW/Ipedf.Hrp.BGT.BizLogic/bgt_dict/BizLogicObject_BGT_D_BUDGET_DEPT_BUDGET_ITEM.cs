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
    [CauseObject(typeof(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM))]
	public partial class BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM: BizLogicBase<EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM>,ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM
	{	
		#region Proxy 
		public BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM() { }
        private static ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM singleton;
        public static ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM Get(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs)
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
							foreach(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs)
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
							foreach(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs)
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
					foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in objs)
					{
						amount += HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg BatchDeleteEct(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs)
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
                            foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in objs)
                            {
                                amount += HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.DeleteEct(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchDeleteEct(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj)
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
							int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM Load(string id , out EntityObject_BGT_D_BUDGET_ITEM BUDGET_ITEM_ID)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj = new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
				
			//平台自动生成代码
			BUDGET_ITEM_ID = new EntityObject_BGT_D_BUDGET_ITEM() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  BUDGET_ITEM_ID);                
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
				using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.Load(id , out BUDGET_ITEM_ID);
                }
			}
		}
		public EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM Load(IDbTransaction transaction,string id , out EntityObject_BGT_D_BUDGET_ITEM BUDGET_ITEM_ID)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj = new EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM();
				
			//平台自动生成代码
			BUDGET_ITEM_ID = new EntityObject_BGT_D_BUDGET_ITEM() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.BUDGET_ITEM_ID))
						{
							BUDGET_ITEM_ID.ID = obj.BUDGET_ITEM_ID;
							BUDGET_ITEM_ID = HelperObject_BGT_D_BUDGET_ITEM.Get(BUDGET_ITEM_ID, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] saveEntities, EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] updateEntities, EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] deleteEntities)
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
                            foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj in deleteEntities)
                            {
                                HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Save(saveBaseEntity, transaction);
							
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM deleteBaseEntity)
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
                            HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM.Update(updateBaseEntity, transaction);
							
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
