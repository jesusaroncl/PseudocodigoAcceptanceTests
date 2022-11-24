using System;
using TechTalk.SpecFlow;

namespace ClusterCompanyTests.StepDefinitions
{
    [Binding]
    public class HU05_StepDefinitions
    {
        [Given(@"que el usuario se encuentre en el apartado de “Mis gastos”")]
        public void GivenQueElUsuarioSeEncuentreEnElApartadoDeMisGastos()
        {
            Console.WriteLine($"{nameof(GivenQueElUsuarioSeEncuentreEnElApartadoDeMisGastos)}");
        }

        [When(@"el usuario haya realizado el mismo gasto de un producto varias veces")]
        public void WhenElUsuarioHayaRealizadoElMismoGastoDeUnProductoVariasVeces()
        {
            Console.WriteLine($"{nameof(WhenElUsuarioHayaRealizadoElMismoGastoDeUnProductoVariasVeces)}");
        }

        [Then(@"el sistema añadirá los primeros cinco gastos más frecuentes en el sector “Gastos frecuentes” dentro del apartado de “Mis Gastos”")]
        public void ThenElSistemaAnadiraLosPrimerosCincoGastosMasFrecuentesEnElSectorGastosFrecuentesDentroDelApartadoDeMisGastos()
        {
            Console.WriteLine($"{nameof(ThenElSistemaAnadiraLosPrimerosCincoGastosMasFrecuentesEnElSectorGastosFrecuentesDentroDelApartadoDeMisGastos)}");
        }

        [Then(@"resaltará en rojo el gasto realizado frecuentemente en el historial general de pagos “Historial de pagos”")]
        public void ThenResaltaraEnRojoElGastoRealizadoFrecuentementeEnElHistorialGeneralDePagosHistorialDePagos()
        {
            Console.WriteLine($"{nameof(ThenResaltaraEnRojoElGastoRealizadoFrecuentementeEnElHistorialGeneralDePagosHistorialDePagos)}");
        }
    }
}