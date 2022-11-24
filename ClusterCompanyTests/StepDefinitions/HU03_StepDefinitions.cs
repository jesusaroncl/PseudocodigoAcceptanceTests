using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU03_StepDefinitions
    {
        [Given(@"que el cliente se encuentre en la pantalla principal de opciones dentro del aplicativo")]
        public void GivenQueElClienteSeEncuentreEnLaPantallaPrincipalDeOpcionesDentroDelAplicativo()
        {
            Console.WriteLine($"{nameof(GivenQueElClienteSeEncuentreEnLaPantallaPrincipalDeOpcionesDentroDelAplicativo)}");
        }

        [Given(@"haga click en el botón de “Modificar interfaz”\.")]
        public void GivenHagaClickEnElBotonDeModificarInterfaz_()
        {
            Console.WriteLine($"{nameof(GivenHagaClickEnElBotonDeModificarInterfaz_)}");
        }

        [When(@"el cliente modifica la interfaz del aplicativo")]
        public void WhenElClienteModificaLaInterfazDelAplicativo()
        {
            Console.WriteLine($"{nameof(WhenElClienteModificaLaInterfazDelAplicativo)}");
        }

        [When(@"haga click en el botón “Guardar”")]
        public void WhenHagaClickEnElBotonGuardar()
        {
            Console.WriteLine($"{nameof(WhenHagaClickEnElBotonGuardar)}");
        }

        [Then(@"el sistema modificará la posición de los componentes de la interfaz")]
        public void ThenElSistemaModificaraLaPosicionDeLosComponentesDeLaInterfaz()
        {
            Console.WriteLine($"{nameof(ThenElSistemaModificaraLaPosicionDeLosComponentesDeLaInterfaz)}");
        }

        [Then(@"verificará que no se haya modificado los componentes restringidos que proporciona el aplicativo")]
        public void ThenVerificaraQueNoSeHayaModificadoLosComponentesRestringidosQueProporcionaElAplicativo()
        {
            Console.WriteLine($"{nameof(ThenVerificaraQueNoSeHayaModificadoLosComponentesRestringidosQueProporcionaElAplicativo)}");
        }

        [Then(@"redirige al cliente a su nueva interfaz personalizada\.")]
        public void ThenRedirigeAlClienteASuNuevaInterfazPersonalizada_()
        {
            Console.WriteLine($"{nameof(ThenRedirigeAlClienteASuNuevaInterfazPersonalizada_)}");
        }
    }
}