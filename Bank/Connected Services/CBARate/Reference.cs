﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CBARate
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.cba.am/", ConfigurationName="CBARate.GateSoap")]
    public interface GateSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ISOCodesDetailed", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CBARate.ISOCodesDetailedResponseISOCodesDetailedResult> ISOCodesDetailedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ISOCodes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string[]> ISOCodesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ExchangeRatesLatestByISO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesLatestByISOAsync(string ISO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ExchangeRatesByDateByISO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesByDateByISOAsync(System.DateTime date, string ISO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ExchangeRatesByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesByDateAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ExchangeRatesLatest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesLatestAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cba.am/ExchangeRatesByDateRangeByISO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CBARate.ExchangeRatesByDateRangeByISOResponseExchangeRatesByDateRangeByISOResult> ExchangeRatesByDateRangeByISOAsync(string ISOCodes, System.DateTime DateFrom, System.DateTime DateTo);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.cba.am/")]
    public partial class ISOCodesDetailedResponseISOCodesDetailedResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        private string namespaceField;
        
        private string tableTypeNameField;
        
        public ISOCodesDetailedResponseISOCodesDetailedResult()
        {
            this.namespaceField = "http://tempuri.org/ExchangeRatesDS.xsd";
            this.tableTypeNameField = "ISOCodesDataTable";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableTypeName
        {
            get
            {
                return this.tableTypeNameField;
            }
            set
            {
                this.tableTypeNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.cba.am/")]
    public partial class ExchangeRate
    {
        
        private string iSOField;
        
        private string amountField;
        
        private string rateField;
        
        private string differenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ISO
        {
            get
            {
                return this.iSOField;
            }
            set
            {
                this.iSOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Difference
        {
            get
            {
                return this.differenceField;
            }
            set
            {
                this.differenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.cba.am/")]
    public partial class ExchangeRates
    {
        
        private System.DateTime currentDateField;
        
        private System.Nullable<System.DateTime> nextAvailableDateField;
        
        private System.Nullable<System.DateTime> previousAvailableDateField;
        
        private ExchangeRate[] ratesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime CurrentDate
        {
            get
            {
                return this.currentDateField;
            }
            set
            {
                this.currentDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<System.DateTime> NextAvailableDate
        {
            get
            {
                return this.nextAvailableDateField;
            }
            set
            {
                this.nextAvailableDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<System.DateTime> PreviousAvailableDate
        {
            get
            {
                return this.previousAvailableDateField;
            }
            set
            {
                this.previousAvailableDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        public ExchangeRate[] Rates
        {
            get
            {
                return this.ratesField;
            }
            set
            {
                this.ratesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.cba.am/")]
    public partial class ExchangeRatesByDateRangeByISOResponseExchangeRatesByDateRangeByISOResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        private string namespaceField;
        
        private string tableTypeNameField;
        
        public ExchangeRatesByDateRangeByISOResponseExchangeRatesByDateRangeByISOResult()
        {
            this.namespaceField = "http://tempuri.org/ExchangeRatesDS.xsd";
            this.tableTypeNameField = "ExchangeRatesByRangeDataTable";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableTypeName
        {
            get
            {
                return this.tableTypeNameField;
            }
            set
            {
                this.tableTypeNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface GateSoapChannel : CBARate.GateSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class GateSoapClient : System.ServiceModel.ClientBase<CBARate.GateSoap>, CBARate.GateSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GateSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(GateSoapClient.GetBindingForEndpoint(endpointConfiguration), GateSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GateSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GateSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GateSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GateSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<CBARate.ISOCodesDetailedResponseISOCodesDetailedResult> ISOCodesDetailedAsync()
        {
            return base.Channel.ISOCodesDetailedAsync();
        }
        
        public System.Threading.Tasks.Task<string[]> ISOCodesAsync()
        {
            return base.Channel.ISOCodesAsync();
        }
        
        public System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesLatestByISOAsync(string ISO)
        {
            return base.Channel.ExchangeRatesLatestByISOAsync(ISO);
        }
        
        public System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesByDateByISOAsync(System.DateTime date, string ISO)
        {
            return base.Channel.ExchangeRatesByDateByISOAsync(date, ISO);
        }
        
        public System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesByDateAsync(System.DateTime date)
        {
            return base.Channel.ExchangeRatesByDateAsync(date);
        }
        
        public System.Threading.Tasks.Task<CBARate.ExchangeRates> ExchangeRatesLatestAsync()
        {
            return base.Channel.ExchangeRatesLatestAsync();
        }
        
        public System.Threading.Tasks.Task<CBARate.ExchangeRatesByDateRangeByISOResponseExchangeRatesByDateRangeByISOResult> ExchangeRatesByDateRangeByISOAsync(string ISOCodes, System.DateTime DateFrom, System.DateTime DateTo)
        {
            return base.Channel.ExchangeRatesByDateRangeByISOAsync(ISOCodes, DateFrom, DateTo);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.GateSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.GateSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.GateSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://api.cba.am/exchangerates.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.GateSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://api.cba.am/exchangerates.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            GateSoap,
            
            GateSoap12,
        }
    }
}
