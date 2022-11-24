using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU07_StepDefinitions
    {
        [Given(@"que el usuario quiere aprovechar los beneficios proporcionados por la subscripción del aplicativo")]
        public void GivenQueElUsuarioQuiereAprovecharLosBeneficiosProporcionadosPorLaSubscripcionDelAplicativo()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioQuiereAprovecharLosBeneficiosProporcionadosPorLaSubscripcionDelAplicativo)}");
        }

        [When(@"el usuario haya realizado la transacción de pago de la subscripción")]
        public void WhenElUsuarioHayaRealizadoLaTransaccionDePagoDeLaSubscripcion()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioHayaRealizadoLaTransaccionDePagoDeLaSubscripcion)}");
        }

        [When(@"el usuario haya recibido la notificación de “Pago validado”")]
        public void WhenElUsuarioHayaRecibidoLaNotificacionDePagoValidado()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioHayaRecibidoLaNotificacionDePagoValidado)}");
        }

        [Then(@"el sistema ofrecerá un apartado de premium al usuario")]
        public void ThenElSistemaOfreceraUnApartadoDePremiumAlUsuario()
        {
            Console.WriteLine($"{nameof(ThenElSistemaOfreceraUnApartadoDePremiumAlUsuario)}");
        }

        [Then(@"listará las imágenes con las ofertas de los productos indicando sus proveedores")]
        public void ThenListaraLasImagenesConLasOfertasDeLosProductosIndicandoSusProveedores()
        {
            Console.WriteLine($"{nameof(ThenListaraLasImagenesConLasOfertasDeLosProductosIndicandoSusProveedores)}");
        }

        [Then(@"se visualizará dentro del apartado “Subscripción Premium” dentro de la sección de “Información”")]
        public void ThenSeVisualizaraDentroDelApartadoSubscripcionPremiumDentroDeLaSeccionDeInformacion()
        {
            Console.WriteLine($"{nameof(ThenSeVisualizaraDentroDelApartadoSubscripcionPremiumDentroDeLaSeccionDeInformacion)}");
        }
    }
}