using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using StormyCommerce.Module.Orders.Area.Models;

namespace StormyCommerce.Module.Orders.Interfaces
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30310-0943")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CalcPrecoPrazoWSSoap")]
    public interface ICalcPrecoPrazoWSSoap
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrecoPrazo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrecoPrazoData", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrecoPrazoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrecoPrazoRestricao", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrecoPrazoRestricaoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPreco", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrecoData", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrecoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrazo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrazoData", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrazoDataAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrazoRestricao", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrazoRestricaoAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcPrecoFAC", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultado> CalcPrecoFACAsync(string nCdServico, string nVlPeso, string strDataCalculo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/CalcDataMaxima", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultadoObjeto> CalcDataMaximaAsync(string codigoObjeto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ListaServicos", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultadoServicos> ListaServicosAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ListaServicosSTAR", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultadoServicos> ListaServicosSTARAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/VerificaModal", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<cResultadoModal> VerificaModalAsync(string nCdServico, string sCepOrigem, string sCepDestino);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/getVersao", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<versao> getVersaoAsync();
    }
}
