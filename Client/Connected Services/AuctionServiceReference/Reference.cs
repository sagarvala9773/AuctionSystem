﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.AuctionServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auction", Namespace="http://schemas.datacontract.org/2004/07/PlayerService")]
    [System.SerializableAttribute()]
    public partial class Auction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int F_PlayerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int I_PlayerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string S_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int T_PlayerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int T_TeamField;
        
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
        public int F_Player {
            get {
                return this.F_PlayerField;
            }
            set {
                if ((this.F_PlayerField.Equals(value) != true)) {
                    this.F_PlayerField = value;
                    this.RaisePropertyChanged("F_Player");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int I_Player {
            get {
                return this.I_PlayerField;
            }
            set {
                if ((this.I_PlayerField.Equals(value) != true)) {
                    this.I_PlayerField = value;
                    this.RaisePropertyChanged("I_Player");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string S_Name {
            get {
                return this.S_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.S_NameField, value) != true)) {
                    this.S_NameField = value;
                    this.RaisePropertyChanged("S_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Season {
            get {
                return this.SeasonField;
            }
            set {
                if ((this.SeasonField.Equals(value) != true)) {
                    this.SeasonField = value;
                    this.RaisePropertyChanged("Season");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int T_Player {
            get {
                return this.T_PlayerField;
            }
            set {
                if ((this.T_PlayerField.Equals(value) != true)) {
                    this.T_PlayerField = value;
                    this.RaisePropertyChanged("T_Player");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int T_Team {
            get {
                return this.T_TeamField;
            }
            set {
                if ((this.T_TeamField.Equals(value) != true)) {
                    this.T_TeamField = value;
                    this.RaisePropertyChanged("T_Team");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/PlayerService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuctionServiceReference.IAuctionService")]
    public interface IAuctionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctions", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionsResponse")]
        System.Data.DataSet GetAuctions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctions", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAuctionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/AddAuction", ReplyAction="http://tempuri.org/IAuctionService/AddAuctionResponse")]
        string AddAuction(Client.AuctionServiceReference.Auction auction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/AddAuction", ReplyAction="http://tempuri.org/IAuctionService/AddAuctionResponse")]
        System.Threading.Tasks.Task<string> AddAuctionAsync(Client.AuctionServiceReference.Auction auction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/DeleteAuction", ReplyAction="http://tempuri.org/IAuctionService/DeleteAuctionResponse")]
        string DeleteAuction(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/DeleteAuction", ReplyAction="http://tempuri.org/IAuctionService/DeleteAuctionResponse")]
        System.Threading.Tasks.Task<string> DeleteAuctionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/UpdateAuction", ReplyAction="http://tempuri.org/IAuctionService/UpdateAuctionResponse")]
        string UpdateAuction(Client.AuctionServiceReference.Auction auction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/UpdateAuction", ReplyAction="http://tempuri.org/IAuctionService/UpdateAuctionResponse")]
        System.Threading.Tasks.Task<string> UpdateAuctionAsync(Client.AuctionServiceReference.Auction auction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IAuctionService/GetDataUsingDataContractResponse")]
        Client.AuctionServiceReference.CompositeType GetDataUsingDataContract(Client.AuctionServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IAuctionService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Client.AuctionServiceReference.CompositeType> GetDataUsingDataContractAsync(Client.AuctionServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuctionServiceChannel : Client.AuctionServiceReference.IAuctionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuctionServiceClient : System.ServiceModel.ClientBase<Client.AuctionServiceReference.IAuctionService>, Client.AuctionServiceReference.IAuctionService {
        
        public AuctionServiceClient() {
        }
        
        public AuctionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuctionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAuctions() {
            return base.Channel.GetAuctions();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAuctionsAsync() {
            return base.Channel.GetAuctionsAsync();
        }
        
        public string AddAuction(Client.AuctionServiceReference.Auction auction) {
            return base.Channel.AddAuction(auction);
        }
        
        public System.Threading.Tasks.Task<string> AddAuctionAsync(Client.AuctionServiceReference.Auction auction) {
            return base.Channel.AddAuctionAsync(auction);
        }
        
        public string DeleteAuction(int id) {
            return base.Channel.DeleteAuction(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAuctionAsync(int id) {
            return base.Channel.DeleteAuctionAsync(id);
        }
        
        public string UpdateAuction(Client.AuctionServiceReference.Auction auction) {
            return base.Channel.UpdateAuction(auction);
        }
        
        public System.Threading.Tasks.Task<string> UpdateAuctionAsync(Client.AuctionServiceReference.Auction auction) {
            return base.Channel.UpdateAuctionAsync(auction);
        }
        
        public Client.AuctionServiceReference.CompositeType GetDataUsingDataContract(Client.AuctionServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Client.AuctionServiceReference.CompositeType> GetDataUsingDataContractAsync(Client.AuctionServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
