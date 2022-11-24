using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU06_StepDefinitions
    {
        [Given(@"que el usuario quiere validar la información de sus gastos")]
        public void GivenQueElUsuarioQuiereValidarLaInformacionDeSusGastos()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioQuiereValidarLaInformacionDeSusGastos)}");
        }

        [When(@"el usuario realiza un gasto online o presencial\.")]
        public void WhenElUsuarioRealizaUnGastoOnlineOPresencial_()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioRealizaUnGastoOnlineOPresencial_)}");
        }

        [When(@"el usuario haya registrado su gasto en el aplicativo")]
        public void WhenElUsuarioHayaRegistradoSuGastoEnElAplicativo()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioHayaRegistradoSuGastoEnElAplicativo)}");
        }

        [Then(@"el sistema registrará la boleta del gasto realizado\.")]
        public void ThenElSistemaRegistraraLaBoletaDelGastoRealizado_()
        {
            Console.WriteLine($"{nameof(ThenElSistemaRegistraraLaBoletaDelGastoRealizado_)}");
        }

        [Then(@"enviará una notificación al correo del usuario")]
        public void ThenEnviaraUnaNotificacionAlCorreoDelUsuario()
        {
            Console.WriteLine($"{nameof(ThenEnviaraUnaNotificacionAlCorreoDelUsuario)}");
        }

        [Then(@"se visualizará la boleta del gasto producido en el apartado de “Historial de gastos”")]
        public void ThenSeVisualizaraLaBoletaDelGastoProducidoEnElApartadoDeHistorialDeGastos()
        {
            Console.WriteLine($"{nameof(ThenSeVisualizaraLaBoletaDelGastoProducidoEnElApartadoDeHistorialDeGastos)}");
        }
    }
}