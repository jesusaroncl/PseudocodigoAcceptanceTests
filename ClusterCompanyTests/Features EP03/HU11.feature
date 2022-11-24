Feature: Contar con un monitoreo de los gastos

    Como usuario quiero saber cuánto gasto en cada cosa 
	de mi vida general para organizarme financieramente.

@HU11
Scenario: Usuario que usa la aplicación para monitorear sus gastos
	Given que el usuario registra sus gastos
	When el usuario la emplea para saber en que gasta su dinero
	Then el aplicativo muestra un gráfico que representa como gasta su dinero en diferentes cosas.
