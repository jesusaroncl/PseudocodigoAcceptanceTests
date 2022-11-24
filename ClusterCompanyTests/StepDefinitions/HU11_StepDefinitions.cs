using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU11_StepDefinitions
    {
        [Given(@"que el usuario registra sus gastos")]
        public void GivenQueElUsuarioRegistraSusGastos()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioRegistraSusGastos)}");
        }

        [When(@"el usuario la emplea para saber en que gasta su dinero")]
        public void WhenElUsuarioLaEmpleaParaSaberEnQueGastaSuDinero()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioLaEmpleaParaSaberEnQueGastaSuDinero)}");
        }

        [Then(@"el aplicativo muestra un gráfico que representa como gasta su dinero en diferentes cosas\.")]
        public void ThenElAplicativoMuestraUnGraficoQueRepresentaComoGastaSuDineroEnDiferentesCosas_()
        {
            Console.WriteLine($"{nameof(ThenElAplicativoMuestraUnGraficoQueRepresentaComoGastaSuDineroEnDiferentesCosas_)}");
        }
    }
}