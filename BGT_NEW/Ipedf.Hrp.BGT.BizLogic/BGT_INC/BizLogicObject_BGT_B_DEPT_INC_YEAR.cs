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
	[CauseObject(typeof(CauseObject_BGT_B_DEPT_INC_YEAR))]
	public partial class BizLogicObject_BGT_B_DEPT_INC_YEAR: BizLogicBase<EntityObject_BGT_B_DEPT_INC_YEAR>,ServiceContract_BGT_B_DEPT_INC_YEAR
	{	
		#region Proxy 
		public BizLogicObject_BGT_B_DEPT_INC_YEAR() { }
        private static ServiceContract_BGT_B_DEPT_INC_YEAR singleton;
        public static ServiceContract_BGT_B_DEPT_INC_YEAR Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_B_DEPT_INC_YEAR();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_B_DEPT_INC_YEAR Get(EntityObject_BGT_B_DEPT_INC_YEAR obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_B_DEPT_INC_YEAR.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_B_DEPT_INC_YEAR[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_B_DEPT_INC_YEAR.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_B_DEPT_INC_YEAR[] Query(CauseObject_BGT_B_DEPT_INC_YEAR cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_B_DEPT_INC_YEAR.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_B_DEPT_INC_YEAR cause)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_B_DEPT_INC_YEAR[] Query(CauseObject_BGT_B_DEPT_INC_YEAR cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_B_DEPT_INC_YEAR.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_INC_YEAR[] objs)
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
							foreach(EntityObject_BGT_B_DEPT_INC_YEAR obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_B_DEPT_INC_YEAR obj in objs)
					{
						amount += HelperObject_BGT_B_DEPT_INC_YEAR.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_INC_YEAR[] objs)
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
							foreach(EntityObject_BGT_B_DEPT_INC_YEAR obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_BGT_B_DEPT_INC_YEAR obj in objs)
					{
						amount += HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_INC_YEAR[] objs)
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
					foreach (EntityObject_BGT_B_DEPT_INC_YEAR obj in objs)
					{
						amount += HelperObject_BGT_B_DEPT_INC_YEAR.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_INC_YEAR obj)
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
							int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_B_DEPT_INC_YEAR obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_B_DEPT_INC_YEAR.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_B_DEPT_INC_YEAR obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_B_DEPT_INC_YEAR obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_B_DEPT_INC_YEAR.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_B_DEPT_INC_YEAR cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_B_DEPT_INC_YEAR.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_B_DEPT_INC_YEAR Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_T templet_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year)
		{
			if (LocalMode)
			{
				EntityObject_BGT_B_DEPT_INC_YEAR obj = new EntityObject_BGT_B_DEPT_INC_YEAR();
				
			//平台自动生成代码
			budget_dept_id = new EntityObject_BGT_D_BUDGET_DEPT() ; 
			templet_id = new EntityObject_BGT_D_BUDGET_T() ; 
			budget_year = new EntityObject_BGT_D_BUDGET_YEAR() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  budget_dept_id, out  templet_id, out  budget_year);                
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
				using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.Load(id , out budget_dept_id, out templet_id, out budget_year);
                }
			}
		}
		public EntityObject_BGT_B_DEPT_INC_YEAR Load(IDbTransaction transaction,string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_T templet_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year)
		{
			if (LocalMode)
			{
				EntityObject_BGT_B_DEPT_INC_YEAR obj = new EntityObject_BGT_B_DEPT_INC_YEAR();
				
			//平台自动生成代码
			budget_dept_id = new EntityObject_BGT_D_BUDGET_DEPT() ; 
			templet_id = new EntityObject_BGT_D_BUDGET_T() ; 
			budget_year = new EntityObject_BGT_D_BUDGET_YEAR() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_B_DEPT_INC_YEAR.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.BUDGET_DEPT_ID))
						{
							budget_dept_id.ID = obj.BUDGET_DEPT_ID;
							budget_dept_id = HelperObject_BGT_D_BUDGET_DEPT.Get(budget_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.TEMPLET_ID))
						{
							templet_id.ID = obj.TEMPLET_ID;
							templet_id = HelperObject_BGT_D_BUDGET_T.Get(templet_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.BUDGET_YEAR))
						{
							budget_year.ID = obj.BUDGET_YEAR;
							budget_year = HelperObject_BGT_D_BUDGET_YEAR.Get(budget_year, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_INC_YEAR[] saveEntities, EntityObject_BGT_B_DEPT_INC_YEAR[] updateEntities, EntityObject_BGT_B_DEPT_INC_YEAR[] deleteEntities)
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
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_DEPT_INC_YEAR.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_DEPT_INC_YEAR.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR obj in deleteEntities)
                            {
                                HelperObject_BGT_B_DEPT_INC_YEAR.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_INC_YEAR saveBaseEntity, EntityObject_BGT_B_DEPT_INC_YEAR_D[] saveDetailEntities)
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
                            HelperObject_BGT_B_DEPT_INC_YEAR.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_DEPT_INC_YEAR_D.Save(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_INC_YEAR deleteBaseEntity)
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
                            CauseObject_BGT_B_DEPT_INC_YEAR_D p = new CauseObject_BGT_B_DEPT_INC_YEAR_D();
                            p.BASE_ID = deleteBaseEntity.ID;
                            HelperObject_BGT_B_DEPT_INC_YEAR_D.Delete(p, transaction);
                            HelperObject_BGT_B_DEPT_INC_YEAR.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_INC_YEAR updateBaseEntity, EntityObject_BGT_B_DEPT_INC_YEAR_D[] saveDetailEntities, EntityObject_BGT_B_DEPT_INC_YEAR_D[] updateDetailEntities, EntityObject_BGT_B_DEPT_INC_YEAR_D[] deleteDetailEntities)
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
                            HelperObject_BGT_B_DEPT_INC_YEAR.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_B_DEPT_INC_YEAR_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR_D obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_B_DEPT_INC_YEAR_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_B_DEPT_INC_YEAR_D obj in deleteDetailEntities)
                            {
                                HelperObject_BGT_B_DEPT_INC_YEAR_D.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_INC_YEAR>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
