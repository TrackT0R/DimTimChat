//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace DimTimChat.Droid.somee {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IChatService", Namespace="http://tempuri.org/")]
    public partial class ChatService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetMessagesOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendMessageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ChatService() {
            this.Url = "http://uryvchikov.somee.com/ChatService/ChatService.svc";
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
        public event GetMessagesCompletedEventHandler GetMessagesCompleted;
        
        /// <remarks/>
        public event SendMessageCompletedEventHandler SendMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IChatService/GetMessages", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] GetMessages(ref System.DateTime lastTime, [System.Xml.Serialization.XmlIgnoreAttribute()] ref bool lastTimeSpecified) {
            object[] results = this.Invoke("GetMessages", new object[] {
                        lastTime,
                        lastTimeSpecified});
            lastTime = ((System.DateTime)(results[1]));
            lastTimeSpecified = ((bool)(results[2]));
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetMessagesAsync(System.DateTime lastTime, bool lastTimeSpecified) {
            this.GetMessagesAsync(lastTime, lastTimeSpecified, null);
        }
        
        /// <remarks/>
        public void GetMessagesAsync(System.DateTime lastTime, bool lastTimeSpecified, object userState) {
            if ((this.GetMessagesOperationCompleted == null)) {
                this.GetMessagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMessagesOperationCompleted);
            }
            this.InvokeAsync("GetMessages", new object[] {
                        lastTime,
                        lastTimeSpecified}, this.GetMessagesOperationCompleted, userState);
        }
        
        private void OnGetMessagesOperationCompleted(object arg) {
            if ((this.GetMessagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMessagesCompleted(this, new GetMessagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IChatService/SendMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendMessage([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string text) {
            this.Invoke("SendMessage", new object[] {
                        text});
        }
        
        /// <remarks/>
        public void SendMessageAsync(string text) {
            this.SendMessageAsync(text, null);
        }
        
        /// <remarks/>
        public void SendMessageAsync(string text, object userState) {
            if ((this.SendMessageOperationCompleted == null)) {
                this.SendMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMessageOperationCompleted);
            }
            this.InvokeAsync("SendMessage", new object[] {
                        text}, this.SendMessageOperationCompleted, userState);
        }
        
        private void OnSendMessageOperationCompleted(object arg) {
            if ((this.SendMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetMessagesCompletedEventHandler(object sender, GetMessagesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMessagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMessagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
        
        /// <remarks/>
        public System.DateTime lastTime {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public bool lastTimeSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SendMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591