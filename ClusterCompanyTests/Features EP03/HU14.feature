Feature: Generar un resumen de mis gastos

    Como usuario quiero obtener un resumen presupuestal de mis gastos 
	para poder invertir correctamente mi dinero

@HU14
Scenario: Usuario productivo que prefiere visualizar sus gastos a manera de resumen
	Given que el usuario registra sus operaciones en el aplicativo
	When  el usuario obtiene a fin de mes el reporte de sus gastos
	Then el aplicativo proporciona el informe detallado y por fechas de los gastos de sus operaciones.
