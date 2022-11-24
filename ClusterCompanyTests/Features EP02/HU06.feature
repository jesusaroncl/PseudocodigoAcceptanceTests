Feature: Obtención de información validada.

    Como usuario quiero que la información de mis boletas sea validada 
	para estar seguro de que mis gastos son los debidos.

@HU06
Scenario: Usuario que desea no perder su información de los gastos realizados.
	Given que el usuario quiere validar la información de sus gastos
	When el usuario realiza un gasto online o presencial.
	And el usuario haya registrado su gasto en el aplicativo
	Then el sistema registrará la boleta del gasto realizado.
	And enviará una notificación al correo del usuario
	And se visualizará la boleta del gasto producido en el apartado de “Historial de gastos”
