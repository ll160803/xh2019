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
using Ipedf.Web.Entity;
using System.Text.RegularExpressions;
namespace Ipedf.Web.BizLogic
{

    public class Privilege
    {
        private readonly PrivilegeExpression READONLY = new ReadOnlyExpression();
        private readonly PrivilegeExpression ADDABLE = new AddAbleExpression();
        private readonly PrivilegeExpression EDITABLE = new EditAbleExpression();
        private readonly PrivilegeExpression DELETEABLE = new DeleteAbleExpression();
        private readonly PrivilegeExpression AUDITABLE = new AuditAbleExpression();
        private readonly PrivilegeExpression UNDOAUDITABLE = new UndoAuditAbleExpression();
        private readonly PrivilegeExpression SUBMITABLE = new SubmitAbleExpression();
        private readonly PrivilegeExpression UNDOSUBMITABLE = new UndoSubmitAbleExpression();
        private readonly PrivilegeExpression ENABLEABLE = new EnableAbleExpression();
        private readonly PrivilegeExpression DISABLEABLE = new DisableAbleExpression();
        private readonly PrivilegeExpression CANCELABLE = new CancelAbleExpression();
        private readonly PrivilegeExpression ARCHIVEABLE = new ArchiveAbleExpression();
        private readonly PrivilegeExpression WORKFLOWABLE = new WorkflowAbleExpression();
        private readonly PrivilegeExpression PRINTABLE = new PrintAbleExpression();
        private readonly PrivilegeExpression IMPORTABLE = new ImportAbleExpression();
        private readonly PrivilegeExpression EXPORTABLE = new ExportAbleExpression();
        private string description;       
        public Privilege(string description)
        {
            this.description = string.IsNullOrEmpty(description) ? "00000000000000000000" : description.Trim();
        }
        public bool Lawless
        {
            get { return this.description == "00000000000000000000"; }
        }
        public bool ReadOnly
        {
            get { return description[READONLY.Index] == '1'; }
        }
        public bool AddAble
        {
            get { return description[READONLY.Index] == '1' ? false:description[ADDABLE.Index] == '1'; }
        }
        public bool EidtAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[EDITABLE.Index] == '1'; }
        }
        public bool DeleteAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[DELETEABLE.Index] == '1'; }
        }
        public bool SubmitAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[SUBMITABLE.Index] == '1'; }
        }
        public bool UndoSubmitAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[UNDOSUBMITABLE.Index] == '1'; }
        }
        public bool EnableAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[ENABLEABLE.Index] == '1'; }
        }
        public bool DisableAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[DISABLEABLE.Index] == '1'; }
        }
        public bool AuditAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[AUDITABLE.Index] == '1'; }
        }
        public bool UndoAuditAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[UNDOAUDITABLE.Index] == '1'; }
        }
        public bool ArchiveAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[ARCHIVEABLE.Index] == '1'; }
        }
        public bool CancelAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[CANCELABLE.Index] == '1'; }
        }
        public bool WorkflowAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[WORKFLOWABLE.Index] == '1'; }
        }
        public bool PrintAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[PRINTABLE.Index] == '1'; }
        }
        public bool ImportAble
        {
            get { return description[READONLY.Index] == '1' ? false : description[IMPORTABLE.Index] == '1'; }
        }
        public bool ExportAble
        {
            get { return description[EXPORTABLE.Index] == '1'; }
        }
        public abstract class PrivilegeExpression
        {
            protected string expression;
            public abstract string Value { get;}
            protected int index;
            public abstract int Index { get;}
        }
        public class ReadOnlyExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "10000000000000000000"; }
            }

            public override int Index
            {
                get { return 0; }
            }
        }
        public class AddAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "01000000000000000000"; }
            }

            public override int Index
            {
                get { return 1; }
            }
        }
        public class EditAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00100000000000000000"; }
            }

            public override int Index
            {
                get { return 2; }
            }
        }
        public class DeleteAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00010000000000000000"; }
            }

            public override int Index
            {
                get { return 3; }
            }
        }
        public class SubmitAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00001000000000000000"; }
            }

            public override int Index
            {
                get { return 4; }
            }
        }
        public class UndoSubmitAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000100000000000000"; }
            }

            public override int Index
            {
                get { return 5; }
            }
        }
        public class AuditAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000010000000000000"; }
            }

            public override int Index
            {
                get { return 6; }
            }
        }
        public class UndoAuditAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000001000000000000"; }
            }

            public override int Index
            {
                get { return 7; }
            }
        }
        public class EnableAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000100000000000"; }
            }

            public override int Index
            {
                get { return 8; }
            }
        }
        public class DisableAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000100000000000"; }
            }

            public override int Index
            {
                get { return 9; }
            }
        }
        public class CancelAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000010000000000"; }
            }

            public override int Index
            {
                get { return 10; }
            }
        }
        public class ArchiveAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000001000000000"; }
            }

            public override int Index
            {
                get { return 11; }
            }
        }
        public class WorkflowAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000000100000000"; }
            }

            public override int Index
            {
                get { return 12; }
            }
        }
        public class PrintAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000000010000000"; }
            }

            public override int Index
            {
                get { return 13; }
            }
        }
        public class ImportAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000000001000000"; }
            }

            public override int Index
            {
                get { return 14; }
            }
        }
        public class ExportAbleExpression : PrivilegeExpression
        {
            public override string Value
            {
                get { return "00000000000000100000"; }
            }

            public override int Index
            {
                get { return 15; }
            }
        }

    }
    
    public partial class SystemLogic
    {
        
        static Hashtable privilegeCache = Hashtable.Synchronized(new Hashtable());
        /// <summary>
        /// 清空权限缓存,当权限数据发生变更时请调用此方法以更新缓存
        /// </summary>
        public  void ResetPrivilegeCache()
        {
            privilegeCache.Clear();
        }
        private  string PreparePrivilegeCacheKey(DisplayObject_COM_USER user, Page page)
        {
            return string.Concat(user.ACCOUNT, ":", Ipedf.Core.UrlHelper.PrepareName(page)).ToUpper();
        }
        private  void SetPrivilegeCache(DisplayObject_COM_USER user, Page page, Privilege privilege)
        {
            privilegeCache[PreparePrivilegeCacheKey(user, page)] = privilege;
        }
        private  Privilege GetPrivilegeCache(DisplayObject_COM_USER user, Page page)
        {
            return (Privilege)privilegeCache[PreparePrivilegeCacheKey(user, page)];
        }
       
        private  string PrepareControlCode(DisplayObject_V_COM_QUERY_CONTROLCODE[] controlCodes)
        {
            string[] ret = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            foreach (DisplayObject_V_COM_QUERY_CONTROLCODE controlCode in controlCodes)
            {
                string code = controlCode.CONTROL_CODE.Trim();
                for (int i = 0; i < code.Length; i++ )
                {
                    ret[i] = code[i] == '1' ? "1" : ret[i];
                }
            }
            return string.Join(string.Empty, ret);
        }
        private  Privilege GetPrivilege(DisplayObject_COM_USER user, Page page)
        {
            Privilege privilege = GetPrivilegeCache(user, page);
            if (privilege == null)
            {
                CauseObject_V_COM_QUERY_CONTROLCODE p = new CauseObject_V_COM_QUERY_CONTROLCODE();
                p.USER_ID = user.ID;
                p.DEFAULT_PAGE_URL = string.Concat("%", Ipedf.Core.UrlHelper.PrepareName(page));
                DisplayObject_V_COM_QUERY_CONTROLCODE[] result = HelperObject_V_COM_QUERY_CONTROLCODE.Query(p);
                if (result.Length == 0)
                {
                    privilege = new Privilege(null);
                }
                else
                {
                    privilege = new Privilege(PrepareControlCode(result));                    
                }
                SetPrivilegeCache(user, page, privilege);
                return privilege;
                
            }
            else
            {
                return privilege;
            }
        }
        public  bool IsLawless(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).Lawless;
        }
        public  bool IsReadonly(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).ReadOnly;
        }
        public  bool IsAddAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).AddAble;
        }
        public  bool IsEditAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).EidtAble;
        }
        public  bool IsDeleteAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).DeleteAble;
        }
        public bool IsSubmitAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).SubmitAble;
        }
        public bool IsUndoSubmitAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).UndoSubmitAble;
        }
        public bool IsDisableAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).DisableAble;
        }
        public bool IsEnableAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).EnableAble;
        }
        public  bool IsAuditAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).AuditAble;
        }
        public  bool IsUndoAuditAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).UndoAuditAble;
        }
        public bool IsCancelAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).CancelAble;
        }        
        public bool IsArchiveAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).ArchiveAble;
        }
        public bool IsWorkflowAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).WorkflowAble;
        }
        public bool IsPrintAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).PrintAble;
        }
        public bool IsImportAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).ImportAble;
        }
        public bool IsExportAble(DisplayObject_COM_USER user, Page page)
        {
            return GetPrivilege(user, page).ExportAble;
        }
        private  string PrepareUrl(string url)
        {
            string[] urlArray = url.Split('/');
            return string.Concat(urlArray.Length - 3 > 0 ? urlArray[urlArray.Length - 3] : string.Empty, "/", urlArray.Length - 2 > 0 ? urlArray[urlArray.Length - 2] : string.Empty, "/", urlArray.Length - 1 > 0 ? urlArray[urlArray.Length - 1] : string.Empty);
        }   
    }
}