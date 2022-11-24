using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU01_StepDefinitions
    {
        [Given(@"que el usuario se encuentra en la pantalla de registro\.")]
        public void GivenQueElUsuarioSeEncuentraEnLaPantallaDeRegistro_()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioSeEncuentraEnLaPantallaDeRegistro_)}");
        }

        [When(@"el usuario ingresa sus datos en los cuadros proporcionados y hace click en el botón de “Register”\.")]
        public void WhenElUsuarioIngresaSusDatosEnLosCuadrosProporcionadosYHaceClickEnElBotonDeRegister_()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioIngresaSusDatosEnLosCuadrosProporcionadosYHaceClickEnElBotonDeRegister_)}");
        }

        [Then(@"el sistema insertará los datos del usuario en una base de datos proporcionada\.")]
        public void ThenElSistemaInsertaraLosDatosDelUsuarioEnUnaBaseDeDatosProporcionada_()
        {
            Console.WriteLine($"{nameof(ThenElSistemaInsertaraLosDatosDelUsuarioEnUnaBaseDeDatosProporcionada_)}");
        }

        [Then(@"asigna como cliente a los datos de dicho usuario\.")]
        public void ThenAsignaComoClienteALosDatosDeDichoUsuario_()
        {
            Console.WriteLine($"{nameof(ThenAsignaComoClienteALosDatosDeDichoUsuario_)}");
        }

        [Then(@"redirige al nuevo cliente a la pantalla principal\.")]
        public void ThenRedirigeAlNuevoClienteALaPantallaPrincipal_()
        {
            Console.WriteLine($"{nameof(ThenRedirigeAlNuevoClienteALaPantallaPrincipal_)}");
        }
    }
}