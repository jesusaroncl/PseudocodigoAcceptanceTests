using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU15_StepDefinitions
    {
        [Given(@"que el usuario desea registrar sus operaciones en el aplicativo")]
        public void GivenQueElUsuarioDeseaRegistrarSusOperacionesEnElAplicativo()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioDeseaRegistrarSusOperacionesEnElAplicativo)}");
        }

        [When(@"el usuario revisa los términos y condiciones")]
        public void WhenElUsuarioRevisaLosTerminosYCondiciones()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioRevisaLosTerminosYCondiciones)}");
        }

        [Then(@"el aplicativo proporciona detalladamente los convenios y términos legales que ofrecen garantía y seguridad\.")]
        public void ThenElAplicativoProporcionaDetalladamenteLosConveniosYTerminosLegalesQueOfrecenGarantiaYSeguridad_()
        {
            Console.WriteLine($"{nameof(ThenElAplicativoProporcionaDetalladamenteLosConveniosYTerminosLegalesQueOfrecenGarantiaYSeguridad_)}");
        }
    }
}