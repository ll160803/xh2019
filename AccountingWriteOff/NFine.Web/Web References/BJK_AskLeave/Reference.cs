﻿//------------------------------------------------------------------------------
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

namespace NFine.Web.BJK_AskLeave {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ZHRWS_ZGBJKTJ", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZHRWS_ZGBJKTJ : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Zhr00FmZgbjktjOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ZHRWS_ZGBJKTJ() {
            this.Url = global::NFine.Web.Properties.Settings.Default.NFine_Web_BJK_AskLeave_ZHRWS_ZGBJKTJ;
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
        public event Zhr00FmZgbjktjCompletedEventHandler Zhr00FmZgbjktjCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:ZHRWS_ZGBJKTJ:Zhr00FmZgbjktjRequ" +
            "est", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("Zhr00FmZgbjktjResponse", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public Zhr00FmZgbjktjResponse Zhr00FmZgbjktj([System.Xml.Serialization.XmlElementAttribute("Zhr00FmZgbjktj", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] Zhr00FmZgbjktj Zhr00FmZgbjktj1) {
            object[] results = this.Invoke("Zhr00FmZgbjktj", new object[] {
                        Zhr00FmZgbjktj1});
            return ((Zhr00FmZgbjktjResponse)(results[0]));
        }
        
        /// <remarks/>
        public void Zhr00FmZgbjktjAsync(Zhr00FmZgbjktj Zhr00FmZgbjktj1) {
            this.Zhr00FmZgbjktjAsync(Zhr00FmZgbjktj1, null);
        }
        
        /// <remarks/>
        public void Zhr00FmZgbjktjAsync(Zhr00FmZgbjktj Zhr00FmZgbjktj1, object userState) {
            if ((this.Zhr00FmZgbjktjOperationCompleted == null)) {
                this.Zhr00FmZgbjktjOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZhr00FmZgbjktjOperationCompleted);
            }
            this.InvokeAsync("Zhr00FmZgbjktj", new object[] {
                        Zhr00FmZgbjktj1}, this.Zhr00FmZgbjktjOperationCompleted, userState);
        }
        
        private void OnZhr00FmZgbjktjOperationCompleted(object arg) {
            if ((this.Zhr00FmZgbjktjCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Zhr00FmZgbjktjCompleted(this, new Zhr00FmZgbjktjCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Zhr00FmZgbjktj {
        
        private Zhr00T099[] t_099Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zhr00T099[] T_099 {
            get {
                return this.t_099Field;
            }
            set {
                this.t_099Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zhr00T099 {
        
        private string mandtField;
        
        private string guiddhField;
        
        private string guidmxField;
        
        private string senroField;
        
        private string pernrField;
        
        private string nachnField;
        
        private string zhrqjlxField;
        
        private string zhrqjmsField;
        
        private string begdaField;
        
        private string enddaField;
        
        private int zqjtsField;
        
        private string zhrksField;
        
        private string zhrksmsField;
        
        private string zhrzkField;
        
        private string zhrzkmsField;
        
        private string zhrzyksField;
        
        private string zhrjbzdField;
        
        private string zhrjblxField;
        
        private string zhrbzField;
        
        private string ztjrField;
        
        private string ztjrqField;
        
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
        public string Guiddh {
            get {
                return this.guiddhField;
            }
            set {
                this.guiddhField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guidmx {
            get {
                return this.guidmxField;
            }
            set {
                this.guidmxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Senro {
            get {
                return this.senroField;
            }
            set {
                this.senroField = value;
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
        public string Zhrqjlx {
            get {
                return this.zhrqjlxField;
            }
            set {
                this.zhrqjlxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrqjms {
            get {
                return this.zhrqjmsField;
            }
            set {
                this.zhrqjmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Begda {
            get {
                return this.begdaField;
            }
            set {
                this.begdaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Endda {
            get {
                return this.enddaField;
            }
            set {
                this.enddaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Zqjts {
            get {
                return this.zqjtsField;
            }
            set {
                this.zqjtsField = value;
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
        public string Zhrzyks {
            get {
                return this.zhrzyksField;
            }
            set {
                this.zhrzyksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrjbzd {
            get {
                return this.zhrjbzdField;
            }
            set {
                this.zhrjbzdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zhrjblx {
            get {
                return this.zhrjblxField;
            }
            set {
                this.zhrjblxField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zhr00FmZgbjktjResponse {
        
        private string mesField;
        
        private Zhr00T099[] t_099Field;
        
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
        public Zhr00T099[] T_099 {
            get {
                return this.t_099Field;
            }
            set {
                this.t_099Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void Zhr00FmZgbjktjCompletedEventHandler(object sender, Zhr00FmZgbjktjCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Zhr00FmZgbjktjCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Zhr00FmZgbjktjCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zhr00FmZgbjktjResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zhr00FmZgbjktjResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591