//using SimplCommerce.Module.Correios.Services;
//using System;
//using System.Threading.Tasks;
//using Xunit;

//namespace SimplCommerce.Module.Correios.Tests.Services
//{
//    public class CalcPrecoPrazoWSSoapClientTests
//    {
//        [Fact]
//        public async Task CalcPrecoPrazoAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient();
//            string nCdEmpresa = null;
//            string sDsSenha = null;
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string nVlPeso = null;
//            int nCdFormato = 0;
//            decimal nVlComprimento = 0;
//            decimal nVlAltura = 0;
//            decimal nVlLargura = 0;
//            decimal nVlDiametro = 0;
//            string sCdMaoPropria = null;
//            decimal nVlValorDeclarado = 0;
//            string sCdAvisoRecebimento = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrecoPrazoAsync(
//                nCdEmpresa,
//                sDsSenha,
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                nVlPeso,
//                nCdFormato,
//                nVlComprimento,
//                nVlAltura,
//                nVlLargura,
//                nVlDiametro,
//                sCdMaoPropria,
//                nVlValorDeclarado,
//                sCdAvisoRecebimento);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrecoPrazoDataAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient();
//            string nCdEmpresa = null;
//            string sDsSenha = null;
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string nVlPeso = null;
//            int nCdFormato = 0;
//            decimal nVlComprimento = 0;
//            decimal nVlAltura = 0;
//            decimal nVlLargura = 0;
//            decimal nVlDiametro = 0;
//            string sCdMaoPropria = null;
//            decimal nVlValorDeclarado = 0;
//            string sCdAvisoRecebimento = null;
//            string sDtCalculo = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrecoPrazoDataAsync(
//                nCdEmpresa,
//                sDsSenha,
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                nVlPeso,
//                nCdFormato,
//                nVlComprimento,
//                nVlAltura,
//                nVlLargura,
//                nVlDiametro,
//                sCdMaoPropria,
//                nVlValorDeclarado,
//                sCdAvisoRecebimento,
//                sDtCalculo);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrecoPrazoRestricaoAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdEmpresa = null;
//            string sDsSenha = null;
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string nVlPeso = null;
//            int nCdFormato = 0;
//            decimal nVlComprimento = 0;
//            decimal nVlAltura = 0;
//            decimal nVlLargura = 0;
//            decimal nVlDiametro = 0;
//            string sCdMaoPropria = null;
//            decimal nVlValorDeclarado = 0;
//            string sCdAvisoRecebimento = null;
//            string sDtCalculo = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrecoPrazoRestricaoAsync(
//                nCdEmpresa,
//                sDsSenha,
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                nVlPeso,
//                nCdFormato,
//                nVlComprimento,
//                nVlAltura,
//                nVlLargura,
//                nVlDiametro,
//                sCdMaoPropria,
//                nVlValorDeclarado,
//                sCdAvisoRecebimento,
//                sDtCalculo);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrecoAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdEmpresa = null;
//            string sDsSenha = null;
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string nVlPeso = null;
//            int nCdFormato = 0;
//            decimal nVlComprimento = 0;
//            decimal nVlAltura = 0;
//            decimal nVlLargura = 0;
//            decimal nVlDiametro = 0;
//            string sCdMaoPropria = null;
//            decimal nVlValorDeclarado = 0;
//            string sCdAvisoRecebimento = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrecoAsync(
//                nCdEmpresa,
//                sDsSenha,
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                nVlPeso,
//                nCdFormato,
//                nVlComprimento,
//                nVlAltura,
//                nVlLargura,
//                nVlDiametro,
//                sCdMaoPropria,
//                nVlValorDeclarado,
//                sCdAvisoRecebimento);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrecoDataAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdEmpresa = null;
//            string sDsSenha = null;
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string nVlPeso = null;
//            int nCdFormato = 0;
//            decimal nVlComprimento = 0;
//            decimal nVlAltura = 0;
//            decimal nVlLargura = 0;
//            decimal nVlDiametro = 0;
//            string sCdMaoPropria = null;
//            decimal nVlValorDeclarado = 0;
//            string sCdAvisoRecebimento = null;
//            string sDtCalculo = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrecoDataAsync(
//                nCdEmpresa,
//                sDsSenha,
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                nVlPeso,
//                nCdFormato,
//                nVlComprimento,
//                nVlAltura,
//                nVlLargura,
//                nVlDiametro,
//                sCdMaoPropria,
//                nVlValorDeclarado,
//                sCdAvisoRecebimento,
//                sDtCalculo);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrazoAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrazoAsync(
//                nCdServico,
//                sCepOrigem,
//                sCepDestino);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrazoDataAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string sDtCalculo = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrazoDataAsync(
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                sDtCalculo);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrazoRestricaoAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;
//            string sDtCalculo = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrazoRestricaoAsync(
//                nCdServico,
//                sCepOrigem,
//                sCepDestino,
//                sDtCalculo);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcPrecoFACAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdServico = null;
//            string nVlPeso = null;
//            string strDataCalculo = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcPrecoFACAsync(
//                nCdServico,
//                nVlPeso,
//                strDataCalculo);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CalcDataMaximaAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string codigoObjeto = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.CalcDataMaximaAsync(
//                codigoObjeto);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task ListaServicosAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.ListaServicosAsync();

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task ListaServicosSTARAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.ListaServicosSTARAsync();

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task VerificaModalAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);
//            string nCdServico = null;
//            string sCepOrigem = null;
//            string sCepDestino = null;

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.VerificaModalAsync(
//                nCdServico,
//                sCepOrigem,
//                sCepDestino);

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task getVersaoAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);

//            // Act
//            var result = await calcPrecoPrazoWSSoapClient.getVersaoAsync();

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task OpenAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);

//            // Act
//            await calcPrecoPrazoWSSoapClient.OpenAsync();

//            // Assert
//            Assert.True(false);
//        }

//        [Fact]
//        public async Task CloseAsync_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var calcPrecoPrazoWSSoapClient = new CalcPrecoPrazoWSSoapClient(null);

//            // Act
//            await calcPrecoPrazoWSSoapClient.CloseAsync();

//            // Assert
//            Assert.True(false);
//        }
//    }
//}
