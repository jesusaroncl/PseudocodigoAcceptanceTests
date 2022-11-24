using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU08_StepDefinitions
    {
        [Given(@"que el usuario ha iniciado sesión")]
        public void GivenQueElUsuarioHaIniciadoSesion()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioHaIniciadoSesion)}");
        }

        [Given(@"se dirige al apartado de “Mis gastos”")]
        public void GivenSeDirigeAlApartadoDeMisGastos()
        {
            Console.WriteLine($"{nameof(GivenSeDirigeAlApartadoDeMisGastos)}");
        }

        [Given(@"en el apartado de “Mis gastos” se redirige a la opción “Historial de pagos”")]
        public void GivenEnElApartadoDeMisGastosSeRedirigeALaOpcionHistorialDePagos()
        {
            Console.WriteLine($"{nameof(GivenEnElApartadoDeMisGastosSeRedirigeALaOpcionHistorialDePagos)}");
        }

        [When(@"el usuario ingresa al apartado de “Historial de pagos”")]
        public void WhenElUsuarioIngresaAlApartadoDeHistorialDePagos()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioIngresaAlApartadoDeHistorialDePagos)}");
        }

        [Then(@"el sistema muestra en pantalla un filtro de búsqueda")]
        public void ThenElSistemaMuestraEnPantallaUnFiltroDeBusqueda()
        {
            Console.WriteLine($"{nameof(ThenElSistemaMuestraEnPantallaUnFiltroDeBusqueda)}");
        }

        [Then(@"habilita el acceso al uso por el usuario\.")]
        public void ThenHabilitaElAccesoAlUsoPorElUsuario_()
        {
            Console.WriteLine($"{nameof(ThenHabilitaElAccesoAlUsoPorElUsuario_)}");
        }
    }
}