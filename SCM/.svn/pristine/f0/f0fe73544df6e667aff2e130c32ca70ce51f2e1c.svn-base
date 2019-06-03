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
	[CauseObject(typeof(CauseObject_BILL_WORK_FLOW))]
    public partial class BizLogicObject_BILL_WORK_FLOW : BizLogicBase<EntityObject_BILL_WORK_FLOW>
	{	
		#region Proxy 
		private BizLogicObject_BILL_WORK_FLOW() { }
        private static BizLogicObject_BILL_WORK_FLOW singleton;
        public static BizLogicObject_BILL_WORK_FLOW Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_BILL_WORK_FLOW();
                return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_BILL_WORK_FLOW obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAdd(obj);
                        int amount = HelperObject_BILL_WORK_FLOW.Save(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_BILL_WORK_FLOW obj)
		{
			
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
                        int amount = HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
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
		public BizLogicMsg Delete(EntityObject_BILL_WORK_FLOW obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
					try
                    {
						int amount = HelperObject_BILL_WORK_FLOW.Delete(obj, transaction);
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
		public EntityObject_BILL_WORK_FLOW Get(EntityObject_BILL_WORK_FLOW obj)
		{
			
			//平台自动生成代码
			return HelperObject_BILL_WORK_FLOW.Get(obj);
		}
		public DisplayObject_BILL_WORK_FLOW[] List()
		{
			
			//平台自动生成代码
			return HelperObject_BILL_WORK_FLOW.List();
		}		
		public DisplayObject_BILL_WORK_FLOW[] Query(CauseObject_BILL_WORK_FLOW cause)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_BILL_WORK_FLOW.Query(cause);
		}
		public BizLogicMsg Delete(CauseObject_BILL_WORK_FLOW cause)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        int amount = HelperObject_BILL_WORK_FLOW.Delete(cause, transaction);
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
		public DisplayObject_BILL_WORK_FLOW[] Query(CauseObject_BILL_WORK_FLOW cause,PagingParamter paging,OrderByParameter order)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_BILL_WORK_FLOW.Query(cause, paging, order);
		}	
		public BizLogicMsg BatchSave(EntityObject_BILL_WORK_FLOW[] objs)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        foreach(EntityObject_BILL_WORK_FLOW obj in objs)
                        {
                           SystemLogic.Proxy.AuditAdd(obj);
                        }
                        int amount = 0;
						
			//平台自动生成代码
					foreach (EntityObject_BILL_WORK_FLOW obj in objs)
					{
						amount += HelperObject_BILL_WORK_FLOW.Save(obj, transaction);
						SystemLogic.Proxy.LogDataInstance(obj, transaction);
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
        public BizLogicMsg BatchUpdate(EntityObject_BILL_WORK_FLOW[] objs)
        {

            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                   
                    try
                    {
                        foreach(EntityObject_BILL_WORK_FLOW obj in objs)
                        {
                           SystemLogic.Proxy.AuditEdit(obj);
                        }
                        int amount = 0;                        
						
			//平台自动生成代码
					foreach (EntityObject_BILL_WORK_FLOW obj in objs)
					{
						amount += HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
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
        public BizLogicMsg BatchDelete(EntityObject_BILL_WORK_FLOW[] objs)
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
					foreach (EntityObject_BILL_WORK_FLOW obj in objs)
					{
						amount += HelperObject_BILL_WORK_FLOW.Delete(obj, transaction);
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
        public BizLogicMsg Audit(EntityObject_BILL_WORK_FLOW obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAudit(obj);
						int amount = HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
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
        public BizLogicMsg UndoAudit(EntityObject_BILL_WORK_FLOW obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                     
                        SystemLogic.Proxy.AuditUndoAudit(obj);
						int amount = HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
					//平台自动生成代码
						PostUndoAudit(obj, transaction);
                        //执行撤回操作
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
        public BizLogicMsg Submit(EntityObject_BILL_WORK_FLOW obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditSubmit(obj);
						int amount = HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
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
        public BizLogicMsg UndoSubmit(EntityObject_BILL_WORK_FLOW obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        SystemLogic.Proxy.AuditUndoSubmit(obj);
						int amount = HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
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
        public int SaveByTrans(EntityObject_BILL_WORK_FLOW obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditAdd(obj);
            int amount = HelperObject_BILL_WORK_FLOW.Save(obj, transaction);
					//平台自动生成代码             
            
            return amount;
        }
        public int UpdateByTrans(EntityObject_BILL_WORK_FLOW obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditEdit(obj);
            return HelperObject_BILL_WORK_FLOW.Update(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans(EntityObject_BILL_WORK_FLOW obj, IDbTransaction transaction)
        {
            return HelperObject_BILL_WORK_FLOW.Delete(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans2(CauseObject_BILL_WORK_FLOW cause, IDbTransaction transaction)
        {
            return HelperObject_BILL_WORK_FLOW.Delete(cause, transaction);
					//平台自动生成代码
        }
		#endregion 
	}
}
