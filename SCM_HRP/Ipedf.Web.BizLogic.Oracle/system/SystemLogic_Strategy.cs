using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
using System.Reflection;
namespace Ipedf.Web.BizLogic
{
    /// <summary>
    /// 查询审计策略
    /// </summary>
    public abstract class QuerayAditStrategy
    {
        public QuerayAditStrategy()
        {
            excludes = new List<ExcludeQuerayStrategy>();
        }
        protected abstract void Execute(object cause);
        protected abstract void Execute(string table,ref string conditon);
        private List<ExcludeQuerayStrategy> excludes;
        protected string customCondition;
        public void SetCustomCondition(string customCondition)
        {
            this.customCondition = string.IsNullOrEmpty(customCondition) ? string.Empty:customCondition.Replace("$USER", SystemLogic.Proxy.CurrentUser.ID);
        }
        public void Apply(object cause)
        {
            if (!Exclude(cause))
            {
                Execute(cause);//执行查询策略
                if (!string.IsNullOrEmpty(this.customCondition))//2014-09-28:注入自定义条件
                {
                    System.Reflection.MethodInfo mi = cause.GetType().GetMethod("SetCustomCondition");
                    if (mi != null)
                    {
                        mi.Invoke(cause, new object[] { this.customCondition });
                    }
                }
            }
        }
        public void Apply(string table,ref string condition)
        {
            if (!Exclude(table))
            {
                Execute(table,ref condition);//执行查询策略
                if (!string.IsNullOrEmpty(this.customCondition))//2014-09-28:注入自定义条件
                {
                    condition += this.customCondition;
                }
            }
        }
        public void SetExclude(params ExcludeQuerayStrategy[] excludes)
        {
            this.excludes.Clear();
            this.excludes.AddRange(excludes);
        }
        private bool Exclude(object cause)
        {            
            foreach (ExcludeQuerayStrategy exclude in this.excludes)
            {
                if (exclude.Apply(cause))
                    return true;
            }
            return false;
        }
        private bool Exclude(string table)
        {
            foreach (ExcludeQuerayStrategy exclude in this.excludes)
            {
                if (exclude.Apply(table))
                    return true;
            }
            return false;
        }
        protected PropertyInfo FindProperty(object instance,string property)
        {
            System.Reflection.PropertyInfo p1 = instance.GetType().GetProperty(property);
            if (p1 == null)
            {               
                foreach (PropertyInfo p in instance.GetType().GetProperties())
                {                    
                    PropertyAliasAttribute[] aliases = (PropertyAliasAttribute[])p.GetCustomAttributes(typeof(PropertyAliasAttribute),false);
                    foreach (PropertyAliasAttribute alias in aliases)
                    {
                        if (alias.Name == property)
                        {
                            return p;
                        }
                    }
                }
            }
            return p1;
        }        
    }
    /// <summary>
    /// 组织限制查询审计策略
    /// </summary>
    public class OrganiseLimitQuerayAditStrategy : QuerayAditStrategy
    {
        protected override void Execute(object cause)
        {
            //System.Reflection.PropertyInfo p1 = cause.GetType().GetProperty("DATA_ORGANISE_ID");
            System.Reflection.PropertyInfo p1 = FindProperty(cause,"DATA_ORGANISE_ID");
            if (p1 != null)
            {
                string organiseId = SystemLogic.Proxy.SearchOrganiseByDepart(SystemLogic.Proxy.CurrentUser.DEPART_ID);
                p1.SetValue(cause, organiseId, null);
            }
        }
        protected override void Execute(string table, ref string conditon)
        {
            string organiseId = SystemLogic.Proxy.SearchOrganiseByDepart(SystemLogic.Proxy.CurrentUser.DEPART_ID);
            conditon += string.Format(" and {0}.{1} = '{2}'",table,"DATA_ORGANISE_ID",organiseId);
        }
    }
    /// <summary>
    /// 创建者查询审计策略
    /// </summary>
    public class CreateUserQuerayAditStrategy : QuerayAditStrategy
    {
        protected override void Execute(object cause)
        {
            System.Reflection.PropertyInfo p1 = FindProperty(cause,"CREATE_USER_ID");
            if (p1 != null)
            {
                string userId = SystemLogic.Proxy.CurrentUser.ID;
                p1.SetValue(cause, userId, null);
            }
        }
        protected override void Execute(string table, ref string conditon)
        {
            string userId = SystemLogic.Proxy.CurrentUser.ID;
            conditon += string.Format(" and {0}.{1} = '{2}'", table, "CREATE_USER_ID", userId);
        }
    }

