using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU14_StepDefinitions
    {
        [When(@"el usuario obtiene a fin de mes el reporte de sus gastos")]
        public void WhenElUsuarioObtieneAFinDeMesElReporteDeSusGastos()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioObtieneAFinDeMesElReporteDeSusGastos)}");
        }

        [Then(@"el aplicativo proporciona el informe detallado y por fechas de los gastos de sus operaciones\.")]
        public void ThenElAplicativoProporcionaElInformeDetalladoYPorFechasDeLosGastosDeSusOperaciones_()
        {
            Console.WriteLine($"{nameof(ThenElAplicativoProporcionaElInformeDetalladoYPorFechasDeLosGastosDeSusOperaciones_)}");
        }
    }
}