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
            throw new PendingStepException();
        }

        [When(@"el usuario haya realizado el mismo gasto de un producto varias veces")]
        public void WhenElUsuarioHayaRealizadoElMismoGastoDeUnProductoVariasVeces()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema añadirá los primeros cinco gastos más frecuentes en el sector “Gastos frecuentes” dentro del apartado de “Mis Gastos”")]
        public void ThenElSistemaAnadiraLosPrimerosCincoGastosMasFrecuentesEnElSectorGastosFrecuentesDentroDelApartadoDeMisGastos()
        {
            throw new PendingStepException();
        }

        [Then(@"resaltará en rojo el gasto realizado frecuentemente en el historial general de pagos “Historial de pagos”")]
        public void ThenResaltaraEnRojoElGastoRealizadoFrecuentementeEnElHistorialGeneralDePagosHistorialDePagos()
        {
            throw new PendingStepException();
        }
    }
}
