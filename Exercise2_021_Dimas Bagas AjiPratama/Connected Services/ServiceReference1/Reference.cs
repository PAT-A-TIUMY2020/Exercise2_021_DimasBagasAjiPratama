﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exercise2_021_Dimas_Bagas_AjiPratama.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITI_UMY")]
    public interface ITI_UMY {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetAllMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/GetAllMahasiswaResponse")]
        ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa[] GetAllMahasiswa();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetAllMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/GetAllMahasiswaResponse")]
        System.Threading.Tasks.Task<ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa[]> GetAllMahasiswaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetMahasiswaByNIM", ReplyAction="http://tempuri.org/ITI_UMY/GetMahasiswaByNIMResponse")]
        ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa GetMahasiswaByNIM(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetMahasiswaByNIM", ReplyAction="http://tempuri.org/ITI_UMY/GetMahasiswaByNIMResponse")]
        System.Threading.Tasks.Task<ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa> GetMahasiswaByNIMAsync(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/CreateMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/CreateMahasiswaResponse")]
        string CreateMahasiswa(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/CreateMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/CreateMahasiswaResponse")]
        System.Threading.Tasks.Task<string> CreateMahasiswaAsync(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/UpdateMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/UpdateMahasiswaResponse")]
        string UpdateMahasiswa(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/UpdateMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/UpdateMahasiswaResponse")]
        System.Threading.Tasks.Task<string> UpdateMahasiswaAsync(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/DeleteMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/DeleteMahasiswaResponse")]
        string DeleteMahasiswa(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/DeleteMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/DeleteMahasiswaResponse")]
        System.Threading.Tasks.Task<string> DeleteMahasiswaAsync(string nim);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITI_UMYChannel : Exercise2_021_Dimas_Bagas_AjiPratama.ServiceReference1.ITI_UMY, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TI_UMYClient : System.ServiceModel.ClientBase<Exercise2_021_Dimas_Bagas_AjiPratama.ServiceReference1.ITI_UMY>, Exercise2_021_Dimas_Bagas_AjiPratama.ServiceReference1.ITI_UMY {
        
        public TI_UMYClient() {
        }
        
        public TI_UMYClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TI_UMYClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TI_UMYClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TI_UMYClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa[] GetAllMahasiswa() {
            return base.Channel.GetAllMahasiswa();
        }
        
        public System.Threading.Tasks.Task<ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa[]> GetAllMahasiswaAsync() {
            return base.Channel.GetAllMahasiswaAsync();
        }
        
        public ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa GetMahasiswaByNIM(string nim) {
            return base.Channel.GetMahasiswaByNIM(nim);
        }
        
        public System.Threading.Tasks.Task<ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa> GetMahasiswaByNIMAsync(string nim) {
            return base.Channel.GetMahasiswaByNIMAsync(nim);
        }
        
        public string CreateMahasiswa(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs) {
            return base.Channel.CreateMahasiswa(mhs);
        }
        
        public System.Threading.Tasks.Task<string> CreateMahasiswaAsync(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs) {
            return base.Channel.CreateMahasiswaAsync(mhs);
        }
        
        public string UpdateMahasiswa(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs) {
            return base.Channel.UpdateMahasiswa(mhs);
        }
        
        public System.Threading.Tasks.Task<string> UpdateMahasiswaAsync(ServiceRest_021_Dimas_Bagas_AjiPratama.Mahasiswa mhs) {
            return base.Channel.UpdateMahasiswaAsync(mhs);
        }
        
        public string DeleteMahasiswa(string nim) {
            return base.Channel.DeleteMahasiswa(nim);
        }
        
        public System.Threading.Tasks.Task<string> DeleteMahasiswaAsync(string nim) {
            return base.Channel.DeleteMahasiswaAsync(nim);
        }
    }
}
