using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU10_StepDefinitions
    {
        [Given(@"que el usuario baja la aplicación")]
        public void GivenQueElUsuarioBajaLaAplicacion()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioBajaLaAplicacion)}");
        }

        [When(@"el usuario la utiliza para estimar un gasto aproximado a fin de mes")]
        public void WhenElUsuarioLaUtilizaParaEstimarUnGastoAproximadoAFinDeMes()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioLaUtilizaParaEstimarUnGastoAproximadoAFinDeMes)}");
        }

        [Then(@"el aplicativo proporcionara un gasto estimado de acuerdo con sus necesidades\.")]
        public void ThenElAplicativoProporcionaraUnGastoEstimadoDeAcuerdoConSusNecesidades_()
        {
            Console.WriteLine($"{nameof(ThenElAplicativoProporcionaraUnGastoEstimadoDeAcuerdoConSusNecesidades_)}");
        }
    }
}