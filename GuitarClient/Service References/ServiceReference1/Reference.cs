﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuitarClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGuitarService")]
    public interface IGuitarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/FindAll", ReplyAction="http://tempuri.org/IGuitarService/FindAllResponse")]
        GuitarSOA.Guitar[] FindAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/FindAll", ReplyAction="http://tempuri.org/IGuitarService/FindAllResponse")]
        System.Threading.Tasks.Task<GuitarSOA.Guitar[]> FindAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/Add", ReplyAction="http://tempuri.org/IGuitarService/AddResponse")]
        void Add(GuitarSOA.Guitar g);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/Add", ReplyAction="http://tempuri.org/IGuitarService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(GuitarSOA.Guitar g);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/Delete", ReplyAction="http://tempuri.org/IGuitarService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/Delete", ReplyAction="http://tempuri.org/IGuitarService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/Edit", ReplyAction="http://tempuri.org/IGuitarService/EditResponse")]
        GuitarSOA.Guitar Edit(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/Edit", ReplyAction="http://tempuri.org/IGuitarService/EditResponse")]
        System.Threading.Tasks.Task<GuitarSOA.Guitar> EditAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/SaveEdit", ReplyAction="http://tempuri.org/IGuitarService/SaveEditResponse")]
        void SaveEdit(GuitarSOA.Guitar g);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuitarService/SaveEdit", ReplyAction="http://tempuri.org/IGuitarService/SaveEditResponse")]
        System.Threading.Tasks.Task SaveEditAsync(GuitarSOA.Guitar g);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuitarServiceChannel : GuitarClient.ServiceReference1.IGuitarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GuitarServiceClient : System.ServiceModel.ClientBase<GuitarClient.ServiceReference1.IGuitarService>, GuitarClient.ServiceReference1.IGuitarService {
        
        public GuitarServiceClient() {
        }
        
        public GuitarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GuitarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuitarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuitarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GuitarSOA.Guitar[] FindAll() {
            return base.Channel.FindAll();
        }
        
        public System.Threading.Tasks.Task<GuitarSOA.Guitar[]> FindAllAsync() {
            return base.Channel.FindAllAsync();
        }
        
        public void Add(GuitarSOA.Guitar g) {
            base.Channel.Add(g);
        }
        
        public System.Threading.Tasks.Task AddAsync(GuitarSOA.Guitar g) {
            return base.Channel.AddAsync(g);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public GuitarSOA.Guitar Edit(int id) {
            return base.Channel.Edit(id);
        }
        
        public System.Threading.Tasks.Task<GuitarSOA.Guitar> EditAsync(int id) {
            return base.Channel.EditAsync(id);
        }
        
        public void SaveEdit(GuitarSOA.Guitar g) {
            base.Channel.SaveEdit(g);
        }
        
        public System.Threading.Tasks.Task SaveEditAsync(GuitarSOA.Guitar g) {
            return base.Channel.SaveEditAsync(g);
        }
    }
}
