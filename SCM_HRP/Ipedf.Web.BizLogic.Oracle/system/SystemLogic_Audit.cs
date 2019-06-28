using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
using Ipedf.Web.Entity;
using Ipedf.Common;
using System.Text.RegularExpressions;
using System.Reflection;
//using ExamSys.Common.system;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic 
    {
        public void AuditAdd(object entity)
        {
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("CREATE_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("CREATE_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("CREATE_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("CREATE_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p4 = entity.GetType().GetProperty("DATA_ORGANISE_ID");
            if (p4 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p4.SetValue(entity, SearchOrganiseByDepart(SystemLogic.Proxy.CurrentUser.DEPART_ID), null);                          
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.编辑中, null);
            }
        }
        public void AuditEdit(object entity)
        {
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }

            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);                
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                //2015-6-26:在bizlogic层调用update时,包含需要更新state的场景,在后台AuditEdit后,会导致更新丢失
                //DataObjectAttribute[] ret = (DataObjectAttribute[])entity.GetType().GetCustomAttributes(typeof(DataObjectAttribute), false);
                //if (ret.Length == 0 || ret.Length !=0 && !ret[0].IsDictionary)
                //{
                //    p5.SetValue(entity, (decimal)数据状态.编辑中, null);
                //}               
            }
            System.Reflection.PropertyInfo p6 = entity.GetType().GetProperty("DATA_ORGANISE_ID");
            if (p6 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p6.SetValue(entity, SearchOrganiseByDepart(SystemLogic.Proxy.CurrentUser.DEPART_ID), null);
            }
        }
        public void AuditAudit(object entity)
        {
            List<string> update = new List<string>();
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
                update.Add("MODIFY_TIME");
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                {
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                    update.Add("MODIFY_USER_ID");
                }
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                {
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
                    update.Add("MODIFY_DEPART_ID");
                }
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.已审核, null);
                update.Add("STATE");
            }
            entity.GetType().GetMethod("SetUpdate").Invoke(entity, new object[] { update.ToArray() });
        }
        public void AuditUndoAudit(object entity)
        {
            
            
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);               
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.已提交, null);
            }
            
        }
        public void AuditArchive(object entity)
        {
            List<string> update = new List<string>();
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
                update.Add("MODIFY_TIME");
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                {
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                    update.Add("MODIFY_USER_ID");
                }
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                {
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
                    update.Add("MODIFY_DEPART_ID");
                }
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.已归档, null);
                update.Add("STATE");
            }
            entity.GetType().GetMethod("SetUpdate").Invoke(entity, new object[] { update.ToArray() });
        }
        public void AuditSubmit(object entity)
        {
            List<string> update = new List<string>();
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
                update.Add("MODIFY_TIME");
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                {
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                    update.Add("MODIFY_USER_ID");
                }
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                {
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
                    update.Add("MODIFY_DEPART_ID");
                }
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.已提交, null);
                update.Add("STATE");
            }
            entity.GetType().GetMethod("SetUpdate").Invoke(entity, new object[] { update.ToArray() });
        }
        public void AuditUndoSubmit(object entity)
        {
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.编辑中, null);
            }
        }
        public void AuditCancel(object entity)
        {
            System.Reflection.PropertyInfo p1 = entity.GetType().GetProperty("MODIFY_TIME");
            if (p1 != null)
            {
                p1.SetValue(entity, System.DateTime.Now, null);
            }
            System.Reflection.PropertyInfo p2 = entity.GetType().GetProperty("MODIFY_USER_ID");
            if (p2 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p2.SetValue(entity, SystemLogic.Proxy.CurrentUser.ID, null);
                else
                {
                    EntityBase eb = entity as EntityBase;
                    if (eb != null)
                    {
                        p2.SetValue(entity, eb.ApplicationSessionId, null);
                    }
                }
            }
            System.Reflection.PropertyInfo p3 = entity.GetType().GetProperty("MODIFY_DEPART_ID");
            if (p3 != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p3x = entity.GetType().GetProperty("MODIFY_DEPT_ID");//向下兼容
            if (p3x != null)
            {
                if (SystemLogic.Proxy.CurrentUser != null)
                    p3x.SetValue(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID, null);
            }
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)数据状态.已作废, null);
            }
        }
        public void AuditState(object entity, 数据状态 state)
        {
            System.Reflection.PropertyInfo p5 = entity.GetType().GetProperty("STATE");
            if (p5 != null)
            {
                p5.SetValue(entity, (decimal)state, null);
            }
        }
        public void AuditQuery(object cause)
        {
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                CauseObject_V_COM_QUERY_STRATEGIES p = new CauseObject_V_COM_QUERY_STRATEGIES();
                p.DATAOBJECT = SearchDataObjectByCauseObject(cause);
                p.USER_ID = SystemLogic.Proxy.CurrentUser.ID;
                DisplayObject_V_COM_QUERY_STRATEGIES[] results = HelperObject_V_COM_QUERY_STRATEGIES.Query(p);
                foreach (DisplayObject_V_COM_QUERY_STRATEGIES result in results)
                {
                    QuerayAditStrategy strategy = SearchStrategyByType(result.STRATEGY_TYPE);
                    QueryLimited(result, strategy, cause);
                }
            }           
        }
        public void AuditQuery(string table,ref string condition)
        {
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                CauseObject_V_COM_QUERY_STRATEGIES p = new CauseObject_V_COM_QUERY_STRATEGIES();
                p.DATAOBJECT = table.ToUpper();
                p.USER_ID = SystemLogic.Proxy.CurrentUser.ID;
                DisplayObject_V_COM_QUERY_STRATEGIES[] results = HelperObject_V_COM_QUERY_STRATEGIES.Query(p);
                foreach (DisplayObject_V_COM_QUERY_STRATEGIES result in results)
                {
                    QuerayAditStrategy strategy = SearchStrategyByType(result.STRATEGY_TYPE);
                    QueryLimited(result, strategy, table,ref condition);
                }
            }
        }
        public void AuditReference(object cause)
        {
            //设定排除策略
            List<ExcludeQuerayStrategy> excludes = new List<ExcludeQuerayStrategy>();
            excludes.Add(new ComTypeExcludeQuerayStrategy());
            excludes.Add(new ComParameterExcludeQuerayStrategy());
            excludes.Add(new BizTypeExcludeQuerayStrategy());
            excludes.Add(new BizParameterExcludeQuerayStrategy());
            //执行查询策略
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                CauseObject_V_COM_QUERY_STRATEGIES p = new CauseObject_V_COM_QUERY_STRATEGIES();
                p.DATAOBJECT = SearchDataObjectByCauseObject(cause);
                p.USER_ID = SystemLogic.Proxy.CurrentUser.ID;
                DisplayObject_V_COM_QUERY_STRATEGIES[] results = HelperObject_V_COM_QUERY_STRATEGIES.Query(p);
                foreach (DisplayObject_V_COM_QUERY_STRATEGIES result in results)
                {
                    QuerayAditStrategy strategy = SearchStrategyByType(result.STRATEGY_TYPE);
                    strategy.SetExclude(excludes.ToArray());//注入排除策略
                    QueryLimited(result, strategy, cause);               
                }
            }
            
        }
        protected void QueryLimited(DisplayObject_V_COM_QUERY_STRATEGIES result, QuerayAditStrategy strategy, object cause)
        {
            //匹配限制条件
            if (!string.IsNullOrEmpty(result.DATA_LIMIT))
            {
                //依据条件注入
                string target = result.DATA_LIMIT;
                //获取字段名称
                string pattern = @"(\b\S*\b)(?=\s*=)";
                Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = reg.Match(target);
                string field = m.Value;
                //获取字段值
                pattern = @"(?!\s*\S*\s*=\s*)(?!\')([^\'\s]*)(?=\')";
                reg = new Regex(pattern, RegexOptions.IgnoreCase);
                m = reg.Match(target);
                string value = m.Value;
                //通过反射获取属性值
                string upperField = field.ToUpper();
                PropertyInfo perperty = cause.GetType().GetProperty(upperField);
                if (perperty != null)
                {
                    object pValue = perperty.GetValue(cause, null);
                    if (String.Equals(pValue, value))//仅当条件满足时
                    {
                        strategy.SetCustomCondition(result.STRATEGY_CUSTOMCONDITION);//注入自定义条件
                        strategy.Apply(cause);
                    }
                }
            }
            else
            {
                //无条件注入
                strategy.SetCustomCondition(result.STRATEGY_CUSTOMCONDITION);//注入自定义条件
                strategy.Apply(cause);
            }
        }
        protected void QueryLimited(DisplayObject_V_COM_QUERY_STRATEGIES result, QuerayAditStrategy strategy, string table,ref string condition)
        {
            //无条件注入
            strategy.SetCustomCondition(result.STRATEGY_CUSTOMCONDITION);//注入自定义条件
            strategy.Apply(table,ref condition);
        }
    }

}
