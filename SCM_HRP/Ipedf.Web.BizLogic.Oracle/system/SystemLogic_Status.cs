using System;
using System.Collections.Generic;
using System.Text;
using Ipedf.Web.Entity;using Ipedf.Web.DataAccess;
using ConstLibrary = Ipedf.Common;
using Ipedf.Core;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {        
        public object GetStatus(object entity)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                return p5.GetValue(entity, null);
            }
            return null;
        }
        public void SetStatus(object entity, object state)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, state, null);
            }
        }
        public void SetAuditStatus(object entity)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (int)数据状态.已审核, null);
            }
        }
        public void SetArchiveStatus(object entity)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (int)数据状态.已归档, null);
            }
        }
        public bool IsAuditStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)数据状态.已审核;
            }
            return false;
        }
        public bool IsArchiveStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)数据状态.已归档;
            }
            return false;
        }
        public bool IsSubmitStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)数据状态.已提交;
            }
            return false;
        }
        public bool IsEditStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)数据状态.编辑中 || Convert.ToInt32(state) == (int)数据状态.默认值;
            }
            return true;
        }
        public bool IsCancelStatus(object entity)
        {
            object state = GetStatus(entity);
            if (state != null)
            {
                return Convert.ToInt32(state) == (int)数据状态.已作废;
            }
            return false;
        }
    }
}
