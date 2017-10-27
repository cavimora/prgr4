-----------------------------------------------------
Creacion del login en el servidor:
CREATE LOGIN carlosdb 
	WITH PASSWORD = 'Carlos2017!' 
GO
-----------------------------------------------------
Asignacion del usuario a la base de datos:
CREATE USER carlosdb FOR LOGIN carlosdb;  
GO  
-----------------------------------------------------
Asignacion de Rol en la base de datos:
EXEC sp_addrolemember N'db_owner', N'carlosdb' 
-----------------------------------------------------
Usuario de la base de datos:
carlosdb - Carlos2017!
danieldb - Daniel2017!
javierdb - Javier2017!
josuedb - Josue2017!
-----------------------------------------------------
String de conexion:
Server=tcp:creditocobro.database.windows.net,1433;Initial Catalog=creditocobro;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
-----------------------------------------------------
Usuario Admin
ccadmin - Admin2017!