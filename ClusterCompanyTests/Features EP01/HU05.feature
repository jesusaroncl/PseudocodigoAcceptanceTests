Feature: Registro de gastos frecuentes.

    Como visitante de la aplicación quiero tener un registro de gastos frecuentes 
	para tomarlo en cuenta en los gastos del próximo mes

@HU05
Scenario: Usuario que desea visualizar un registro de gastos frecuentes. 
	Given que el usuario se encuentre en el apartado de “Mis gastos” 
	When el usuario haya realizado el mismo gasto de un producto varias veces
	Then el sistema añadirá los primeros cinco gastos más frecuentes en el sector “Gastos frecuentes” dentro del apartado de “Mis Gastos”
	And resaltará en rojo el gasto realizado frecuentemente en el historial general de pagos “Historial de pagos”
