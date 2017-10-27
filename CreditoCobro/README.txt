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
-----------------------------------------------------
URL GitHub:
https://github.com/cavimora/prgr4.git
-----------------------------------------------------
SCRIPT CREACION BASEDEDATOS
CREATE TABLE [B_Institucion] (
  [IdInstitucion] int identity(1,1),
  [Nombre] varchar(25),
  PRIMARY KEY (IdInstitucion)
);

--CREATE INDEX [Key] ON  [B_Institucion] ([IdInstitucion]);

CREATE TABLE [B_Cliente] (
  [IdCliente] varchar(9),
  [Nombre] varchar(18),
  [Apellido1] varchar(18),
  [Apellido2] varchar(18),
  [IdInstitucion] int,
  PRIMARY KEY (IdCliente),
  FOREIGN KEY (IdInstitucion) REFERENCES B_Institucion(IdInstitucion)

);

--CREATE INDEX [Key] ON  [B_Cliente] ([IdCliente]);

--CREATE INDEX [ForeignKey] ON  [B_Cliente] ([IdInstitucion]);

CREATE TABLE [B_Credito] (
  [IdCredito] int,
  [IdCliente] varchar(9),
  [MontoAprobado] decimal(18, 4),
  [Tasa] decimal(18, 4),
  [Plazo] decimal(18, 4),
  PRIMARY KEY (IdCredito),
  FOREIGN KEY (IdCliente) REFERENCES B_Cliente(IdCliente)
);

--CREATE INDEX [Key] ON  [B_Credito] ([IdCredito]);

--CREATE INDEX [ForeignKey] ON  [B_Credito] ([IdCliente]);

CREATE TABLE [B_Proyeccion] (
  [IdCuota] int,
  [IdCredito] int,
  [Principal] decimal(18, 4),
  [Intereses] decimal(18, 4),
  [Saldo] decimal(18, 4),
  [AlDia] bit,
  [Amortiza] decimal(18, 4),
  [FechaCorte] DateTime,
  PRIMARY KEY (IdCredito, IdCuota),
  FOREIGN KEY (IdCredito) REFERENCES B_Credito(IdCredito)
);

--CREATE INDEX [Key] ON  [B_Proyeccion] ([IdCuota], [IdCredito]);

CREATE TABLE [P_Empleado] (
  [IdEmpleado] varchar(9),
  [Nombre] varchar(18),
  [Apellido1] varchar(18),
  [Apellido2] varchar(18),
  PRIMARY KEY (IdEmpleado)
);

--CREATE INDEX [Key] ON  [P_Empleado] ([IdEmpleado]);

CREATE TABLE [P_Cuota] (
  [IdCuota] int,
  [IdEmpleado] varchar(9),
  [IdCredito] int,
  [Principal] decimal(18, 4),
  [Intereses] decimal(18, 4),
  [Saldo] decimal(18, 4),
  [SePago] bit,
  [Amortiza] decimal(18, 4),
  [FechaCorte] DateTime,
  PRIMARY KEY (IdEmpleado, IdCuota, IdCredito),
  FOREIGN KEY (IdEmpleado) REFERENCES P_Empleado(IdEmpleado)
);

--CREATE INDEX [Key] ON  [P_Cuota] ([IdCuota], [IdEmpleado], [IdCredito]);

--
Interfaz de usuario metroframework UI
instalar paquete metroframework UI con NuGet y los controles
--