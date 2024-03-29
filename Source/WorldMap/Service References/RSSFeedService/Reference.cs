﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace WorldMap.RSSFeedService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RSSFeedService.IRSSFeedService")]
    public interface IRSSFeedService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRSSFeedService/GetRSSString", ReplyAction="http://tempuri.org/IRSSFeedService/GetRSSStringResponse")]
        System.IAsyncResult BeginGetRSSString(string rssUrl, System.AsyncCallback callback, object asyncState);
        
        string EndGetRSSString(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRSSFeedServiceChannel : WorldMap.RSSFeedService.IRSSFeedService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetRSSStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetRSSStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RSSFeedServiceClient : System.ServiceModel.ClientBase<WorldMap.RSSFeedService.IRSSFeedService>, WorldMap.RSSFeedService.IRSSFeedService {
        
        private BeginOperationDelegate onBeginGetRSSStringDelegate;
        
        private EndOperationDelegate onEndGetRSSStringDelegate;
        
        private System.Threading.SendOrPostCallback onGetRSSStringCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public RSSFeedServiceClient() {
        }
        
        public RSSFeedServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RSSFeedServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RSSFeedServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RSSFeedServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetRSSStringCompletedEventArgs> GetRSSStringCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WorldMap.RSSFeedService.IRSSFeedService.BeginGetRSSString(string rssUrl, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetRSSString(rssUrl, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string WorldMap.RSSFeedService.IRSSFeedService.EndGetRSSString(System.IAsyncResult result) {
            return base.Channel.EndGetRSSString(result);
        }
        
        private System.IAsyncResult OnBeginGetRSSString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string rssUrl = ((string)(inValues[0]));
            return ((WorldMap.RSSFeedService.IRSSFeedService)(this)).BeginGetRSSString(rssUrl, callback, asyncState);
        }
        
        private object[] OnEndGetRSSString(System.IAsyncResult result) {
            string retVal = ((WorldMap.RSSFeedService.IRSSFeedService)(this)).EndGetRSSString(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetRSSStringCompleted(object state) {
            if ((this.GetRSSStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetRSSStringCompleted(this, new GetRSSStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetRSSStringAsync(string rssUrl) {
            this.GetRSSStringAsync(rssUrl, null);
        }
        
        public void GetRSSStringAsync(string rssUrl, object userState) {
            if ((this.onBeginGetRSSStringDelegate == null)) {
                this.onBeginGetRSSStringDelegate = new BeginOperationDelegate(this.OnBeginGetRSSString);
            }
            if ((this.onEndGetRSSStringDelegate == null)) {
                this.onEndGetRSSStringDelegate = new EndOperationDelegate(this.OnEndGetRSSString);
            }
            if ((this.onGetRSSStringCompletedDelegate == null)) {
                this.onGetRSSStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetRSSStringCompleted);
            }
            base.InvokeAsync(this.onBeginGetRSSStringDelegate, new object[] {
                        rssUrl}, this.onEndGetRSSStringDelegate, this.onGetRSSStringCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override WorldMap.RSSFeedService.IRSSFeedService CreateChannel() {
            return new RSSFeedServiceClientChannel(this);
        }
        
        private class RSSFeedServiceClientChannel : ChannelBase<WorldMap.RSSFeedService.IRSSFeedService>, WorldMap.RSSFeedService.IRSSFeedService {
            
            public RSSFeedServiceClientChannel(System.ServiceModel.ClientBase<WorldMap.RSSFeedService.IRSSFeedService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetRSSString(string rssUrl, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = rssUrl;
                System.IAsyncResult _result = base.BeginInvoke("GetRSSString", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetRSSString(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetRSSString", _args, result)));
                return _result;
            }
        }
    }
}
