﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora.ServicoWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://servicoWeb.calculadora/", ConfigurationName="ServicoWeb.ServicoWeb")]
    public interface ServicoWeb {
        
        // CODEGEN: Gerando contrato de mensagem porque o namespace de parte da mensagem () não corresponde ao valor padrão (http://servicoWeb.calculadora/)
        [System.ServiceModel.OperationContractAttribute(Action="http://servicoWeb.calculadora/ServicoWeb/somaRequest", ReplyAction="http://servicoWeb.calculadora/ServicoWeb/somaResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Calculadora.ServicoWeb.somaResponse soma(Calculadora.ServicoWeb.somaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicoWeb.calculadora/ServicoWeb/somaRequest", ReplyAction="http://servicoWeb.calculadora/ServicoWeb/somaResponse")]
        System.Threading.Tasks.Task<Calculadora.ServicoWeb.somaResponse> somaAsync(Calculadora.ServicoWeb.somaRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque o namespace de parte da mensagem () não corresponde ao valor padrão (http://servicoWeb.calculadora/)
        [System.ServiceModel.OperationContractAttribute(Action="http://servicoWeb.calculadora/ServicoWeb/subtracaoRequest", ReplyAction="http://servicoWeb.calculadora/ServicoWeb/subtracaoResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Calculadora.ServicoWeb.subtracaoResponse subtracao(Calculadora.ServicoWeb.subtracaoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicoWeb.calculadora/ServicoWeb/subtracaoRequest", ReplyAction="http://servicoWeb.calculadora/ServicoWeb/subtracaoResponse")]
        System.Threading.Tasks.Task<Calculadora.ServicoWeb.subtracaoResponse> subtracaoAsync(Calculadora.ServicoWeb.subtracaoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="soma", WrapperNamespace="http://servicoWeb.calculadora/", IsWrapped=true)]
    public partial class somaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public double arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public double arg1;
        
        public somaRequest() {
        }
        
        public somaRequest(double arg0, double arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="somaResponse", WrapperNamespace="http://servicoWeb.calculadora/", IsWrapped=true)]
    public partial class somaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public double @return;
        
        public somaResponse() {
        }
        
        public somaResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="subtracao", WrapperNamespace="http://servicoWeb.calculadora/", IsWrapped=true)]
    public partial class subtracaoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public double arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public double arg1;
        
        public subtracaoRequest() {
        }
        
        public subtracaoRequest(double arg0, double arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="subtracaoResponse", WrapperNamespace="http://servicoWeb.calculadora/", IsWrapped=true)]
    public partial class subtracaoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public double @return;
        
        public subtracaoResponse() {
        }
        
        public subtracaoResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicoWebChannel : Calculadora.ServicoWeb.ServicoWeb, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoWebClient : System.ServiceModel.ClientBase<Calculadora.ServicoWeb.ServicoWeb>, Calculadora.ServicoWeb.ServicoWeb {
        
        public ServicoWebClient() {
        }
        
        public ServicoWebClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoWebClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoWebClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoWebClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora.ServicoWeb.somaResponse Calculadora.ServicoWeb.ServicoWeb.soma(Calculadora.ServicoWeb.somaRequest request) {
            return base.Channel.soma(request);
        }
        
        public double soma(double arg0, double arg1) {
            Calculadora.ServicoWeb.somaRequest inValue = new Calculadora.ServicoWeb.somaRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            Calculadora.ServicoWeb.somaResponse retVal = ((Calculadora.ServicoWeb.ServicoWeb)(this)).soma(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora.ServicoWeb.somaResponse> Calculadora.ServicoWeb.ServicoWeb.somaAsync(Calculadora.ServicoWeb.somaRequest request) {
            return base.Channel.somaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora.ServicoWeb.somaResponse> somaAsync(double arg0, double arg1) {
            Calculadora.ServicoWeb.somaRequest inValue = new Calculadora.ServicoWeb.somaRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((Calculadora.ServicoWeb.ServicoWeb)(this)).somaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora.ServicoWeb.subtracaoResponse Calculadora.ServicoWeb.ServicoWeb.subtracao(Calculadora.ServicoWeb.subtracaoRequest request) {
            return base.Channel.subtracao(request);
        }
        
        public double subtracao(double arg0, double arg1) {
            Calculadora.ServicoWeb.subtracaoRequest inValue = new Calculadora.ServicoWeb.subtracaoRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            Calculadora.ServicoWeb.subtracaoResponse retVal = ((Calculadora.ServicoWeb.ServicoWeb)(this)).subtracao(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora.ServicoWeb.subtracaoResponse> Calculadora.ServicoWeb.ServicoWeb.subtracaoAsync(Calculadora.ServicoWeb.subtracaoRequest request) {
            return base.Channel.subtracaoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora.ServicoWeb.subtracaoResponse> subtracaoAsync(double arg0, double arg1) {
            Calculadora.ServicoWeb.subtracaoRequest inValue = new Calculadora.ServicoWeb.subtracaoRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((Calculadora.ServicoWeb.ServicoWeb)(this)).subtracaoAsync(inValue);
        }
    }
}