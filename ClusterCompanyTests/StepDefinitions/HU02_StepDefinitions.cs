using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU02_StepDefinitions
    {
        [Given(@"que el cliente se encuentre en la pantalla de inicio de sesión en el aplicativo")]
        public void GivenQueElClienteSeEncuentreEnLaPantallaDeInicioDeSesionEnElAplicativo()
        {
            Console.WriteLine($"{nameof(GivenQueElClienteSeEncuentreEnLaPantallaDeInicioDeSesionEnElAplicativo)}");
        }

        [When(@"el cliente ingresa sus datos ya registrados en la base de datos en los cuadros dependiendo la información proporcionada")]
        public void WhenElClienteIngresaSusDatosYaRegistradosEnLaBaseDeDatosEnLosCuadrosDependiendoLaInformacionProporcionada()
        {
            Console.WriteLine($"{nameof(WhenElClienteIngresaSusDatosYaRegistradosEnLaBaseDeDatosEnLosCuadrosDependiendoLaInformacionProporcionada)}");
        }

        [When(@"hace click en el botón de “Login”\.")]
        public void WhenHaceClickEnElBotonDeLogin_()
        {
            Console.WriteLine($"{nameof(WhenHaceClickEnElBotonDeLogin_)}");
        }

        [Then(@"el sistema realizara una consulta a la base de datos asignada")]
        public void ThenElSistemaRealizaraUnaConsultaALaBaseDeDatosAsignada()
        {
            Console.WriteLine($"{nameof(ThenElSistemaRealizaraUnaConsultaALaBaseDeDatosAsignada)}");
        }

        [Then(@"verificara la existencia de los datos proporcionados por el cliente")]
        public void ThenVerificaraLaExistenciaDeLosDatosProporcionadosPorElCliente()
        {
            Console.WriteLine($"{nameof(ThenVerificaraLaExistenciaDeLosDatosProporcionadosPorElCliente)}");
        }

        [Then(@"redirige al cliente a la pantalla principal del aplicativo dependiendo la cuenta vinculada por un periodo de tiempo\.")]
        public void ThenRedirigeAlClienteALaPantallaPrincipalDelAplicativoDependiendoLaCuentaVinculadaPorUnPeriodoDeTiempo_()
        {
            Console.WriteLine($"{nameof(ThenRedirigeAlClienteALaPantallaPrincipalDelAplicativoDependiendoLaCuentaVinculadaPorUnPeriodoDeTiempo_)}");
        }

        [Given(@"que el usuario se encuentre en la pantalla de inicio de sesión en el aplicativo")]
        public void GivenQueElUsuarioSeEncuentreEnLaPantallaDeInicioDeSesionEnElAplicativo()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioSeEncuentreEnLaPantallaDeInicioDeSesionEnElAplicativo)}");
        }

        [When(@"el usuario ingresa sus datos no registrados en los cuadros dependiendo la información proporcionada")]
        public void WhenElUsuarioIngresaSusDatosNoRegistradosEnLosCuadrosDependiendoLaInformacionProporcionada()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioIngresaSusDatosNoRegistradosEnLosCuadrosDependiendoLaInformacionProporcionada)}");
        }

        [Then(@"verificara que no existen los datos proporcionados por el usuario")]
        public void ThenVerificaraQueNoExistenLosDatosProporcionadosPorElUsuario()
        {
            Console.WriteLine($"{nameof(ThenVerificaraQueNoExistenLosDatosProporcionadosPorElUsuario)}");
        }

        [Then(@"resaltará un mensaje indicando que los datos proporcionados no son correctos o no están registrados\.")]
        public void ThenResaltaraUnMensajeIndicandoQueLosDatosProporcionadosNoSonCorrectosONoEstanRegistrados_()
        {
            Console.WriteLine($"{nameof(ThenResaltaraUnMensajeIndicandoQueLosDatosProporcionadosNoSonCorrectosONoEstanRegistrados_)}");
        }
    }
}