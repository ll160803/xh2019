
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
	[CauseObject(typeof(CauseObject_COM_ROLE_M_FORM))]
	public partial class BizLogicObject_COM_ROLE_M_FORM: BizLogicBase<EntityObject_COM_ROLE_M_FORM>,ServiceContract_COM_ROLE_M_FORM
	{	
		#region Proxy 
		public BizLogicObject_COM_ROLE_M_FORM() { }
        private static ServiceContract_COM_ROLE_M_FORM singleton;
        public static ServiceContract_COM_ROLE_M_FORM Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_COM_ROLE_M_FORM();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_COM_ROLE_M_FORM Get(EntityObject_COM_ROLE_M_FORM obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_COM_ROLE_M_FORM.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_COM_ROLE_M_FORM[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_COM_ROLE_M_FORM.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_COM_ROLE_M_FORM[] Query(CauseObject_COM_ROLE_M_FORM cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_COM_ROLE_M_FORM.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_COM_ROLE_M_FORM cause)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_COM_ROLE_M_FORM[] Query(CauseObject_COM_ROLE_M_FORM cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_COM_ROLE_M_FORM.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_COM_ROLE_M_FORM[] objs)
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
							foreach(EntityObject_COM_ROLE_M_FORM obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_COM_ROLE_M_FORM obj in objs)
					{
						amount += HelperObject_COM_ROLE_M_FORM.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_COM_ROLE_M_FORM[] objs)
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
							foreach(EntityObject_COM_ROLE_M_FORM obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_COM_ROLE_M_FORM obj in objs)
					{
						amount += HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_COM_ROLE_M_FORM[] objs)
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
					foreach (EntityObject_COM_ROLE_M_FORM obj in objs)
					{
						amount += HelperObject_COM_ROLE_M_FORM.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_COM_ROLE_M_FORM obj)
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
							int amount = HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_COM_ROLE_M_FORM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_COM_ROLE_M_FORM.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_COM_ROLE_M_FORM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_COM_ROLE_M_FORM obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_COM_ROLE_M_FORM.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_COM_ROLE_M_FORM cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_COM_ROLE_M_FORM.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_COM_ROLE_M_FORM Load(string id , out EntityObject_COM_ROLE role_id, out EntityObject_COM_FORM form_id)
		{
			if (LocalMode)
			{
				EntityObject_COM_ROLE_M_FORM obj = new EntityObject_COM_ROLE_M_FORM();
				
			//平台自动生成代码
			role_id = new EntityObject_COM_ROLE() ; 
			form_id = new EntityObject_COM_FORM() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  role_id, out  form_id);                
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
				using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    return smgr.Service.Load(id , out role_id, out form_id);
                }
			}
		}
		public EntityObject_COM_ROLE_M_FORM Load(IDbTransaction transaction,string id , out EntityObject_COM_ROLE role_id, out EntityObject_COM_FORM form_id)
		{
			if (LocalMode)
			{
				EntityObject_COM_ROLE_M_FORM obj = new EntityObject_COM_ROLE_M_FORM();
				
			//平台自动生成代码
			role_id = new EntityObject_COM_ROLE() ; 
			form_id = new EntityObject_COM_FORM() ; 
     
				
						obj.ID= id;
						obj = HelperObject_COM_ROLE_M_FORM.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.ROLE_ID))
						{
							role_id.ID = obj.ROLE_ID;
							role_id = HelperObject_COM_ROLE.Get(role_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.FORM_ID))
						{
							form_id.ID = obj.FORM_ID;
							form_id = HelperObject_COM_FORM.Get(form_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public void CommitUpdate(EntityObject_COM_ROLE_M_FORM[] saveEntities, EntityObject_COM_ROLE_M_FORM[] updateEntities, EntityObject_COM_ROLE_M_FORM[] deleteEntities)
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
                            foreach (EntityObject_COM_ROLE_M_FORM obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_COM_ROLE_M_FORM.Save(obj, transaction);
                            }
                            foreach (EntityObject_COM_ROLE_M_FORM obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_COM_ROLE_M_FORM.Update(obj, transaction);
                            }
                            foreach (EntityObject_COM_ROLE_M_FORM obj in deleteEntities)
                            {
                                HelperObject_COM_ROLE_M_FORM.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public void CommitSave(EntityObject_COM_ROLE_M_FORM saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_COM_ROLE_M_FORM.Save(saveBaseEntity, transaction);

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
                using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public void CommitDelete(EntityObject_COM_ROLE_M_FORM deleteBaseEntity)
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
                            HelperObject_COM_ROLE_M_FORM.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public void CommitUpdate(EntityObject_COM_ROLE_M_FORM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_COM_ROLE_M_FORM.Update(updateBaseEntity, transaction);

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
                using (ServiceManager<ServiceContract_COM_ROLE_M_FORM> smgr = new ServiceManager<ServiceContract_COM_ROLE_M_FORM>(ServiceUri))
                {
                    smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
