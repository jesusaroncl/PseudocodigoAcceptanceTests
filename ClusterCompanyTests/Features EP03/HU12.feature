Feature: Ahorrar dinero 

    Como usuario quiero ahorrar dinero para emplearlo en otras cosas de mi vida.

@HU12
Scenario: Usuario que utiliza la aplicación para saber en qué y cómo ahorrar su dinero
	Given que el usuario establece un presupuesto para sus gastos
	When la aplicación muestra en que cosas el usuario puede ahorrar su dinero
	Then el usuario podrá visualizar el cuadro estadístico de las cosas ahorrativas
