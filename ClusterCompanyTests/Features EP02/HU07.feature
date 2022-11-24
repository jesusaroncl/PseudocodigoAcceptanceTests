Feature: Promoción de marketing
    Como usuario quiero obtener beneficios en el aplicativo para aprovechar 
	las ofertas que ofrece las tiendas asociadas al aplicativo

@HU07
Scenario: Usuario que desea obtener beneficios en el aplicativo
	Given que el usuario quiere aprovechar los beneficios proporcionados por la subscripción del aplicativo
	When el usuario haya realizado la transacción de pago de la subscripción
	And el usuario haya recibido la notificación de “Pago validado”
	Then el sistema ofrecerá un apartado de premium al usuario
	And listará las imágenes con las ofertas de los productos indicando sus proveedores
	And se visualizará dentro del apartado “Subscripción Premium” dentro de la sección de “Información”
