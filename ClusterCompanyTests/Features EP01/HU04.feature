Feature: Registro de miembros en un hogar

    Como cliente del aplicativo, quiero poder registrar a un nuevo miembro de mi hogar
    para actualizar la relación familiar actual.

@HU04
Scenario: Un cliente quiere registrar a un nuevo miembro de su hogar dentro del aplicativo.
	Given que el cliente se encuentre en la pantalla principal de opciones dentro del aplicativo
	And haga click en el botón de “Relación familiar”.
	And dentro de la ventana de relación familiar haga click en el botón “Agregar Miembro”
	When el cliente agrega los datos del nuevo miembro
	And haga click en el botón “Registrar”
	Then el sistema añadirá los datos del nuevo miembro a la base de datos proporcionada, según la relación familiar del cliente 
	And redirige al cliente a la interfaz de “Relación Familar”
