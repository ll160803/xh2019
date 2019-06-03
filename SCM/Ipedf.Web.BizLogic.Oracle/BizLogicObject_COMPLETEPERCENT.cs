using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.Core;
using Ipedf.Web.DataAccess;
using Ipedf.Wcf.ClientProxy;
using System.Data;

namespace Ipedf.Web.BizLogic
{
    [CauseObject(typeof(CauseObject_COMPLETEPERCENT))]
	public partial class BizLogicObject_COMPLETEPERCENT: BizLogicBase<EntityObject_COMPLETEPERCENT>,ServiceContract_COMPLETEPERCENT
    {
        #region Proxy 
        public BizLogicObject_COMPLETEPERCENT() { }
        private static ServiceContract_COMPLETEPERCENT singleton;
        public static ServiceContract_COMPLETEPERCENT Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_COMPLETEPERCENT();
                    return singleton;
            }
        }
        #endregion	
        public EntityObject_COMPLETEPERCENT[] List(DateTime dtBegin, DateTime dtEnd, string gysAccount,string gysName)
        {
            if (LocalMode)
            {

                //平台自动生成代码
                return HelperObject_COMPLETEPERCENT.List(dtBegin,dtEnd,gysAccount,gysName);
            }
            else
            {
                using (ServiceManager<ServiceContract_COMPLETEPERCENT> smgr = new ServiceManager<ServiceContract_COMPLETEPERCENT>(ServiceUri))
                {
                    return smgr.Service.List(dtBegin, dtEnd, gysAccount,gysName);
                }
            }
        }
       public  EntityObject_COMPLETEPERCENT[] MaterList(string dtBegin, string dtEnd, string gysAccount, string gysName, string matnr, string txz01,string WERKST, string order, string sort,out int totalRecord, int page = 1, int pageSize = 10)
        {
            if (LocalMode)
            {

                //平台自动生成代码
                return HelperObject_COMPLETEPERCENT.MaterList(dtBegin, dtEnd, gysAccount, gysName, matnr, txz01, WERKST,order, sort, out totalRecord, page, pageSize);
            }
            else
            {
                using (ServiceManager<ServiceContract_COMPLETEPERCENT> smgr = new ServiceManager<ServiceContract_COMPLETEPERCENT>(ServiceUri))
                {
                    return smgr.Service.MaterList(dtBegin, dtEnd, gysAccount, gysName, matnr, txz01, WERKST,order, sort, out totalRecord, page, pageSize);
                }
            }
        }
        #region IServiceContractLocal<EntityObject_COMPLETEPERCENT,CauseObject_COMPLETEPERCENT> 成员

        int IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.DeleteByTrans(EntityObject_COMPLETEPERCENT obj, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        int IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.DeleteByTrans2(CauseObject_COMPLETEPERCENT cause, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        void IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.PostArchive(EntityObject_COMPLETEPERCENT entity, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        void IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.PostAudit(EntityObject_COMPLETEPERCENT entity, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        void IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.PostSave(EntityObject_COMPLETEPERCENT entity, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        void IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.PostSubmit(EntityObject_COMPLETEPERCENT entity, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        void IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.PostUndoAudit(EntityObject_COMPLETEPERCENT entity, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        void IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.PostUndoSubmit(EntityObject_COMPLETEPERCENT entity, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        int IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.SaveByTrans(EntityObject_COMPLETEPERCENT obj, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        int IServiceContractLocal<EntityObject_COMPLETEPERCENT, CauseObject_COMPLETEPERCENT>.UpdateByTrans(EntityObject_COMPLETEPERCENT obj, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
