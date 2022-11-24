using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU12_StepDefinitions
    {
        [Given(@"que el usuario establece un presupuesto para sus gastos")]
        public void GivenQueElUsuarioEstableceUnPresupuestoParaSusGastos()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioEstableceUnPresupuestoParaSusGastos)}");
        }

        [When(@"la aplicación muestra en que cosas el usuario puede ahorrar su dinero")]
        public void WhenLaAplicacionMuestraEnQueCosasElUsuarioPuedeAhorrarSuDinero()
        {
            Console.WriteLine($"{nameof(WhenLaAplicacionMuestraEnQueCosasElUsuarioPuedeAhorrarSuDinero)}");
        }

        [Then(@"el usuario podrá visualizar el cuadro estadístico de las cosas ahorrativas")]
        public void ThenElUsuarioPodraVisualizarElCuadroEstadisticoDeLasCosasAhorrativas()
        {
            Console.WriteLine($"{nameof(ThenElUsuarioPodraVisualizarElCuadroEstadisticoDeLasCosasAhorrativas)}");
        }
    }
}