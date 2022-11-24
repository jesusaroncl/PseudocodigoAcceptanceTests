Feature: Categorizar los gastos

    Como usuario quiero comprobar si puedo organizar mis gastos 
	según categorías personalizadas para poder proyectar mis operaciones

@HU13
Scenario: Usuario que registra sus gastos en el aplicativo por categorías de consumo.
	Given que el usuario registra sus operaciones en el aplicativo
	When el usuario analiza sus operaciones
	Then el aplicativo proporciona categorías relevantes y frecuentes según sus gastos
