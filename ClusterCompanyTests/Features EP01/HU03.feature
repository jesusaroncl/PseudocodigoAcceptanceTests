Feature: Modificar interfaz

    Como cliente del aplicativo, quiero poder personalizar a mi gusto
    la interfaz del aplicativo para resaltar las opciones más
    importantes según mi agrado.

@HU03
Scenario: Un cliente quiere personalizar a su gusto la interfaz del aplicativo.
	Given que el cliente se encuentre en la pantalla principal de opciones dentro del aplicativo
	And haga click en el botón de “Modificar interfaz”.
	When el cliente modifica la interfaz del aplicativo
	And haga click en el botón “Guardar”
	Then el sistema modificará la posición de los componentes de la interfaz 
	And verificará que no se haya modificado los componentes restringidos que proporciona el aplicativo
	And redirige al cliente a su nueva interfaz personalizada.
