﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityBase", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Auto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Comanda))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.DetaliuComanda))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Imagine))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Material))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Mecanic))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Operatie))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Sasiu))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarService.Client))]
    public partial class EntityBase : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auto", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Auto : CarService.EntityBase
    {
        
        private CarService.Client ClientField;
        
        private int ClientIdField;
        
        private CarService.Comanda[] ComandaField;
        
        private int IdField;
        
        private string NumarAutoField;
        
        private CarService.Sasiu SasiuField;
        
        private int SasiuIdField;
        
        private string SerieSasiuField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Client Client
        {
            get
            {
                return this.ClientField;
            }
            set
            {
                this.ClientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId
        {
            get
            {
                return this.ClientIdField;
            }
            set
            {
                this.ClientIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Comanda[] Comanda
        {
            get
            {
                return this.ComandaField;
            }
            set
            {
                this.ComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumarAuto
        {
            get
            {
                return this.NumarAutoField;
            }
            set
            {
                this.NumarAutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Sasiu Sasiu
        {
            get
            {
                return this.SasiuField;
            }
            set
            {
                this.SasiuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SasiuId
        {
            get
            {
                return this.SasiuIdField;
            }
            set
            {
                this.SasiuIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SerieSasiu
        {
            get
            {
                return this.SerieSasiuField;
            }
            set
            {
                this.SerieSasiuField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comanda", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Comanda : CarService.EntityBase
    {
        
        private CarService.Auto AutoField;
        
        private int AutoIdField;
        
        private CarService.Client ClientField;
        
        private int ClientIdField;
        
        private System.DateTime DataFinalizareField;
        
        private System.DateTime DataProgramareField;
        
        private System.DateTime DataSystemField;
        
        private string DescriereField;
        
        private CarService.DetaliuComanda[] DetaliuComandaField;
        
        private int IdField;
        
        private int KmBordField;
        
        private string StareComandaField;
        
        private decimal ValoarePieseField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Auto Auto
        {
            get
            {
                return this.AutoField;
            }
            set
            {
                this.AutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutoId
        {
            get
            {
                return this.AutoIdField;
            }
            set
            {
                this.AutoIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Client Client
        {
            get
            {
                return this.ClientField;
            }
            set
            {
                this.ClientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId
        {
            get
            {
                return this.ClientIdField;
            }
            set
            {
                this.ClientIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataFinalizare
        {
            get
            {
                return this.DataFinalizareField;
            }
            set
            {
                this.DataFinalizareField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataProgramare
        {
            get
            {
                return this.DataProgramareField;
            }
            set
            {
                this.DataProgramareField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataSystem
        {
            get
            {
                return this.DataSystemField;
            }
            set
            {
                this.DataSystemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descriere
        {
            get
            {
                return this.DescriereField;
            }
            set
            {
                this.DescriereField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.DetaliuComanda[] DetaliuComanda
        {
            get
            {
                return this.DetaliuComandaField;
            }
            set
            {
                this.DetaliuComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KmBord
        {
            get
            {
                return this.KmBordField;
            }
            set
            {
                this.KmBordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StareComanda
        {
            get
            {
                return this.StareComandaField;
            }
            set
            {
                this.StareComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ValoarePiese
        {
            get
            {
                return this.ValoarePieseField;
            }
            set
            {
                this.ValoarePieseField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetaliuComanda", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class DetaliuComanda : CarService.EntityBase
    {
        
        private CarService.Comanda ComandaField;
        
        private int ComandaIdField;
        
        private int IdField;
        
        private CarService.Imagine[] ImagineField;
        
        private CarService.Material MaterialField;
        
        private int MaterialIdField;
        
        private CarService.Mecanic MecanicField;
        
        private int MecanicIdField;
        
        private CarService.Operatie OperatieField;
        
        private int OperatieIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Comanda Comanda
        {
            get
            {
                return this.ComandaField;
            }
            set
            {
                this.ComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ComandaId
        {
            get
            {
                return this.ComandaIdField;
            }
            set
            {
                this.ComandaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Imagine[] Imagine
        {
            get
            {
                return this.ImagineField;
            }
            set
            {
                this.ImagineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Material Material
        {
            get
            {
                return this.MaterialField;
            }
            set
            {
                this.MaterialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaterialId
        {
            get
            {
                return this.MaterialIdField;
            }
            set
            {
                this.MaterialIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Mecanic Mecanic
        {
            get
            {
                return this.MecanicField;
            }
            set
            {
                this.MecanicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MecanicId
        {
            get
            {
                return this.MecanicIdField;
            }
            set
            {
                this.MecanicIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Operatie Operatie
        {
            get
            {
                return this.OperatieField;
            }
            set
            {
                this.OperatieField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OperatieId
        {
            get
            {
                return this.OperatieIdField;
            }
            set
            {
                this.OperatieIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Imagine", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Imagine : CarService.EntityBase
    {
        
        private System.DateTime DataField;
        
        private string DescriereField;
        
        private CarService.DetaliuComanda DetaliuComandaField;
        
        private int DetaliuComandaIdField;
        
        private int IdField;
        
        private byte[] PhotoField;
        
        private string TitluField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descriere
        {
            get
            {
                return this.DescriereField;
            }
            set
            {
                this.DescriereField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.DetaliuComanda DetaliuComanda
        {
            get
            {
                return this.DetaliuComandaField;
            }
            set
            {
                this.DetaliuComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DetaliuComandaId
        {
            get
            {
                return this.DetaliuComandaIdField;
            }
            set
            {
                this.DetaliuComandaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Photo
        {
            get
            {
                return this.PhotoField;
            }
            set
            {
                this.PhotoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titlu
        {
            get
            {
                return this.TitluField;
            }
            set
            {
                this.TitluField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Material", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Material : CarService.EntityBase
    {
        
        private decimal CantitateField;
        
        private System.DateTime DataAprovizionareField;
        
        private string DenumireField;
        
        private CarService.DetaliuComanda[] DetaliuComandaField;
        
        private int IdField;
        
        private decimal PretField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Cantitate
        {
            get
            {
                return this.CantitateField;
            }
            set
            {
                this.CantitateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAprovizionare
        {
            get
            {
                return this.DataAprovizionareField;
            }
            set
            {
                this.DataAprovizionareField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Denumire
        {
            get
            {
                return this.DenumireField;
            }
            set
            {
                this.DenumireField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.DetaliuComanda[] DetaliuComanda
        {
            get
            {
                return this.DetaliuComandaField;
            }
            set
            {
                this.DetaliuComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Pret
        {
            get
            {
                return this.PretField;
            }
            set
            {
                this.PretField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Mecanic", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Mecanic : CarService.EntityBase
    {
        
        private CarService.DetaliuComanda[] DetaliuComandaField;
        
        private int IdField;
        
        private string NumeField;
        
        private string PrenumeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.DetaliuComanda[] DetaliuComanda
        {
            get
            {
                return this.DetaliuComandaField;
            }
            set
            {
                this.DetaliuComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nume
        {
            get
            {
                return this.NumeField;
            }
            set
            {
                this.NumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenume
        {
            get
            {
                return this.PrenumeField;
            }
            set
            {
                this.PrenumeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Operatie", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Operatie : CarService.EntityBase
    {
        
        private string DenumireField;
        
        private CarService.DetaliuComanda[] DetaliuComandaField;
        
        private int IdField;
        
        private decimal TimpExecutieField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Denumire
        {
            get
            {
                return this.DenumireField;
            }
            set
            {
                this.DenumireField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.DetaliuComanda[] DetaliuComanda
        {
            get
            {
                return this.DetaliuComandaField;
            }
            set
            {
                this.DetaliuComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TimpExecutie
        {
            get
            {
                return this.TimpExecutieField;
            }
            set
            {
                this.TimpExecutieField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sasiu", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Sasiu : CarService.EntityBase
    {
        
        private CarService.Auto[] AutoField;
        
        private string CodSasiuField;
        
        private string DenumireField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Auto[] Auto
        {
            get
            {
                return this.AutoField;
            }
            set
            {
                this.AutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodSasiu
        {
            get
            {
                return this.CodSasiuField;
            }
            set
            {
                this.CodSasiuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Denumire
        {
            get
            {
                return this.DenumireField;
            }
            set
            {
                this.DenumireField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/CarService", IsReference=true)]
    public partial class Client : CarService.EntityBase
    {
        
        private string AdresaField;
        
        private CarService.Auto[] AutoField;
        
        private CarService.Comanda[] ComandaField;
        
        private string EmailField;
        
        private int IdField;
        
        private string JudetField;
        
        private string LocalitateField;
        
        private string NumeField;
        
        private string PrenumeField;
        
        private string TelefonField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adresa
        {
            get
            {
                return this.AdresaField;
            }
            set
            {
                this.AdresaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Auto[] Auto
        {
            get
            {
                return this.AutoField;
            }
            set
            {
                this.AutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarService.Comanda[] Comanda
        {
            get
            {
                return this.ComandaField;
            }
            set
            {
                this.ComandaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Judet
        {
            get
            {
                return this.JudetField;
            }
            set
            {
                this.JudetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Localitate
        {
            get
            {
                return this.LocalitateField;
            }
            set
            {
                this.LocalitateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nume
        {
            get
            {
                return this.NumeField;
            }
            set
            {
                this.NumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenume
        {
            get
            {
                return this.PrenumeField;
            }
            set
            {
                this.PrenumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefon
        {
            get
            {
                return this.TelefonField;
            }
            set
            {
                this.TelefonField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICarService")]
public interface ICarService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceClients/AddClient", ReplyAction="http://tempuri.org/InterfaceClients/AddClientResponse")]
    bool AddClient(CarService.Client client);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceClients/AddClient", ReplyAction="http://tempuri.org/InterfaceClients/AddClientResponse")]
    System.Threading.Tasks.Task<bool> AddClientAsync(CarService.Client client);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICarServiceChannel : ICarService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CarServiceClient : System.ServiceModel.ClientBase<ICarService>, ICarService
{
    
    public CarServiceClient()
    {
    }
    
    public CarServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool AddClient(CarService.Client client)
    {
        return base.Channel.AddClient(client);
    }
    
    public System.Threading.Tasks.Task<bool> AddClientAsync(CarService.Client client)
    {
        return base.Channel.AddClientAsync(client);
    }
}