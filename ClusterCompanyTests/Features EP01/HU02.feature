Feature: Acceso a una cuenta

    Como cliente dentro de la aplicación quiero poder iniciar sesión 
    en mi cuenta asignada para poder visualizar los registros 
    económicos actuales.

@HU02
Scenario: Un cliente quiere iniciar sesión.
	Given que el cliente se encuentre en la pantalla de inicio de sesión en el aplicativo
	When el cliente ingresa sus datos ya registrados en la base de datos en los cuadros dependiendo la información proporcionada 
	And hace click en el botón de “Login”.
	Then el sistema realizara una consulta a la base de datos asignada
	And verificara la existencia de los datos proporcionados por el cliente
	And redirige al cliente a la pantalla principal del aplicativo dependiendo la cuenta vinculada por un periodo de tiempo.

Scenario: Un usuario quiere iniciar sesión sin haberse registrado en el aplicativo.
	Given que el usuario se encuentre en la pantalla de inicio de sesión en el aplicativo
	When el usuario ingresa sus datos no registrados en los cuadros dependiendo la información proporcionada
	And hace click en el botón de “Login”.
	Then el sistema realizara una consulta a la base de datos asignada
	And verificara que no existen los datos proporcionados por el usuario
	And resaltará un mensaje indicando que los datos proporcionados no son correctos o no están registrados.
