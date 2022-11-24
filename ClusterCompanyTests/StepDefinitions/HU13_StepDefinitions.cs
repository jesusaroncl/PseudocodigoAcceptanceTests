using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU13_StepDefinitions
    {
        [Given(@"que el usuario registra sus operaciones en el aplicativo")]
        public void GivenQueElUsuarioRegistraSusOperacionesEnElAplicativo()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioRegistraSusOperacionesEnElAplicativo)}");
        }

        [When(@"el usuario analiza sus operaciones")]
        public void WhenElUsuarioAnalizaSusOperaciones()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioAnalizaSusOperaciones)}");
        }

        [Then(@"el aplicativo proporciona categorías relevantes y frecuentes según sus gastos")]
        public void ThenElAplicativoProporcionaCategoriasRelevantesYFrecuentesSegunSusGastos()
        {
            Console.WriteLine($"{nameof(ThenElAplicativoProporcionaCategoriasRelevantesYFrecuentesSegunSusGastos)}");
        }
    }
}