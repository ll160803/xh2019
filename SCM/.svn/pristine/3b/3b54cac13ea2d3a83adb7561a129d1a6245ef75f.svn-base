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
	[CauseObject(typeof(CauseObject_SITE_GOODS))]
	public partial class BizLogicObject_SITE_GOODS: BizLogicBase<EntityObject_SITE_GOODS>
	{	
		#region Proxy 
		private BizLogicObject_SITE_GOODS() { }
        private static BizLogicObject_SITE_GOODS singleton;
        public static BizLogicObject_SITE_GOODS Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_SITE_GOODS();
                return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_SITE_GOODS obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAdd(obj);
                        int amount = HelperObject_SITE_GOODS.Save(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_SITE_GOODS obj)
		{
			
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
                    try
                    {
                        SystemLogic.Proxy.AuditEdit(obj);
                        int amount = HelperObject_SITE_GOODS.Update(obj, transaction);
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
		public BizLogicMsg Delete(EntityObject_SITE_GOODS obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                { 
					try
                    {
						int amount = HelperObject_SITE_GOODS.Delete(obj, transaction);
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
		public EntityObject_SITE_GOODS Get(EntityObject_SITE_GOODS obj)
		{
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS.Get(obj);
		}
		public DisplayObject_SITE_GOODS[] List()
		{
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS.List();
		}		
		public DisplayObject_SITE_GOODS[] Query(CauseObject_SITE_GOODS cause)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS.Query(cause);
		}
		public BizLogicMsg Delete(CauseObject_SITE_GOODS cause)
		{
			BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    
                    try
                    {
                        int amount = HelperObject_SITE_GOODS.Delete(cause, transaction);
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
		public DisplayObject_SITE_GOODS[] Query(CauseObject_SITE_GOODS cause,PagingParamter paging,OrderByParameter order)
		{
			SystemLogic.Proxy.AuditQuery(cause);
			
			//平台自动生成代码
			return HelperObject_SITE_GOODS.Query(cause, paging, order);
		}	
		public BizLogicMsg BatchSave(EntityObject_SITE_GOODS[] objs)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        foreach(EntityObject_SITE_GOODS obj in objs)
                        {
                           SystemLogic.Proxy.AuditAdd(obj);
                        }
                        int amount = 0;
						
			//平台自动生成代码
					foreach (EntityObject_SITE_GOODS obj in objs)
					{
						amount += HelperObject_SITE_GOODS.Save(obj, transaction);
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
        public BizLogicMsg BatchUpdate(EntityObject_SITE_GOODS[] objs)
        {

            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                   
                    try
                    {
                        foreach(EntityObject_SITE_GOODS obj in objs)
                        {
                           SystemLogic.Proxy.AuditEdit(obj);
                        }
                        int amount = 0;                        
						
			//平台自动生成代码
					foreach (EntityObject_SITE_GOODS obj in objs)
					{
						amount += HelperObject_SITE_GOODS.Update(obj, transaction);
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
        public BizLogicMsg BatchDelete(EntityObject_SITE_GOODS[] objs)
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
					foreach (EntityObject_SITE_GOODS obj in objs)
					{
						amount += HelperObject_SITE_GOODS.Delete(obj, transaction);
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
        public BizLogicMsg Cancel(EntityObject_SITE_GOODS obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SystemLogic.Proxy.AuditCancel(obj);
                        int amount = HelperObject_SITE_GOODS.Update(obj, transaction);
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
        public BizLogicMsg Audit(EntityObject_SITE_GOODS obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditAudit(obj);
						int amount = HelperObject_SITE_GOODS.Update(obj, transaction);
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
        public BizLogicMsg UndoAudit(EntityObject_SITE_GOODS obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        
                        SystemLogic.Proxy.AuditUndoAudit(obj);
						int amount = HelperObject_SITE_GOODS.Update(obj, transaction);
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
        public BizLogicMsg Submit(EntityObject_SITE_GOODS obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    
                    try
                    {
                        SystemLogic.Proxy.AuditSubmit(obj);
						int amount = HelperObject_SITE_GOODS.Update(obj, transaction);
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
        public BizLogicMsg UndoSubmit(EntityObject_SITE_GOODS obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {                    
                    try
                    {
                        SystemLogic.Proxy.AuditUndoSubmit(obj);
						int amount = HelperObject_SITE_GOODS.Update(obj, transaction);
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
        
        public int SaveByTrans(EntityObject_SITE_GOODS obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditAdd(obj);
            int amount = HelperObject_SITE_GOODS.Save(obj, transaction);
					//平台自动生成代码             
            
            return amount;
        }
        public int UpdateByTrans(EntityObject_SITE_GOODS obj, IDbTransaction transaction)
        {
            SystemLogic.Proxy.AuditEdit(obj);
            return HelperObject_SITE_GOODS.Update(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans(EntityObject_SITE_GOODS obj, IDbTransaction transaction)
        {
            return HelperObject_SITE_GOODS.Delete(obj, transaction);
					//平台自动生成代码
        }
        public int DeleteByTrans2(CauseObject_SITE_GOODS cause, IDbTransaction transaction)
        {
            return HelperObject_SITE_GOODS.Delete(cause, transaction);
					//平台自动生成代码
        }
        public EntityObject_SITE_GOODS Load(string id , out EntityObject_COM_TYPE goods_state)
		{

			EntityObject_SITE_GOODS obj = new EntityObject_SITE_GOODS();
            
			//平台自动生成代码
			goods_state = new EntityObject_COM_TYPE() ; 
     
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        
						obj.ID= id;
						obj = HelperObject_SITE_GOODS.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.GOODS_STATE))
						{
							goods_state.ID = obj.GOODS_STATE;
							goods_state = HelperObject_COM_TYPE.Get(goods_state, transaction);
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
