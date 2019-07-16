
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
	[CauseObject(typeof(CauseObject_BGT_D_PLAN_ITEM))]
	public partial class BizLogicObject_BGT_D_PLAN_ITEM: BizLogicBase<EntityObject_BGT_D_PLAN_ITEM>,ServiceContract_BGT_D_PLAN_ITEM
	{	
		#region Proxy 
		public BizLogicObject_BGT_D_PLAN_ITEM() { }
        private static ServiceContract_BGT_D_PLAN_ITEM singleton;
        public static ServiceContract_BGT_D_PLAN_ITEM Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BGT_D_PLAN_ITEM();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_BGT_D_PLAN_ITEM Get(EntityObject_BGT_D_PLAN_ITEM obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_PLAN_ITEM.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_BGT_D_PLAN_ITEM[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_BGT_D_PLAN_ITEM.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_BGT_D_PLAN_ITEM[] Query(CauseObject_BGT_D_PLAN_ITEM cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_PLAN_ITEM.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_BGT_D_PLAN_ITEM cause)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_BGT_D_PLAN_ITEM[] Query(CauseObject_BGT_D_PLAN_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_BGT_D_PLAN_ITEM.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_BGT_D_PLAN_ITEM[] objs)
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
							foreach(EntityObject_BGT_D_PLAN_ITEM obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_PLAN_ITEM obj in objs)
					{
						amount += HelperObject_BGT_D_PLAN_ITEM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_BGT_D_PLAN_ITEM[] objs)
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
							foreach(EntityObject_BGT_D_PLAN_ITEM obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_BGT_D_PLAN_ITEM obj in objs)
					{
						amount += HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_BGT_D_PLAN_ITEM[] objs)
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
					foreach (EntityObject_BGT_D_PLAN_ITEM obj in objs)
					{
						amount += HelperObject_BGT_D_PLAN_ITEM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_BGT_D_PLAN_ITEM obj)
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
							int amount = HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_BGT_D_PLAN_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_BGT_D_PLAN_ITEM.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_BGT_D_PLAN_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_BGT_D_PLAN_ITEM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_PLAN_ITEM.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_BGT_D_PLAN_ITEM cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_BGT_D_PLAN_ITEM.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_BGT_D_PLAN_ITEM Load(string id , out EntityObject_COM_TYPE prepare_pattern_id, out EntityObject_COM_TYPE import_type_id, out EntityObject_COM_TYPE advice_classify_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE item_classify_id, out EntityObject_COM_TYPE data_type_id, out EntityObject_COM_TYPE item_type_id, out EntityObject_COM_TYPE unit_id, out EntityObject_COM_TYPE source_type_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_PLAN_ITEM obj = new EntityObject_BGT_D_PLAN_ITEM();
				
			//平台自动生成代码
			prepare_pattern_id = new EntityObject_COM_TYPE() ; 
			import_type_id = new EntityObject_COM_TYPE() ; 
			advice_classify_id = new EntityObject_COM_TYPE() ; 
			budget_year = new EntityObject_BGT_D_BUDGET_YEAR() ; 
			item_classify_id = new EntityObject_COM_TYPE() ; 
			data_type_id = new EntityObject_COM_TYPE() ; 
			item_type_id = new EntityObject_COM_TYPE() ; 
			unit_id = new EntityObject_COM_TYPE() ; 
			source_type_id = new EntityObject_COM_TYPE() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  prepare_pattern_id, out  import_type_id, out  advice_classify_id, out  budget_year, out  item_classify_id, out  data_type_id, out  item_type_id, out  unit_id, out  source_type_id);                
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
				using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.Load(id , out prepare_pattern_id, out import_type_id, out advice_classify_id, out budget_year, out item_classify_id, out data_type_id, out item_type_id, out unit_id, out source_type_id);
                }
			}
		}
		public EntityObject_BGT_D_PLAN_ITEM Load(IDbTransaction transaction,string id , out EntityObject_COM_TYPE prepare_pattern_id, out EntityObject_COM_TYPE import_type_id, out EntityObject_COM_TYPE advice_classify_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE item_classify_id, out EntityObject_COM_TYPE data_type_id, out EntityObject_COM_TYPE item_type_id, out EntityObject_COM_TYPE unit_id, out EntityObject_COM_TYPE source_type_id)
		{
			if (LocalMode)
			{
				EntityObject_BGT_D_PLAN_ITEM obj = new EntityObject_BGT_D_PLAN_ITEM();
				
			//平台自动生成代码
			prepare_pattern_id = new EntityObject_COM_TYPE() ; 
			import_type_id = new EntityObject_COM_TYPE() ; 
			advice_classify_id = new EntityObject_COM_TYPE() ; 
			budget_year = new EntityObject_BGT_D_BUDGET_YEAR() ; 
			item_classify_id = new EntityObject_COM_TYPE() ; 
			data_type_id = new EntityObject_COM_TYPE() ; 
			item_type_id = new EntityObject_COM_TYPE() ; 
			unit_id = new EntityObject_COM_TYPE() ; 
			source_type_id = new EntityObject_COM_TYPE() ; 
     
				
						obj.ID= id;
						obj = HelperObject_BGT_D_PLAN_ITEM.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.PREPARE_PATTERN_ID))
						{
							prepare_pattern_id.ID = obj.PREPARE_PATTERN_ID;
							prepare_pattern_id = HelperObject_COM_TYPE.Get(prepare_pattern_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.IMPORT_TYPE_ID))
						{
							import_type_id.ID = obj.IMPORT_TYPE_ID;
							import_type_id = HelperObject_COM_TYPE.Get(import_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ADVICE_CLASSIFY_ID))
						{
							advice_classify_id.ID = obj.ADVICE_CLASSIFY_ID;
							advice_classify_id = HelperObject_COM_TYPE.Get(advice_classify_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.BUDGET_YEAR))
						{
							budget_year.ID = obj.BUDGET_YEAR;
							budget_year = HelperObject_BGT_D_BUDGET_YEAR.Get(budget_year, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ITEM_CLASSIFY_ID))
						{
							item_classify_id.ID = obj.ITEM_CLASSIFY_ID;
							item_classify_id = HelperObject_COM_TYPE.Get(item_classify_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.DATA_TYPE_ID))
						{
							data_type_id.ID = obj.DATA_TYPE_ID;
							data_type_id = HelperObject_COM_TYPE.Get(data_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ITEM_TYPE_ID))
						{
							item_type_id.ID = obj.ITEM_TYPE_ID;
							item_type_id = HelperObject_COM_TYPE.Get(item_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.UNIT_ID))
						{
							unit_id.ID = obj.UNIT_ID;
							unit_id = HelperObject_COM_TYPE.Get(unit_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.SOURCE_TYPE_ID))
						{
							source_type_id.ID = obj.SOURCE_TYPE_ID;
							source_type_id = HelperObject_COM_TYPE.Get(source_type_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_BGT_D_PLAN_ITEM[] saveEntities, EntityObject_BGT_D_PLAN_ITEM[] updateEntities, EntityObject_BGT_D_PLAN_ITEM[] deleteEntities)
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
                            foreach (EntityObject_BGT_D_PLAN_ITEM obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_PLAN_ITEM.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_PLAN_ITEM obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_D_PLAN_ITEM.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_PLAN_ITEM obj in deleteEntities)
                            {
                                HelperObject_BGT_D_PLAN_ITEM.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_BGT_D_PLAN_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_BGT_D_PLAN_ITEM.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
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
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_BGT_D_PLAN_ITEM deleteBaseEntity)
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
                            HelperObject_BGT_D_PLAN_ITEM.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_D_PLAN_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_BGT_D_PLAN_ITEM.Update(updateBaseEntity, transaction);
							
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
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_PLAN_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_PLAN_ITEM>(ServiceUri))
                {
                    smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
