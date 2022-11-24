using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU04_StepDefinitions
    {
        [Given(@"haga click en el botón de “Relación familiar”\.")]
        public void GivenHagaClickEnElBotonDeRelacionFamiliar_()
        {
            Console.WriteLine($"{nameof(GivenHagaClickEnElBotonDeRelacionFamiliar_)}");
        }

        [Given(@"dentro de la ventana de relación familiar haga click en el botón “Agregar Miembro”")]
        public void GivenDentroDeLaVentanaDeRelacionFamiliarHagaClickEnElBotonAgregarMiembro()
        {
            Console.WriteLine($"{nameof(GivenDentroDeLaVentanaDeRelacionFamiliarHagaClickEnElBotonAgregarMiembro)}");
        }

        [When(@"el cliente agrega los datos del nuevo miembro")]
        public void WhenElClienteAgregaLosDatosDelNuevoMiembro()
        {
            Console.WriteLine($"{nameof(WhenElClienteAgregaLosDatosDelNuevoMiembro)}");
        }

        [When(@"haga click en el botón “Registrar”")]
        public void WhenHagaClickEnElBotonRegistrar()
        {
            Console.WriteLine($"{nameof(WhenHagaClickEnElBotonRegistrar)}");
        }

        [Then(@"el sistema añadirá los datos del nuevo miembro a la base de datos proporcionada, según la relación familiar del cliente")]
        public void ThenElSistemaAnadiraLosDatosDelNuevoMiembroALaBaseDeDatosProporcionadaSegunLaRelacionFamiliarDelCliente()
        {
            Console.WriteLine($"{nameof(ThenElSistemaAnadiraLosDatosDelNuevoMiembroALaBaseDeDatosProporcionadaSegunLaRelacionFamiliarDelCliente)}");
        }

        [Then(@"redirige al cliente a la interfaz de “Relación Familar”")]
        public void ThenRedirigeAlClienteALaInterfazDeRelacionFamilar()
        {
            Console.WriteLine($"{nameof(ThenRedirigeAlClienteALaInterfazDeRelacionFamilar)}");
        }
    }
}