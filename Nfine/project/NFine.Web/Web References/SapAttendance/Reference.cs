//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace NFine.Web.SapAttendance {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ZHRWS_KQKSHZ", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZHRWS_KQKSHZ : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Zhr00FmKqksspOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ZHRWS_KQKSHZ() {
            this.Url = global::NFine.Web.Properties.Settings.Default.NFine_Web_SapAttendance_ZHRWS_KQKSHZ;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event Zhr00FmKqksspCompletedEventHandler Zhr00FmKqksspCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:ZHRWS_KQkshz:Zhr00FmKqksspReques" +
            "t", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("Zhr00FmKqksspResponse", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public Zhr00FmKqksspResponse Zhr00FmKqkssp([System.Xml.Serialization.XmlElementAttribute("Zhr00FmKqkssp", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] Zhr00FmKqkssp Zhr00FmKqkssp1) {
            object[] results = this.Invoke("Zhr00FmKqkssp", new object[] {
                        Zhr00FmKqkssp1});
            return ((Zhr00FmKqksspResponse)(results[0]));
        }
        
        /// <remarks/>
        public void Zhr00FmKqksspAsync(Zhr00FmKqkssp Zhr00FmKqkssp1) {
            this.Zhr00FmKqksspAsync(Zhr00FmKqkssp1, null);
        }
        
        /// <remarks/>
        public void Zhr00FmKqksspAsync(Zhr00FmKqkssp Zhr00FmKqkssp1, object userState) {
            if ((this.Zhr00FmKqksspOperationCompleted == null)) {
                this.Zhr00FmKqksspOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZhr00FmKqksspOperationCompleted);
            }
            this.InvokeAsync("Zhr00FmKqkssp", new object[] {
                        Zhr00FmKqkssp1}, this.Zhr00FmKqksspOperationCompleted, userState);
        }
        
        private void OnZhr00FmKqksspOperationCompleted(object arg) {
            if ((this.Zhr00FmKqksspCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Zhr00FmKqksspCompleted(this, new Zhr00FmKqksspCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zhr00FmKqkssp {
        
        private Zhr00T098[] t_098Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zhr00T098[] T_098 {
            get {
                return this.t_098Field;
            }
            set {
                this.t_098Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zhr00T098 {
        
        private string mandtField;
        
        private string guidField;
        
        private string pernrField;
        
        private string nachnField;
        
        private string zperField;
        
        private string zhrksField;
        
        private string zhrksmsField;
        
        private string zhrzkField;
        
        private string zhrzkmsField;
        
        private string zhrbzField;
        
        private string ztjrField;
        
        private string ztjrqField;
        
        private string ztjsjField;
        
        private string zshrField;
        
        private string zshrqField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mandt {
            get {
                return this.mandtField;
            }
            set {
                this.mandtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid {
            get {
                return this.guidField;
            }
            set {
                this.guidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Pernr {
            get {
                return this.pernrField;
            }
            set {
                this.pernrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Nachn {
            get {
                return this.nachnField;
            }
            set {
                this.nachnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zper {
            get {
                return this.zperField;
            }
            set {
                this.zperField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrks {
            get {
                return this.zhrksField;
            }
            set {
                this.zhrksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrksms {
            get {
                return this.zhrksmsField;
            }
            set {
                this.zhrksmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrzk {
            get {
                return this.zhrzkField;
            }
            set {
                this.zhrzkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrzkms {
            get {
                return this.zhrzkmsField;
            }
            set {
                this.zhrzkmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrbz {
            get {
                return this.zhrbzField;
            }
            set {
                this.zhrbzField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ztjr {
            get {
                return this.ztjrField;
            }
            set {
                this.ztjrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ztjrq {
            get {
                return this.ztjrqField;
            }
            set {
                this.ztjrqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ztjsj {
            get {
                return this.ztjsjField;
            }
            set {
                this.ztjsjField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zshr {
            get {
                return this.zshrField;
            }
            set {
                this.zshrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zshrq {
            get {
                return this.zshrqField;
            }
            set {
                this.zshrqField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zhr00FmKqksspResponse {
        
        private string mesField;
        
        private Zhr00T098[] t_098Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Mes {
            get {
                return this.mesField;
            }
            set {
                this.mesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zhr00T098[] T_098 {
            get {
                return this.t_098Field;
            }
            set {
                this.t_098Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void Zhr00FmKqksspCompletedEventHandler(object sender, Zhr00FmKqksspCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Zhr00FmKqksspCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Zhr00FmKqksspCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zhr00FmKqksspResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zhr00FmKqksspResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591