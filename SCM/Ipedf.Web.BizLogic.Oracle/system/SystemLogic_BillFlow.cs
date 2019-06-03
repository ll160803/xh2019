using System;
using System.Collections.Generic;
using System.Text;
using Ipedf.Web.Entity;using Ipedf.Web.DataAccess;
using System.Data;
using Ipedf.Core;
using System.Text.RegularExpressions;
using ConstLibrary = Ipedf.Common;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{

    public partial class SystemLogic
    {
        ///// <summary>
        ///// 创建订单流
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="entity"></param>
        ///// <param name="nextEntity"></param>
        ///// <param name="msg"></param>
        ///// <param name="transaction"></param>
        //public void CreateRequestBillWorkflow<T>(EntityObject_BILL_REQUEST entity, T nextEntity, string msg, IDbTransaction transaction)
        //{
        //    CreateBillWorkflow<EntityObject_BILL_REQUEST, T>(entity, nextEntity, msg, transaction);
        //}
        /// <summary>
        /// 创建单据流
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="entity"></param>
        /// <param name="nextEntity"></param>
        /// <param name="msg"></param>
        /// <param name="transaction"></param>
        public void CreateBillWorkflow<T1, T2>(T1 entity, T2 nextEntity, string msg, IDbTransaction transaction)
        {
            EntityObject_BILL_WORK_FLOW wf = new EntityObject_BILL_WORK_FLOW();
            wf.BILL_CODE = entity.GetType().GetProperty("CODE") == null ? null : entity.GetType().GetProperty("CODE").GetValue(entity, null) == null ? string.Empty : entity.GetType().GetProperty("CODE").GetValue(entity, null).ToString();
            wf.BILL_ID = entity.GetType().GetProperty("ID") == null ? null : entity.GetType().GetProperty("ID").GetValue(entity, null) == null ? string.Empty : entity.GetType().GetProperty("ID").GetValue(entity, null).ToString();
            wf.BILL_MSG = msg;
            wf.BILL_NAME = entity.GetType().Name;
            wf.BILL_OPT_COUNTER += 1;
            wf.BILL_STATE = entity.GetType().GetProperty("STATE") == null ? 0 : entity.GetType().GetProperty("STATE").GetValue(entity, null) == null ? 0 : decimal.Parse(entity.GetType().GetProperty("STATE").GetValue(entity, null).ToString());
            wf.BILL_TYPE = entity is EntityObject_BILL_REQUEST ? entity.GetType().GetProperty("REQUEST_BILL_TYPE_ID") == null ? null : entity.GetType().GetProperty("REQUEST_BILL_TYPE_ID").GetValue(entity,null).ToString() : nextEntity.GetType().Name;//如果是物流订单,则输出REQUEST_BILL_TYPE_ID,否则输出对象类型
            //wf.BILL_TYPE = nextEntity.GetType().Name;
            wf.COMMENTS = "";
            wf.CREATE_DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            wf.CREATE_TIME = System.DateTime.Now;
            wf.CREATE_USER_ID = SystemLogic.Proxy.CurrentUser.ID;
            wf.DATA_ORGANISE_ID = SystemLogic.Proxy.CurrentUser.DATA_ORGANISE_ID;
            object code = nextEntity.GetType().GetProperty("CODE") == null ? null : nextEntity.GetType().GetProperty("CODE").GetValue(nextEntity, null);
            wf.NEXT_BILL_CODE = code == null ? string.Empty : code.ToString();
            object id = nextEntity.GetType().GetProperty("ID").GetValue(nextEntity, null);
            wf.NEXT_BILL_ID = id == null ? string.Empty : id.ToString();
            wf.NEXT_BILL_NAME = nextEntity.GetType().Name;
            HelperObject_BILL_WORK_FLOW.Save(wf, transaction);
        }

        /// <summary>
        /// 失败时,Msg存放消息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public BizLogicMsg BillUndoAudit(object entity, IDbTransaction transaction)
        {
            string msg = string.Empty;
            string billId = entity.GetType().GetProperty("ID") == null ? string.Empty : entity.GetType().GetProperty("ID").GetValue(entity, null) == null ? string.Empty : entity.GetType().GetProperty("ID").GetValue(entity, null).ToString();
            string billName = entity.GetType().Name;
            int succeed = HelperObject_BILL_WORK_FLOW.BillUndoAudit(billId, billName, transaction, out msg);
            if (succeed == 0)
            {
                return new BizLogicMsg(false, msg);
            }
            else
            {
                return new BizLogicMsg();
            }
        }
    }
}
