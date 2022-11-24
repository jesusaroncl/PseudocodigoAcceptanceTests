Feature: Verificar la exactitud de los datos proporcionados por la aplicación

    Como usuario, quiero corroborar la precisión de los datos de la aplicación 
	para ver si esta funciona correctamente.

@HU10
Scenario: Usuario que usa la aplicación para administrar sus gastos
	Given que el usuario baja la aplicación
	When el usuario la utiliza para estimar un gasto aproximado a fin de mes
	Then el aplicativo proporcionara un gasto estimado de acuerdo con sus necesidades.
