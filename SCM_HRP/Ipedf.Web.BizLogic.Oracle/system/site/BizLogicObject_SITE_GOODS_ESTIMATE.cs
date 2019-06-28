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
	[CauseObject(typeof(CauseObject_SITE_GOODS_ESTIMATE))]
	public partial class BizLogicObject_SITE_GOODS_ESTIMATE: BizLogicBase<EntityObject_SITE_GOODS_ESTIMATE>
	{	
		#region Proxy 
		private BizLogicObject_SITE_GOODS_ESTIMATE() { }
        private static BizLogicObject_SITE_GOODS_ESTIMATE singleton;
        public static BizLogicObject_SITE_GOODS_ESTIMATE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_SITE_GOODS_ESTIMATE();
                return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_SITE_GOODS_ESTIMATE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAdd(obj);
                        int amount = HelperObject_SITE_GOODS_ESTIMATE.Save(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_SITE_GOODS_ESTIMATE obj)
		{
			
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
                        int amount = HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
		public BizLogicMsg Delete(EntityObject_SITE_GOODS_ESTIMATE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
					try
                    {
						int amount = HelperObject_SITE_GOODS_ESTIMATE.Delete(obj, transaction);
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
		public EntityObject_SITE_GOODS_ESTIMATE Get(EntityObject_SITE_GOODS_ESTIMATE obj)
		{
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS_ESTIMATE.Get(obj);
		}
		public DisplayObject_SITE_GOODS_ESTIMATE[] List()
		{
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS_ESTIMATE.List();
		}		
		public DisplayObject_SITE_GOODS_ESTIMATE[] Query(CauseObject_SITE_GOODS_ESTIMATE cause)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS_ESTIMATE.Query(cause);
		}
		public BizLogicMsg Delete(CauseObject_SITE_GOODS_ESTIMATE cause)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        int amount = HelperObject_SITE_GOODS_ESTIMATE.Delete(cause, transaction);
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
		public DisplayObject_SITE_GOODS_ESTIMATE[] Query(CauseObject_SITE_GOODS_ESTIMATE cause,PagingParamter paging,OrderByParameter order)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS_ESTIMATE.Query(cause, paging, order);
		}	
		public BizLogicMsg BatchSave(EntityObject_SITE_GOODS_ESTIMATE[] objs)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        foreach(EntityObject_SITE_GOODS_ESTIMATE obj in objs)
                        {
                           SystemLogic.Proxy.AuditAdd(obj);
                        }
                        int amount = 0;
						
			//平台自动生成代码
					foreach (EntityObject_SITE_GOODS_ESTIMATE obj in objs)
					{
						amount += HelperObject_SITE_GOODS_ESTIMATE.Save(obj, transaction);
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
        public BizLogicMsg BatchUpdate(EntityObject_SITE_GOODS_ESTIMATE[] objs)
        {

            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                   
                    try
                    {
                        foreach(EntityObject_SITE_GOODS_ESTIMATE obj in objs)
                        {
                           SystemLogic.Proxy.AuditEdit(obj);
                        }
                        int amount = 0;                        
						
			//平台自动生成代码
					foreach (EntityObject_SITE_GOODS_ESTIMATE obj in objs)
					{
						amount += HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
        public BizLogicMsg BatchDelete(EntityObject_SITE_GOODS_ESTIMATE[] objs)
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
					foreach (EntityObject_SITE_GOODS_ESTIMATE obj in objs)
					{
						amount += HelperObject_SITE_GOODS_ESTIMATE.Delete(obj, transaction);
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
        public BizLogicMsg Cancel(EntityObject_SITE_GOODS_ESTIMATE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SystemLogic.Proxy.AuditCancel(obj);
                        int amount = HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
        public BizLogicMsg Audit(EntityObject_SITE_GOODS_ESTIMATE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAudit(obj);
						int amount = HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
        public BizLogicMsg UndoAudit(EntityObject_SITE_GOODS_ESTIMATE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        
                        SystemLogic.Proxy.AuditUndoAudit(obj);
						int amount = HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
        public BizLogicMsg Submit(EntityObject_SITE_GOODS_ESTIMATE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditSubmit(obj);
						int amount = HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
        public BizLogicMsg UndoSubmit(EntityObject_SITE_GOODS_ESTIMATE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        SystemLogic.Proxy.AuditUndoSubmit(obj);
						int amount = HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
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
        
        public int SaveByTrans(EntityObject_SITE_GOODS_ESTIMATE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditAdd(obj);
            int amount = HelperObject_SITE_GOODS_ESTIMATE.Save(obj, transaction);
					//平台自动生成代码             
            
            return amount;
        }
        public int UpdateByTrans(EntityObject_SITE_GOODS_ESTIMATE obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditEdit(obj);
            return HelperObject_SITE_GOODS_ESTIMATE.Update(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans(EntityObject_SITE_GOODS_ESTIMATE obj, IDbTransaction transaction)
        {
            return HelperObject_SITE_GOODS_ESTIMATE.Delete(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans2(CauseObject_SITE_GOODS_ESTIMATE cause, IDbTransaction transaction)
        {
            return HelperObject_SITE_GOODS_ESTIMATE.Delete(cause, transaction);
					//平台自动生成代码
        }
        public EntityObject_SITE_GOODS_ESTIMATE Load(string id , out EntityObject_SITE_GOODS goods_id, out EntityObject_SITE_USER user_id)
		{

			EntityObject_SITE_GOODS_ESTIMATE obj = new EntityObject_SITE_GOODS_ESTIMATE();
            
			//平台自动生成代码
			goods_id = new EntityObject_SITE_GOODS() ; 
			user_id = new EntityObject_SITE_USER() ; 
     
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        
						obj.ID= id;
						obj = HelperObject_SITE_GOODS_ESTIMATE.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.GOODS_ID))
						{
							goods_id.ID = obj.GOODS_ID;
							goods_id = HelperObject_SITE_GOODS.Get(goods_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USER_ID))
						{
							user_id.ID = obj.USER_ID;
							user_id = HelperObject_SITE_USER.Get(user_id, transaction);
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
