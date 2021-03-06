//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.PlayerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/PlayerService")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int J_NoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string P_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string P_TypeField;
        
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
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
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
        public int J_No {
            get {
                return this.J_NoField;
            }
            set {
                if ((this.J_NoField.Equals(value) != true)) {
                    this.J_NoField = value;
                    this.RaisePropertyChanged("J_No");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string P_Name {
            get {
                return this.P_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.P_NameField, value) != true)) {
                    this.P_NameField = value;
                    this.RaisePropertyChanged("P_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string P_Type {
            get {
                return this.P_TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.P_TypeField, value) != true)) {
                    this.P_TypeField = value;
                    this.RaisePropertyChanged("P_Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PlayerServiceReference.IPlayerService")]
    public interface IPlayerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/GetPlayers", ReplyAction="http://tempuri.org/IPlayerService/GetPlayersResponse")]
        System.Data.DataSet GetPlayers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/GetPlayers", ReplyAction="http://tempuri.org/IPlayerService/GetPlayersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetPlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/AddPlayer", ReplyAction="http://tempuri.org/IPlayerService/AddPlayerResponse")]
        string AddPlayer(Client.PlayerServiceReference.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/AddPlayer", ReplyAction="http://tempuri.org/IPlayerService/AddPlayerResponse")]
        System.Threading.Tasks.Task<string> AddPlayerAsync(Client.PlayerServiceReference.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/DeletePlayer", ReplyAction="http://tempuri.org/IPlayerService/DeletePlayerResponse")]
        string DeletePlayer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/DeletePlayer", ReplyAction="http://tempuri.org/IPlayerService/DeletePlayerResponse")]
        System.Threading.Tasks.Task<string> DeletePlayerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/UpdatePlayer", ReplyAction="http://tempuri.org/IPlayerService/UpdatePlayerResponse")]
        string UpdatePlayer(Client.PlayerServiceReference.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/UpdatePlayer", ReplyAction="http://tempuri.org/IPlayerService/UpdatePlayerResponse")]
        System.Threading.Tasks.Task<string> UpdatePlayerAsync(Client.PlayerServiceReference.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPlayerService/GetDataUsingDataContractResponse")]
        Client.PlayerServiceReference.CompositeType GetDataUsingDataContract(Client.PlayerServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPlayerService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Client.PlayerServiceReference.CompositeType> GetDataUsingDataContractAsync(Client.PlayerServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlayerServiceChannel : Client.PlayerServiceReference.IPlayerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PlayerServiceClient : System.ServiceModel.ClientBase<Client.PlayerServiceReference.IPlayerService>, Client.PlayerServiceReference.IPlayerService {
        
        public PlayerServiceClient() {
        }
        
        public PlayerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PlayerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetPlayers() {
            return base.Channel.GetPlayers();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetPlayersAsync() {
            return base.Channel.GetPlayersAsync();
        }
        
        public string AddPlayer(Client.PlayerServiceReference.Player player) {
            return base.Channel.AddPlayer(player);
        }
        
        public System.Threading.Tasks.Task<string> AddPlayerAsync(Client.PlayerServiceReference.Player player) {
            return base.Channel.AddPlayerAsync(player);
        }
        
        public string DeletePlayer(int id) {
            return base.Channel.DeletePlayer(id);
        }
        
        public System.Threading.Tasks.Task<string> DeletePlayerAsync(int id) {
            return base.Channel.DeletePlayerAsync(id);
        }
        
        public string UpdatePlayer(Client.PlayerServiceReference.Player player) {
            return base.Channel.UpdatePlayer(player);
        }
        
        public System.Threading.Tasks.Task<string> UpdatePlayerAsync(Client.PlayerServiceReference.Player player) {
            return base.Channel.UpdatePlayerAsync(player);
        }
        
        public Client.PlayerServiceReference.CompositeType GetDataUsingDataContract(Client.PlayerServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Client.PlayerServiceReference.CompositeType> GetDataUsingDataContractAsync(Client.PlayerServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
