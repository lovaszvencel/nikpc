﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nikpc.CurrencyExchange {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mnb.hu/webservices/", ConfigurationName="CurrencyExchange.MNBArfolyamServiceSoap")]
    public interface MNBArfolyamServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetInfoResult from namespace http://www.mnb.hu/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetInfo", ReplyAction="*")]
        Nikpc.CurrencyExchange.GetInfoResponse GetInfo(Nikpc.CurrencyExchange.GetInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetInfoResponse> GetInfoAsync(Nikpc.CurrencyExchange.GetInfoRequest request);
        
        // CODEGEN: Generating message contract since element name GetCurrentExchangeRatesResult from namespace http://www.mnb.hu/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetCurrentExchangeRates", ReplyAction="*")]
        Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponse GetCurrentExchangeRates(Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetCurrentExchangeRates", ReplyAction="*")]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponse> GetCurrentExchangeRatesAsync(Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest request);
        
        // CODEGEN: Generating message contract since element name startDate from namespace http://www.mnb.hu/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetExchangeRates", ReplyAction="*")]
        Nikpc.CurrencyExchange.GetExchangeRatesResponse GetExchangeRates(Nikpc.CurrencyExchange.GetExchangeRatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetExchangeRates", ReplyAction="*")]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetExchangeRatesResponse> GetExchangeRatesAsync(Nikpc.CurrencyExchange.GetExchangeRatesRequest request);
        
        // CODEGEN: Generating message contract since element name GetDateIntervalResult from namespace http://www.mnb.hu/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetDateInterval", ReplyAction="*")]
        Nikpc.CurrencyExchange.GetDateIntervalResponse GetDateInterval(Nikpc.CurrencyExchange.GetDateIntervalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetDateInterval", ReplyAction="*")]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetDateIntervalResponse> GetDateIntervalAsync(Nikpc.CurrencyExchange.GetDateIntervalRequest request);
        
        // CODEGEN: Generating message contract since element name GetCurrenciesResult from namespace http://www.mnb.hu/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetCurrencies", ReplyAction="*")]
        Nikpc.CurrencyExchange.GetCurrenciesResponse GetCurrencies(Nikpc.CurrencyExchange.GetCurrenciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetCurrencies", ReplyAction="*")]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrenciesResponse> GetCurrenciesAsync(Nikpc.CurrencyExchange.GetCurrenciesRequest request);
        
        // CODEGEN: Generating message contract since element name currencyNames from namespace http://www.mnb.hu/webservices/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetCurrencyUnits", ReplyAction="*")]
        Nikpc.CurrencyExchange.GetCurrencyUnitsResponse GetCurrencyUnits(Nikpc.CurrencyExchange.GetCurrencyUnitsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/GetCurrencyUnits", ReplyAction="*")]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrencyUnitsResponse> GetCurrencyUnitsAsync(Nikpc.CurrencyExchange.GetCurrencyUnitsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInfo", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetInfoRequestBody Body;
        
        public GetInfoRequest() {
        }
        
        public GetInfoRequest(Nikpc.CurrencyExchange.GetInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetInfoRequestBody {
        
        public GetInfoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInfoResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetInfoResponseBody Body;
        
        public GetInfoResponse() {
        }
        
        public GetInfoResponse(Nikpc.CurrencyExchange.GetInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetInfoResult;
        
        public GetInfoResponseBody() {
        }
        
        public GetInfoResponseBody(string GetInfoResult) {
            this.GetInfoResult = GetInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrentExchangeRatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrentExchangeRates", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequestBody Body;
        
        public GetCurrentExchangeRatesRequest() {
        }
        
        public GetCurrentExchangeRatesRequest(Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCurrentExchangeRatesRequestBody {
        
        public GetCurrentExchangeRatesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrentExchangeRatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrentExchangeRatesResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponseBody Body;
        
        public GetCurrentExchangeRatesResponse() {
        }
        
        public GetCurrentExchangeRatesResponse(Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrentExchangeRatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCurrentExchangeRatesResult;
        
        public GetCurrentExchangeRatesResponseBody() {
        }
        
        public GetCurrentExchangeRatesResponseBody(string GetCurrentExchangeRatesResult) {
            this.GetCurrentExchangeRatesResult = GetCurrentExchangeRatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetExchangeRatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetExchangeRates", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetExchangeRatesRequestBody Body;
        
        public GetExchangeRatesRequest() {
        }
        
        public GetExchangeRatesRequest(Nikpc.CurrencyExchange.GetExchangeRatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetExchangeRatesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string startDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string endDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string currencyNames;
        
        public GetExchangeRatesRequestBody() {
        }
        
        public GetExchangeRatesRequestBody(string startDate, string endDate, string currencyNames) {
            this.startDate = startDate;
            this.endDate = endDate;
            this.currencyNames = currencyNames;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetExchangeRatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetExchangeRatesResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetExchangeRatesResponseBody Body;
        
        public GetExchangeRatesResponse() {
        }
        
        public GetExchangeRatesResponse(Nikpc.CurrencyExchange.GetExchangeRatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetExchangeRatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetExchangeRatesResult;
        
        public GetExchangeRatesResponseBody() {
        }
        
        public GetExchangeRatesResponseBody(string GetExchangeRatesResult) {
            this.GetExchangeRatesResult = GetExchangeRatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateIntervalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateInterval", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetDateIntervalRequestBody Body;
        
        public GetDateIntervalRequest() {
        }
        
        public GetDateIntervalRequest(Nikpc.CurrencyExchange.GetDateIntervalRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDateIntervalRequestBody {
        
        public GetDateIntervalRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateIntervalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateIntervalResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetDateIntervalResponseBody Body;
        
        public GetDateIntervalResponse() {
        }
        
        public GetDateIntervalResponse(Nikpc.CurrencyExchange.GetDateIntervalResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetDateIntervalResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetDateIntervalResult;
        
        public GetDateIntervalResponseBody() {
        }
        
        public GetDateIntervalResponseBody(string GetDateIntervalResult) {
            this.GetDateIntervalResult = GetDateIntervalResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrenciesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrencies", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetCurrenciesRequestBody Body;
        
        public GetCurrenciesRequest() {
        }
        
        public GetCurrenciesRequest(Nikpc.CurrencyExchange.GetCurrenciesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCurrenciesRequestBody {
        
        public GetCurrenciesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrenciesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrenciesResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetCurrenciesResponseBody Body;
        
        public GetCurrenciesResponse() {
        }
        
        public GetCurrenciesResponse(Nikpc.CurrencyExchange.GetCurrenciesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrenciesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCurrenciesResult;
        
        public GetCurrenciesResponseBody() {
        }
        
        public GetCurrenciesResponseBody(string GetCurrenciesResult) {
            this.GetCurrenciesResult = GetCurrenciesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrencyUnitsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrencyUnits", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetCurrencyUnitsRequestBody Body;
        
        public GetCurrencyUnitsRequest() {
        }
        
        public GetCurrencyUnitsRequest(Nikpc.CurrencyExchange.GetCurrencyUnitsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrencyUnitsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string currencyNames;
        
        public GetCurrencyUnitsRequestBody() {
        }
        
        public GetCurrencyUnitsRequestBody(string currencyNames) {
            this.currencyNames = currencyNames;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrencyUnitsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrencyUnitsResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public Nikpc.CurrencyExchange.GetCurrencyUnitsResponseBody Body;
        
        public GetCurrencyUnitsResponse() {
        }
        
        public GetCurrencyUnitsResponse(Nikpc.CurrencyExchange.GetCurrencyUnitsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrencyUnitsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCurrencyUnitsResult;
        
        public GetCurrencyUnitsResponseBody() {
        }
        
        public GetCurrencyUnitsResponseBody(string GetCurrencyUnitsResult) {
            this.GetCurrencyUnitsResult = GetCurrencyUnitsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MNBArfolyamServiceSoapChannel : Nikpc.CurrencyExchange.MNBArfolyamServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MNBArfolyamServiceSoapClient : System.ServiceModel.ClientBase<Nikpc.CurrencyExchange.MNBArfolyamServiceSoap>, Nikpc.CurrencyExchange.MNBArfolyamServiceSoap {
        
        public MNBArfolyamServiceSoapClient() {
        }
        
        public MNBArfolyamServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MNBArfolyamServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MNBArfolyamServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MNBArfolyamServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nikpc.CurrencyExchange.GetInfoResponse Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetInfo(Nikpc.CurrencyExchange.GetInfoRequest request) {
            return base.Channel.GetInfo(request);
        }
        
        public string GetInfo() {
            Nikpc.CurrencyExchange.GetInfoRequest inValue = new Nikpc.CurrencyExchange.GetInfoRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetInfoRequestBody();
            Nikpc.CurrencyExchange.GetInfoResponse retVal = ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetInfo(inValue);
            return retVal.Body.GetInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetInfoResponse> Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetInfoAsync(Nikpc.CurrencyExchange.GetInfoRequest request) {
            return base.Channel.GetInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetInfoResponse> GetInfoAsync() {
            Nikpc.CurrencyExchange.GetInfoRequest inValue = new Nikpc.CurrencyExchange.GetInfoRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetInfoRequestBody();
            return ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponse Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetCurrentExchangeRates(Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest request) {
            return base.Channel.GetCurrentExchangeRates(request);
        }
        
        public string GetCurrentExchangeRates() {
            Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest inValue = new Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequestBody();
            Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponse retVal = ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetCurrentExchangeRates(inValue);
            return retVal.Body.GetCurrentExchangeRatesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponse> Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetCurrentExchangeRatesAsync(Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest request) {
            return base.Channel.GetCurrentExchangeRatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrentExchangeRatesResponse> GetCurrentExchangeRatesAsync() {
            Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest inValue = new Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetCurrentExchangeRatesRequestBody();
            return ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetCurrentExchangeRatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nikpc.CurrencyExchange.GetExchangeRatesResponse Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetExchangeRates(Nikpc.CurrencyExchange.GetExchangeRatesRequest request) {
            return base.Channel.GetExchangeRates(request);
        }
        
        public string GetExchangeRates(string startDate, string endDate, string currencyNames) {
            Nikpc.CurrencyExchange.GetExchangeRatesRequest inValue = new Nikpc.CurrencyExchange.GetExchangeRatesRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetExchangeRatesRequestBody();
            inValue.Body.startDate = startDate;
            inValue.Body.endDate = endDate;
            inValue.Body.currencyNames = currencyNames;
            Nikpc.CurrencyExchange.GetExchangeRatesResponse retVal = ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetExchangeRates(inValue);
            return retVal.Body.GetExchangeRatesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetExchangeRatesResponse> Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetExchangeRatesAsync(Nikpc.CurrencyExchange.GetExchangeRatesRequest request) {
            return base.Channel.GetExchangeRatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetExchangeRatesResponse> GetExchangeRatesAsync(string startDate, string endDate, string currencyNames) {
            Nikpc.CurrencyExchange.GetExchangeRatesRequest inValue = new Nikpc.CurrencyExchange.GetExchangeRatesRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetExchangeRatesRequestBody();
            inValue.Body.startDate = startDate;
            inValue.Body.endDate = endDate;
            inValue.Body.currencyNames = currencyNames;
            return ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetExchangeRatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nikpc.CurrencyExchange.GetDateIntervalResponse Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetDateInterval(Nikpc.CurrencyExchange.GetDateIntervalRequest request) {
            return base.Channel.GetDateInterval(request);
        }
        
        public string GetDateInterval() {
            Nikpc.CurrencyExchange.GetDateIntervalRequest inValue = new Nikpc.CurrencyExchange.GetDateIntervalRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetDateIntervalRequestBody();
            Nikpc.CurrencyExchange.GetDateIntervalResponse retVal = ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetDateInterval(inValue);
            return retVal.Body.GetDateIntervalResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetDateIntervalResponse> Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetDateIntervalAsync(Nikpc.CurrencyExchange.GetDateIntervalRequest request) {
            return base.Channel.GetDateIntervalAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetDateIntervalResponse> GetDateIntervalAsync() {
            Nikpc.CurrencyExchange.GetDateIntervalRequest inValue = new Nikpc.CurrencyExchange.GetDateIntervalRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetDateIntervalRequestBody();
            return ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetDateIntervalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nikpc.CurrencyExchange.GetCurrenciesResponse Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetCurrencies(Nikpc.CurrencyExchange.GetCurrenciesRequest request) {
            return base.Channel.GetCurrencies(request);
        }
        
        public string GetCurrencies() {
            Nikpc.CurrencyExchange.GetCurrenciesRequest inValue = new Nikpc.CurrencyExchange.GetCurrenciesRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetCurrenciesRequestBody();
            Nikpc.CurrencyExchange.GetCurrenciesResponse retVal = ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetCurrencies(inValue);
            return retVal.Body.GetCurrenciesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrenciesResponse> Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetCurrenciesAsync(Nikpc.CurrencyExchange.GetCurrenciesRequest request) {
            return base.Channel.GetCurrenciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrenciesResponse> GetCurrenciesAsync() {
            Nikpc.CurrencyExchange.GetCurrenciesRequest inValue = new Nikpc.CurrencyExchange.GetCurrenciesRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetCurrenciesRequestBody();
            return ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetCurrenciesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nikpc.CurrencyExchange.GetCurrencyUnitsResponse Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetCurrencyUnits(Nikpc.CurrencyExchange.GetCurrencyUnitsRequest request) {
            return base.Channel.GetCurrencyUnits(request);
        }
        
        public string GetCurrencyUnits(string currencyNames) {
            Nikpc.CurrencyExchange.GetCurrencyUnitsRequest inValue = new Nikpc.CurrencyExchange.GetCurrencyUnitsRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetCurrencyUnitsRequestBody();
            inValue.Body.currencyNames = currencyNames;
            Nikpc.CurrencyExchange.GetCurrencyUnitsResponse retVal = ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetCurrencyUnits(inValue);
            return retVal.Body.GetCurrencyUnitsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrencyUnitsResponse> Nikpc.CurrencyExchange.MNBArfolyamServiceSoap.GetCurrencyUnitsAsync(Nikpc.CurrencyExchange.GetCurrencyUnitsRequest request) {
            return base.Channel.GetCurrencyUnitsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nikpc.CurrencyExchange.GetCurrencyUnitsResponse> GetCurrencyUnitsAsync(string currencyNames) {
            Nikpc.CurrencyExchange.GetCurrencyUnitsRequest inValue = new Nikpc.CurrencyExchange.GetCurrencyUnitsRequest();
            inValue.Body = new Nikpc.CurrencyExchange.GetCurrencyUnitsRequestBody();
            inValue.Body.currencyNames = currencyNames;
            return ((Nikpc.CurrencyExchange.MNBArfolyamServiceSoap)(this)).GetCurrencyUnitsAsync(inValue);
        }
    }
}