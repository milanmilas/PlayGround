﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinServiceStartStop.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Allocate/Magnum/AssistantService", ConfigurationName="ServiceReference1.FinalisationService")]
    public interface FinalisationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Allocate/Magnum/AssistantService/FinalisationService/Finalise", ReplyAction="http://Allocate/Magnum/AssistantService/FinalisationService/FinaliseResponse")]
        void Finalise(string dutyId, string connectionString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Allocate/Magnum/AssistantService/FinalisationService/Unfinalise", ReplyAction="http://Allocate/Magnum/AssistantService/FinalisationService/UnfinaliseResponse")]
        void Unfinalise(string dutyId, string connectionString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Allocate/Magnum/AssistantService/FinalisationService/KillComObject", ReplyAction="http://Allocate/Magnum/AssistantService/FinalisationService/KillComObjectResponse" +
            "")]
        void KillComObject(bool waitForCurrent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Allocate/Magnum/AssistantService/FinalisationService/ChangeFinalisationSet" +
            "tings", ReplyAction="http://Allocate/Magnum/AssistantService/FinalisationService/ChangeFinalisationSet" +
            "tingsResponse")]
        void ChangeFinalisationSettings(int maxAgeMinutes, int maxLastAccessMinutes, int timerIntervalMilliseconds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Allocate/Magnum/AssistantService/FinalisationService/GetFinalisationSettin" +
            "gs", ReplyAction="http://Allocate/Magnum/AssistantService/FinalisationService/GetFinalisationSettin" +
            "gsResponse")]
        int[] GetFinalisationSettings();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FinalisationServiceChannel : WinServiceStartStop.ServiceReference1.FinalisationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FinalisationServiceClient : System.ServiceModel.ClientBase<WinServiceStartStop.ServiceReference1.FinalisationService>, WinServiceStartStop.ServiceReference1.FinalisationService {
        
        public FinalisationServiceClient() {
        }
        
        public FinalisationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FinalisationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinalisationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinalisationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Finalise(string dutyId, string connectionString) {
            base.Channel.Finalise(dutyId, connectionString);
        }
        
        public void Unfinalise(string dutyId, string connectionString) {
            base.Channel.Unfinalise(dutyId, connectionString);
        }
        
        public void KillComObject(bool waitForCurrent) {
            base.Channel.KillComObject(waitForCurrent);
        }
        
        public void ChangeFinalisationSettings(int maxAgeMinutes, int maxLastAccessMinutes, int timerIntervalMilliseconds) {
            base.Channel.ChangeFinalisationSettings(maxAgeMinutes, maxLastAccessMinutes, timerIntervalMilliseconds);
        }
        
        public int[] GetFinalisationSettings() {
            return base.Channel.GetFinalisationSettings();
        }
    }
}