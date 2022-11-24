using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU09_StepDefinitions
    {
        [Given(@"se dirige al apartado de “Mi perfil de usuario”")]
        public void GivenSeDirigeAlApartadoDeMiPerfilDeUsuario()
        {
            Console.WriteLine($"{nameof(GivenSeDirigeAlApartadoDeMiPerfilDeUsuario)}");
        }

        [When(@"el usuario ingresa a la sección de información de la cuenta")]
        public void WhenElUsuarioIngresaALaSeccionDeInformacionDeLaCuenta()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioIngresaALaSeccionDeInformacionDeLaCuenta)}");
        }

        [Then(@"el sistema muestra en pantalla los datos del usuario")]
        public void ThenElSistemaMuestraEnPantallaLosDatosDelUsuario()
        {
            Console.WriteLine($"{nameof(ThenElSistemaMuestraEnPantallaLosDatosDelUsuario)}");
        }

        [When(@"presiona el botón de “editar perfil”")]
        public void WhenPresionaElBotonDeEditarPerfil()
        {
            Console.WriteLine($"{nameof(WhenPresionaElBotonDeEditarPerfil)}");
        }

        [Then(@"el sistema permite ingresar la data actualizada para cada campo del perfil correspondiente a la información personal")]
        public void ThenElSistemaPermiteIngresarLaDataActualizadaParaCadaCampoDelPerfilCorrespondienteALaInformacionPersonal()
        {
            Console.WriteLine($"{nameof(ThenElSistemaPermiteIngresarLaDataActualizadaParaCadaCampoDelPerfilCorrespondienteALaInformacionPersonal)}");
        }
    }
}