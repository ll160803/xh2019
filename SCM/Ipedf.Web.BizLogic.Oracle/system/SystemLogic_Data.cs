using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using Ipedf.Web.Entity;
using System.Reflection;
using Ipedf.Web.DataAccess;

namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
        /// <summary>
        /// 请在Save方法之后调用,确保obj.ID有正确的值,如果没有在COM_DATA表中进行配置(通过NAME匹配),则跳过
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="transaction"></param>
        public void LogDataInstance(object obj, IDbTransaction transaction)
        {
            //Ipedf.Core.DataObjectAttribute[] objRet = (Ipedf.Core.DataObjectAttribute[])obj.GetType().GetCustomAttributes(typeof(Ipedf.Core.DataObjectAttribute), false);
            //CauseObject_COM_DATA pdata = new CauseObject_COM_DATA();
            //pdata.NAME = objRet[0].Name;
            //EntityObject_COM_DATA[] objDatas = HelperObject_COM_DATA.Query(pdata, transaction);
            //if (objDatas.Length != 0)
            //{
            //    EntityObject_COM_DATA_INSTANCE entity = new EntityObject_COM_DATA_INSTANCE();
            //    entity.DATA_ID = objDatas.Length == 0 ? string.Empty : objDatas[0].ID;
            //    entity.DATA_INSTANCE_ID = obj.GetType().GetProperty("ID") == null ? string.Empty : obj.GetType().GetProperty("ID").GetValue(obj, null) == null ? string.Empty : obj.GetType().GetProperty("ID").GetValue(obj, null).ToString();
            //    entity.DATA_INSTANCE_CODE = obj.GetType().GetProperty("CODE") == null ? string.Empty : obj.GetType().GetProperty("CODE").GetValue(obj, null) == null ? string.Empty : obj.GetType().GetProperty("CODE").GetValue(obj, null).ToString();
            //    AuditAdd(entity);
            //    HelperObject_COM_DATA_INSTANCE.Save(entity, transaction);
            //}
        }
        /// <summary>
        /// 请在Save方法之后调用,确保obj.ID,parentObj.ID有正确的值,如果没有在COM_DATA表中进行配置(通过NAME匹配),则跳过
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="parentObj"></param>
        /// <param name="transaction"></param>
        public void LogDataInstance(object obj,object parentObj, IDbTransaction transaction)
        {
            //Ipedf.Core.DataObjectAttribute[] objRet = (Ipedf.Core.DataObjectAttribute[])obj.GetType().GetCustomAttributes(typeof(Ipedf.Core.DataObjectAttribute), false);
            //Ipedf.Core.DataObjectAttribute[] parentObjRet = (Ipedf.Core.DataObjectAttribute[])parentObj.GetType().GetCustomAttributes(typeof(Ipedf.Core.DataObjectAttribute), false);
            //CauseObject_COM_DATA pdata = new CauseObject_COM_DATA();
            //pdata.NAME = objRet[0].Name;
            //EntityObject_COM_DATA[] objDatas = HelperObject_COM_DATA.Query(pdata, transaction);
            //if (objDatas.Length != 0)
            //{
            //    pdata = new CauseObject_COM_DATA();
            //    pdata.NAME = parentObjRet[0].Name;
            //    EntityObject_COM_DATA[] parentObjDatas = HelperObject_COM_DATA.Query(pdata, transaction);
            //    EntityObject_COM_DATA_INSTANCE entity = new EntityObject_COM_DATA_INSTANCE();
            //    entity.DATA_ID = objDatas.Length == 0 ? string.Empty : objDatas[0].ID;
            //    entity.DATA_INSTANCE_ID = obj.GetType().GetProperty("ID") == null ? string.Empty : obj.GetType().GetProperty("ID").GetValue(obj, null) == null ? string.Empty : obj.GetType().GetProperty("ID").GetValue(obj, null).ToString();
            //    entity.DATA_INSTANCE_CODE = obj.GetType().GetProperty("CODE") == null ? string.Empty : obj.GetType().GetProperty("CODE").GetValue(obj, null) == null ? string.Empty : obj.GetType().GetProperty("CODE").GetValue(obj, null).ToString();
            //    entity.PARENT_DATA_ID = parentObjDatas.Length == 0 ? string.Empty : parentObjDatas[0].ID;
            //    entity.PARENT_INSTANCE_ID = parentObj.GetType().GetProperty("ID") == null ? string.Empty : parentObj.GetType().GetProperty("ID").GetValue(parentObj, null) == null ? string.Empty : parentObj.GetType().GetProperty("ID").GetValue(parentObj, null).ToString();
            //    AuditAdd(entity);
            //    HelperObject_COM_DATA_INSTANCE.Save(entity, transaction);
            //}
        }
    }
}
