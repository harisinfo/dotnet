﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trustev.Api.v1_1.Services.Social {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddProfileRequest", Namespace="http://schemas.datacontract.org/2004/07/Social.Verify.Types.DataContracts.v1_1.So" +
        "cial.Requests")]
    [System.SerializableAttribute()]
    public partial class AddProfileRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Trustev.Api.v1_1.Services.Social.SocialNetwork> SocialNetworksField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Trustev.Api.v1_1.Services.Social.SocialNetwork> SocialNetworks {
            get {
                return this.SocialNetworksField;
            }
            set {
                if ((object.ReferenceEquals(this.SocialNetworksField, value) != true)) {
                    this.SocialNetworksField = value;
                    this.RaisePropertyChanged("SocialNetworks");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SocialNetwork", Namespace="http://schemas.datacontract.org/2004/07/Social.Verify.Types.DataContracts.v1_1.So" +
        "cial")]
    [System.SerializableAttribute()]
    public partial class SocialNetwork : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LongTermAccessTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LongTermAccessTokenExpiryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecretField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShortTermAccessTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ShortTermAccessTokenExpiryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Trustev.Api.v1_1.Services.Social.ConstantsSocialNetworkType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LongTermAccessToken {
            get {
                return this.LongTermAccessTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.LongTermAccessTokenField, value) != true)) {
                    this.LongTermAccessTokenField = value;
                    this.RaisePropertyChanged("LongTermAccessToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LongTermAccessTokenExpiry {
            get {
                return this.LongTermAccessTokenExpiryField;
            }
            set {
                if ((this.LongTermAccessTokenExpiryField.Equals(value) != true)) {
                    this.LongTermAccessTokenExpiryField = value;
                    this.RaisePropertyChanged("LongTermAccessTokenExpiry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Secret {
            get {
                return this.SecretField;
            }
            set {
                if ((object.ReferenceEquals(this.SecretField, value) != true)) {
                    this.SecretField = value;
                    this.RaisePropertyChanged("Secret");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShortTermAccessToken {
            get {
                return this.ShortTermAccessTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.ShortTermAccessTokenField, value) != true)) {
                    this.ShortTermAccessTokenField = value;
                    this.RaisePropertyChanged("ShortTermAccessToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ShortTermAccessTokenExpiry {
            get {
                return this.ShortTermAccessTokenExpiryField;
            }
            set {
                if ((this.ShortTermAccessTokenExpiryField.Equals(value) != true)) {
                    this.ShortTermAccessTokenExpiryField = value;
                    this.RaisePropertyChanged("ShortTermAccessTokenExpiry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Trustev.Api.v1_1.Services.Social.ConstantsSocialNetworkType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Constants.SocialNetworkType", Namespace="http://schemas.datacontract.org/2004/07/Social.Verify.Types")]
    public enum ConstantsSocialNetworkType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Facebook = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Twitter = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LinkedIn = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Trustev = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TrustevSession = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestBase", Namespace="http://schemas.datacontract.org/2004/07/Social.Verify.Types.DataContracts.v1.Auth" +
        "entication")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Trustev.Api.v1_1.Services.Social.UpdateProfileRequest))]
    public partial class RequestBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimestampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp {
            get {
                return this.TimestampField;
            }
            set {
                if ((this.TimestampField.Equals(value) != true)) {
                    this.TimestampField = value;
                    this.RaisePropertyChanged("Timestamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateProfileRequest", Namespace="http://schemas.datacontract.org/2004/07/Social.Verify.Types.DataContracts.v1_1.So" +
        "cial.Requests")]
    [System.SerializableAttribute()]
    public partial class UpdateProfileRequest : Trustev.Api.v1_1.Services.Social.RequestBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Trustev.Api.v1_1.Services.Social.SocialNetwork> SocialNetworksField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Trustev.Api.v1_1.Services.Social.SocialNetwork> SocialNetworks {
            get {
                return this.SocialNetworksField;
            }
            set {
                if ((object.ReferenceEquals(this.SocialNetworksField, value) != true)) {
                    this.SocialNetworksField = value;
                    this.RaisePropertyChanged("SocialNetworks");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://api.trustev.com", ConfigurationName="v1_1.Services.Social.ISocialService")]
    public interface ISocialService {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://api.trustev.com/ISocialService/AddProfile", ReplyAction="https://api.trustev.com/ISocialService/AddProfileResponse")]
        void AddProfile(Trustev.Api.v1_1.Services.Social.AddProfileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://api.trustev.com/ISocialService/UpdateProfile", ReplyAction="https://api.trustev.com/ISocialService/UpdateProfileResponse")]
        void UpdateProfile(Trustev.Api.v1_1.Services.Social.UpdateProfileRequest request, string type, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://api.trustev.com/ISocialService/DeleteProfile", ReplyAction="https://api.trustev.com/ISocialService/DeleteProfileResponse")]
        void DeleteProfile(string type, string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISocialServiceChannel : Trustev.Api.v1_1.Services.Social.ISocialService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SocialServiceClient : System.ServiceModel.ClientBase<Trustev.Api.v1_1.Services.Social.ISocialService>, Trustev.Api.v1_1.Services.Social.ISocialService {
        
        public SocialServiceClient() {
        }
        
        public SocialServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SocialServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocialServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocialServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddProfile(Trustev.Api.v1_1.Services.Social.AddProfileRequest request) {
            base.Channel.AddProfile(request);
        }
        
        public void UpdateProfile(Trustev.Api.v1_1.Services.Social.UpdateProfileRequest request, string type, string id) {
            base.Channel.UpdateProfile(request, type, id);
        }
        
        public void DeleteProfile(string type, string id) {
            base.Channel.DeleteProfile(type, id);
        }
    }
}
