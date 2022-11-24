Feature: Registrar la información del usuario

    Como visitante de la aplicación quiero poder registrar
    una nueva cuenta incluyendo toda mi información para
    acceder a todas las opciones disponibles que proporciona el aplicativo

@HU01
Scenario: El Usuario quiere registrarse como cliente
	Given que el usuario se encuentra en la pantalla de registro.
	When el usuario ingresa sus datos en los cuadros proporcionados y hace click en el botón de “Register”.
	Then el sistema insertará los datos del usuario en una base de datos proporcionada.
	And asigna como cliente a los datos de dicho usuario.
	And redirige al nuevo cliente a la pantalla principal.
