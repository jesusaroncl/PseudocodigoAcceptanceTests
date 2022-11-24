Feature: Gestionar el perfil de usuario

    Como usuario quiero ver gestionar mi perfil en la aplicación 
	para corroborar que mis datos almacenados son los correctos.

@HU09
Scenario: Mostrar la información almacenada mediante el perfil de usuario
	Given que el usuario ha iniciado sesión
	And se dirige al apartado de “Mi perfil de usuario”
	When el usuario ingresa a la sección de información de la cuenta 
	Then el sistema muestra en pantalla los datos del usuario

Scenario: Actualización de datos de usuario
	Given que el usuario ha iniciado sesión
	And se dirige al apartado de “Mi perfil de usuario”
	When el usuario ingresa a la sección de información de la cuenta
	And presiona el botón de “editar perfil” 
	Then el sistema permite ingresar la data actualizada para cada campo del perfil correspondiente a la información personal