    /// <summary>
    /// 部门查询审计策略
    /// </summary>
    public class CreateDepartQuerayAditStrategy : QuerayAditStrategy
    {
        protected override void Execute(object cause)
        {
            //向下兼容
            System.Reflection.PropertyInfo p1 = FindProperty(cause, "CREATE_DEPT_ID");
            if (p1 != null)
            {
                string departId = SystemLogic.Proxy.CurrentUser.DEPART_ID;
                p1.SetValue(cause, departId, null);
            }
            p1 = FindProperty(cause, "CREATE_DEPART_ID");
            if (p1 != null)
            {
                string departId = SystemLogic.Proxy.CurrentUser.DEPART_ID;
                p1.SetValue(cause, departId, null);
            }
        }
        protected override void Execute(string table, ref string conditon)
        {
            string departId = SystemLogic.Proxy.CurrentUser.DEPART_ID;
            conditon += string.Format(" and {0}.{1} = '{2}'", table, "CREATE_DEPART_ID", departId);
        }
    }
    /// <summary>
    /// 自定义查询审计策略,该策略本身不包含任何操作,重点在于CustomCondition应用,该应用在父类(QuerayAditStrategy)中处理
    /// </summary>
    public class CustomQuerayAditStrategy : QuerayAditStrategy
    {
        protected override void Execute(object cause)
        {}
        protected override void Execute(string table, ref string conditon)
        {}
    }
    /// <summary>
    /// 查询排除策略
    /// </summary>
    public abstract class ExcludeQuerayStrategy
    {
        public abstract bool Apply(object cause);
        public abstract bool Apply(string table);
    }
    /// <summary>
    /// 系统类型查询排除策略
    /// </summary>
    public class ComTypeExcludeQuerayStrategy : ExcludeQuerayStrategy
    {
        public override bool Apply(object cause)
        {
            string dataObject = SystemLogic.Proxy.SearchDataObjectByCauseObject(cause);
            return dataObject.ToUpper() == "COM_TYPE";
        }
        public override bool Apply(string table)
        {
            return table.ToUpper() == "COM_TYPE";
        }
    }
    /// <summary>
    /// 系统参数查询排除策略
    /// </summary>
    public class ComParameterExcludeQuerayStrategy : ExcludeQuerayStrategy
    {
        public override bool Apply(object cause)
        {
            string dataObject = SystemLogic.Proxy.SearchDataObjectByCauseObject(cause);
            return dataObject.ToUpper() == "COM_PARAMETER";
        }
        public override bool Apply(string table)
        {
            return table.ToUpper() == "COM_PARAMETER";
        }
    }
    /// <summary>
    /// 业务类型查询排除策略
    /// </summary>
    public class BizTypeExcludeQuerayStrategy : ExcludeQuerayStrategy
    {
        public override bool Apply(object cause)
        {
            string dataObject = SystemLogic.Proxy.SearchDataObjectByCauseObject(cause);
            return dataObject.ToUpper() == "BIZ_TYPE";
        }
        public override bool Apply(string table)
        {
            return table.ToUpper() == "BIZ_TYPE";
        }
    }
    /// <summary>
    /// 业务参数查询排除策略
    /// </summary>
    public class BizParameterExcludeQuerayStrategy : ExcludeQuerayStrategy
    {
        public override bool Apply(object cause)
        {
            string dataObject = SystemLogic.Proxy.SearchDataObjectByCauseObject(cause);
            return dataObject.ToUpper() == "BIZ_PARAMETER";
        }
        public override bool Apply(string table)
        {
            return table.ToUpper() == "BIZ_PARAMETER";
        }
    }
}
