using System;
using System.Data;
using System.Collections;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web.BizLogic
{
	[CauseObject(typeof(CauseObject_COM_FILE))]
	public partial class BizLogicObject_COM_FILE: BizLogicBase<EntityObject_COM_FILE>
	{	
		#region Proxy 
		private BizLogicObject_COM_FILE() { }
        private static BizLogicObject_COM_FILE singleton;
        public static BizLogicObject_COM_FILE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_COM_FILE();
                return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_COM_FILE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAdd(obj);
                        int amount = HelperObject_COM_FILE.Save(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_COM_FILE obj)
		{
			
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
                        int amount = HelperObject_COM_FILE.Update(obj, transaction);
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
		public BizLogicMsg Delete(EntityObject_COM_FILE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
					try
                    {
						int amount = HelperObject_COM_FILE.Delete(obj, transaction);
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
		public EntityObject_COM_FILE Get(EntityObject_COM_FILE obj)
		{
			
			//平台自动生成代码
			return HelperObject_COM_FILE.Get(obj);
		}
		public DisplayObject_COM_FILE[] List()
		{
			
			//平台自动生成代码
			return HelperObject_COM_FILE.List();
		}		
		public DisplayObject_COM_FILE[] Query(CauseObject_COM_FILE cause)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_COM_FILE.Query(cause);
		}
		public BizLogicMsg Delete(CauseObject_COM_FILE cause)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        int amount = HelperObject_COM_FILE.Delete(cause, transaction);
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
		public DisplayObject_COM_FILE[] Query(CauseObject_COM_FILE cause,PagingParamter paging,OrderByParameter order)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_COM_FILE.Query(cause, paging, order);
		}	
		public BizLogicMsg BatchSave(EntityObject_COM_FILE[] objs)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        foreach(EntityObject_COM_FILE obj in objs)
                        {
                           SystemLogic.Proxy.AuditAdd(obj);
                        }
                        int amount = 0;
						
			//平台自动生成代码
					foreach (EntityObject_COM_FILE obj in objs)
					{
						amount += HelperObject_COM_FILE.Save(obj, transaction);
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
        public BizLogicMsg BatchUpdate(EntityObject_COM_FILE[] objs)
        {

            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                   
                    try
                    {
                        foreach(EntityObject_COM_FILE obj in objs)
                        {
                           SystemLogic.Proxy.AuditEdit(obj);
                        }
                        int amount = 0;                        
						
			//平台自动生成代码
					foreach (EntityObject_COM_FILE obj in objs)
					{
						amount += HelperObject_COM_FILE.Update(obj, transaction);
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
        public BizLogicMsg BatchDelete(EntityObject_COM_FILE[] objs)
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
					foreach (EntityObject_COM_FILE obj in objs)
					{
						amount += HelperObject_COM_FILE.Delete(obj, transaction);
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
        public BizLogicMsg Cancel(EntityObject_COM_FILE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SystemLogic.Proxy.AuditCancel(obj);
                        int amount = HelperObject_COM_FILE.Update(obj, transaction);
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
        public BizLogicMsg Audit(EntityObject_COM_FILE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAudit(obj);
						int amount = HelperObject_COM_FILE.Update(obj, transaction);
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
        public BizLogicMsg UndoAudit(EntityObject_COM_FILE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        
                        SystemLogic.Proxy.AuditUndoAudit(obj);
						int amount = HelperObject_COM_FILE.Update(obj, transaction);
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
        public BizLogicMsg Submit(EntityObject_COM_FILE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditSubmit(obj);
						int amount = HelperObject_COM_FILE.Update(obj, transaction);
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
        public BizLogicMsg UndoSubmit(EntityObject_COM_FILE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        SystemLogic.Proxy.AuditUndoSubmit(obj);
						int amount = HelperObject_COM_FILE.Update(obj, transaction);
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
        
        public int SaveByTrans(EntityObject_COM_FILE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditAdd(obj);
            int amount = HelperObject_COM_FILE.Save(obj, transaction);
					//平台自动生成代码             
            
            return amount;
        }
        public int UpdateByTrans(EntityObject_COM_FILE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditEdit(obj);
            return HelperObject_COM_FILE.Update(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans(EntityObject_COM_FILE obj, IDbTransaction transaction)
        {
            return HelperObject_COM_FILE.Delete(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans2(CauseObject_COM_FILE cause, IDbTransaction transaction)
        {
            return HelperObject_COM_FILE.Delete(cause, transaction);
					//平台自动生成代码
        }
        public EntityObject_COM_FILE Load(string id )
		{

			EntityObject_COM_FILE obj = new EntityObject_COM_FILE();
			
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
		public EntityObject_COM_FILE Load(IDbTransaction transaction,string id )
		{
			EntityObject_COM_FILE obj = new EntityObject_COM_FILE();
            
			//平台自动生成代码
     
            
						obj.ID= id;
						obj = HelperObject_COM_FILE.Get(obj,transaction);  
            return obj;
		}
		#endregion 
	}
}
