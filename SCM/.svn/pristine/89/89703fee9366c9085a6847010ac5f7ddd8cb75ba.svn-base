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
	[CauseObject(typeof(CauseObject_SITE_USER_ACCOUNT_TRADE))]
	public partial class BizLogicObject_SITE_USER_ACCOUNT_TRADE: BizLogicBase<EntityObject_SITE_USER_ACCOUNT_TRADE>
	{	
		#region Proxy 
		private BizLogicObject_SITE_USER_ACCOUNT_TRADE() { }
        private static BizLogicObject_SITE_USER_ACCOUNT_TRADE singleton;
        public static BizLogicObject_SITE_USER_ACCOUNT_TRADE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_SITE_USER_ACCOUNT_TRADE();
                return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAdd(obj);
                        int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Save(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
		{
			
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
                        int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
		public BizLogicMsg Delete(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
					try
                    {
						int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Delete(obj, transaction);
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
		public EntityObject_SITE_USER_ACCOUNT_TRADE Get(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
		{
			
			//平台自动生成代码
			return HelperObject_SITE_USER_ACCOUNT_TRADE.Get(obj);
		}
		public DisplayObject_SITE_USER_ACCOUNT_TRADE[] List()
		{
			
			//平台自动生成代码
			return HelperObject_SITE_USER_ACCOUNT_TRADE.List();
		}		
		public DisplayObject_SITE_USER_ACCOUNT_TRADE[] Query(CauseObject_SITE_USER_ACCOUNT_TRADE cause)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_SITE_USER_ACCOUNT_TRADE.Query(cause);
		}
		public BizLogicMsg Delete(CauseObject_SITE_USER_ACCOUNT_TRADE cause)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Delete(cause, transaction);
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
		public DisplayObject_SITE_USER_ACCOUNT_TRADE[] Query(CauseObject_SITE_USER_ACCOUNT_TRADE cause,PagingParamter paging,OrderByParameter order)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_SITE_USER_ACCOUNT_TRADE.Query(cause, paging, order);
		}	
		public BizLogicMsg BatchSave(EntityObject_SITE_USER_ACCOUNT_TRADE[] objs)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        foreach(EntityObject_SITE_USER_ACCOUNT_TRADE obj in objs)
                        {
                           SystemLogic.Proxy.AuditAdd(obj);
                        }
                        int amount = 0;
						
			//平台自动生成代码
					foreach (EntityObject_SITE_USER_ACCOUNT_TRADE obj in objs)
					{
						amount += HelperObject_SITE_USER_ACCOUNT_TRADE.Save(obj, transaction);
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
        public BizLogicMsg BatchUpdate(EntityObject_SITE_USER_ACCOUNT_TRADE[] objs)
        {

            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                   
                    try
                    {
                        foreach(EntityObject_SITE_USER_ACCOUNT_TRADE obj in objs)
                        {
                           SystemLogic.Proxy.AuditEdit(obj);
                        }
                        int amount = 0;                        
						
			//平台自动生成代码
					foreach (EntityObject_SITE_USER_ACCOUNT_TRADE obj in objs)
					{
						amount += HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
        public BizLogicMsg BatchDelete(EntityObject_SITE_USER_ACCOUNT_TRADE[] objs)
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
					foreach (EntityObject_SITE_USER_ACCOUNT_TRADE obj in objs)
					{
						amount += HelperObject_SITE_USER_ACCOUNT_TRADE.Delete(obj, transaction);
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
        public BizLogicMsg Cancel(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SystemLogic.Proxy.AuditCancel(obj);
                        int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
        public BizLogicMsg Audit(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAudit(obj);
						int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
        public BizLogicMsg UndoAudit(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        
                        SystemLogic.Proxy.AuditUndoAudit(obj);
						int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
        public BizLogicMsg Submit(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditSubmit(obj);
						int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
        public BizLogicMsg UndoSubmit(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        SystemLogic.Proxy.AuditUndoSubmit(obj);
						int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
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
        
        public int SaveByTrans(EntityObject_SITE_USER_ACCOUNT_TRADE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditAdd(obj);
            int amount = HelperObject_SITE_USER_ACCOUNT_TRADE.Save(obj, transaction);
					//平台自动生成代码             
            
            return amount;
        }
        public int UpdateByTrans(EntityObject_SITE_USER_ACCOUNT_TRADE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditEdit(obj);
            return HelperObject_SITE_USER_ACCOUNT_TRADE.Update(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans(EntityObject_SITE_USER_ACCOUNT_TRADE obj, IDbTransaction transaction)
        {
            return HelperObject_SITE_USER_ACCOUNT_TRADE.Delete(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans2(CauseObject_SITE_USER_ACCOUNT_TRADE cause, IDbTransaction transaction)
        {
            return HelperObject_SITE_USER_ACCOUNT_TRADE.Delete(cause, transaction);
					//平台自动生成代码
        }
        public EntityObject_SITE_USER_ACCOUNT_TRADE Load(string id , out EntityObject_SITE_USER_ACCOUNT account_id, out EntityObject_SITE_ORDER order_id, out EntityObject_COM_TYPE trade_type)
		{

			EntityObject_SITE_USER_ACCOUNT_TRADE obj = new EntityObject_SITE_USER_ACCOUNT_TRADE();
            
			//平台自动生成代码
			account_id = new EntityObject_SITE_USER_ACCOUNT() ; 
			order_id = new EntityObject_SITE_ORDER() ; 
			trade_type = new EntityObject_COM_TYPE() ; 
     
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        
						obj.ID= id;
						obj = HelperObject_SITE_USER_ACCOUNT_TRADE.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.ACCOUNT_ID))
						{
							account_id.ID = obj.ACCOUNT_ID;
							account_id = HelperObject_SITE_USER_ACCOUNT.Get(account_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ORDER_ID))
						{
							order_id.ID = obj.ORDER_ID;
							order_id = HelperObject_SITE_ORDER.Get(order_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.TRADE_TYPE))
						{
							trade_type.ID = obj.TRADE_TYPE;
							trade_type = HelperObject_COM_TYPE.Get(trade_type, transaction);
						}                    
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
		#endregion 
	}
}
