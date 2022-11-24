Feature: La organización más fácil de comprender.

   Como usuario quiero que la organización de mis gastos sea fácil 
   de comprender para no tener problemas en mis gastos a futuro.

@HU08
Scenario: Usuario que desea visualizar los gastos de manera ordenada
	Given que el usuario ha iniciado sesión
	And se dirige al apartado de “Mis gastos”
	And en el apartado de “Mis gastos” se redirige a la opción “Historial de pagos”
	When el usuario ingresa al apartado de “Historial de pagos”
	Then el sistema muestra en pantalla un filtro de búsqueda
	And habilita el acceso al uso por el usuario.
