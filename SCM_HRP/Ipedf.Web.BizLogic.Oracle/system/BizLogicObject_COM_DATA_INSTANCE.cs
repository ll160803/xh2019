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
	[CauseObject(typeof(CauseObject_COM_DATA_INSTANCE))]
    public partial class BizLogicObject_COM_DATA_INSTANCE : BizLogicBase<EntityObject_COM_DATA_INSTANCE>
	{	
		#region Proxy 
		private BizLogicObject_COM_DATA_INSTANCE() { }
        private static BizLogicObject_COM_DATA_INSTANCE singleton;
        public static BizLogicObject_COM_DATA_INSTANCE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_COM_DATA_INSTANCE();
                return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_COM_DATA_INSTANCE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAdd(obj);
                        int amount = HelperObject_COM_DATA_INSTANCE.Save(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_COM_DATA_INSTANCE obj)
		{
			
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
                        int amount = HelperObject_COM_DATA_INSTANCE.Update(obj, transaction);
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
		public BizLogicMsg Delete(EntityObject_COM_DATA_INSTANCE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
					try
                    {
						int amount = HelperObject_COM_DATA_INSTANCE.Delete(obj, transaction);
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
		public EntityObject_COM_DATA_INSTANCE Get(EntityObject_COM_DATA_INSTANCE obj)
		{
			
			//平台自动生成代码
			return HelperObject_COM_DATA_INSTANCE.Get(obj);
		}
		public DisplayObject_COM_DATA_INSTANCE[] List()
		{
			
			//平台自动生成代码
			return HelperObject_COM_DATA_INSTANCE.List();
		}		
		public DisplayObject_COM_DATA_INSTANCE[] Query(CauseObject_COM_DATA_INSTANCE cause)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_COM_DATA_INSTANCE.Query(cause);
		}
		public BizLogicMsg Delete(CauseObject_COM_DATA_INSTANCE cause)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        int amount = HelperObject_COM_DATA_INSTANCE.Delete(cause, transaction);
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
		public DisplayObject_COM_DATA_INSTANCE[] Query(CauseObject_COM_DATA_INSTANCE cause,PagingParamter paging,OrderByParameter order)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_COM_DATA_INSTANCE.Query(cause, paging, order);
		}	
		public BizLogicMsg BatchSave(EntityObject_COM_DATA_INSTANCE[] objs)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        foreach(EntityObject_COM_DATA_INSTANCE obj in objs)
                        {
                           SystemLogic.Proxy.AuditAdd(obj);
                        }
                        int amount = 0;
						
			//平台自动生成代码
					foreach (EntityObject_COM_DATA_INSTANCE obj in objs)
					{
						amount += HelperObject_COM_DATA_INSTANCE.Save(obj, transaction);
						
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
        public BizLogicMsg BatchUpdate(EntityObject_COM_DATA_INSTANCE[] objs)
        {

            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                   
                    try
                    {
                        foreach(EntityObject_COM_DATA_INSTANCE obj in objs)
                        {
                           SystemLogic.Proxy.AuditEdit(obj);
                        }
                        int amount = 0;                        
						
			//平台自动生成代码
					foreach (EntityObject_COM_DATA_INSTANCE obj in objs)
					{
						amount += HelperObject_COM_DATA_INSTANCE.Update(obj, transaction);
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
        public BizLogicMsg BatchDelete(EntityObject_COM_DATA_INSTANCE[] objs)
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
					foreach (EntityObject_COM_DATA_INSTANCE obj in objs)
					{
						amount += HelperObject_COM_DATA_INSTANCE.Delete(obj, transaction);
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
        public BizLogicMsg Audit(EntityObject_COM_DATA_INSTANCE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAudit(obj);
						int amount = HelperObject_COM_DATA_INSTANCE.Update(obj, transaction);
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
        public BizLogicMsg UndoAudit(EntityObject_COM_DATA_INSTANCE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
						int amount = HelperObject_COM_DATA_INSTANCE.Update(obj, transaction);
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
        public int SaveByTrans(EntityObject_COM_DATA_INSTANCE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditAdd(obj);
            int amount = HelperObject_COM_DATA_INSTANCE.Save(obj, transaction);
					//平台自动生成代码             
            
            return amount;
        }
        public int UpdateByTrans(EntityObject_COM_DATA_INSTANCE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditEdit(obj);
            return HelperObject_COM_DATA_INSTANCE.Update(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans(EntityObject_COM_DATA_INSTANCE obj, IDbTransaction transaction)
        {
            return HelperObject_COM_DATA_INSTANCE.Delete(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans2(CauseObject_COM_DATA_INSTANCE cause, IDbTransaction transaction)
        {
            return HelperObject_COM_DATA_INSTANCE.Delete(cause, transaction);
					//平台自动生成代码
        }
		#endregion 
	}
}
