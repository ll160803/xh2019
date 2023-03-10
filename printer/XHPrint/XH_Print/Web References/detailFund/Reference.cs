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

namespace XH_Print.detailFund {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ZFI02_WS_JFMX", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZFI02_WS_JFMX : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Zfi02FmJfmxOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ZFI02_WS_JFMX() {
            this.Url = global::XH_Print.Properties.Settings.Default.XH_Print_detailFund_ZFI02_WS_JFMX;
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
        public event Zfi02FmJfmxCompletedEventHandler Zfi02FmJfmxCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:ZFI02_WS_JFMX:Zfi02FmJfmxRequest" +
            "", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("Zfi02FmJfmxResponse", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public Zfi02FmJfmxResponse Zfi02FmJfmx([System.Xml.Serialization.XmlElementAttribute("Zfi02FmJfmx", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] Zfi02FmJfmx Zfi02FmJfmx1) {
            object[] results = this.Invoke("Zfi02FmJfmx", new object[] {
                        Zfi02FmJfmx1});
            return ((Zfi02FmJfmxResponse)(results[0]));
        }
        
        /// <remarks/>
        public void Zfi02FmJfmxAsync(Zfi02FmJfmx Zfi02FmJfmx1) {
            this.Zfi02FmJfmxAsync(Zfi02FmJfmx1, null);
        }
        
        /// <remarks/>
        public void Zfi02FmJfmxAsync(Zfi02FmJfmx Zfi02FmJfmx1, object userState) {
            if ((this.Zfi02FmJfmxOperationCompleted == null)) {
                this.Zfi02FmJfmxOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZfi02FmJfmxOperationCompleted);
            }
            this.InvokeAsync("Zfi02FmJfmx", new object[] {
                        Zfi02FmJfmx1}, this.Zfi02FmJfmxOperationCompleted, userState);
        }
        
        private void OnZfi02FmJfmxOperationCompleted(object arg) {
            if ((this.Zfi02FmJfmxCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Zfi02FmJfmxCompleted(this, new Zfi02FmJfmxCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zfi02FmJfmx {
        
        private Zfi02S025[] etSzmxField;
        
        private string iAufexField;
        
        private string ibBudatField;
        
        private string ieBudatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zfi02S025[] EtSzmx {
            get {
                return this.etSzmxField;
            }
            set {
                this.etSzmxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IAufex {
            get {
                return this.iAufexField;
            }
            set {
                this.iAufexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IbBudat {
            get {
                return this.ibBudatField;
            }
            set {
                this.ibBudatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IeBudat {
            get {
                return this.ieBudatField;
            }
            set {
                this.ieBudatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zfi02S025 {
        
        private string zjfxbField;
        
        private string budatField;
        
        private string gjahrField;
        
        private string belnrField;
        
        private string zpzsnField;
        
        private string bktxtField;
        
        private string aufnrField;
        
        private string aufexField;
        
        private decimal dmbtrField;
        
        private string zltextField;
        
        private string zlcbhField;
        
        private string zbxusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zjfxb {
            get {
                return this.zjfxbField;
            }
            set {
                this.zjfxbField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Budat {
            get {
                return this.budatField;
            }
            set {
                this.budatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Gjahr {
            get {
                return this.gjahrField;
            }
            set {
                this.gjahrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Belnr {
            get {
                return this.belnrField;
            }
            set {
                this.belnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zpzsn {
            get {
                return this.zpzsnField;
            }
            set {
                this.zpzsnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Bktxt {
            get {
                return this.bktxtField;
            }
            set {
                this.bktxtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Aufnr {
            get {
                return this.aufnrField;
            }
            set {
                this.aufnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Aufex {
            get {
                return this.aufexField;
            }
            set {
                this.aufexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Dmbtr {
            get {
                return this.dmbtrField;
            }
            set {
                this.dmbtrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zltext {
            get {
                return this.zltextField;
            }
            set {
                this.zltextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zlcbh {
            get {
                return this.zlcbhField;
            }
            set {
                this.zlcbhField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zbxus {
            get {
                return this.zbxusField;
            }
            set {
                this.zbxusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zfi02FmJfmxResponse {
        
        private string eMsgtxField;
        
        private string eMsgtyField;
        
        private Zfi02S025[] etSzmxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMsgtx {
            get {
                return this.eMsgtxField;
            }
            set {
                this.eMsgtxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMsgty {
            get {
                return this.eMsgtyField;
            }
            set {
                this.eMsgtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zfi02S025[] EtSzmx {
            get {
                return this.etSzmxField;
            }
            set {
                this.etSzmxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void Zfi02FmJfmxCompletedEventHandler(object sender, Zfi02FmJfmxCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Zfi02FmJfmxCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Zfi02FmJfmxCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Zfi02FmJfmxResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Zfi02FmJfmxResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591