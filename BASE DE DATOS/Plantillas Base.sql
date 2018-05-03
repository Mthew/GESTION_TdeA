CREATE DATABASE Gestion_TdeA
GO

USE Gestion_TdeA
GO

CREATE TABLE TipoDocumento(
	Id int identity(1,1) primary key,
	Codigo varchar(20),
	Nombre varchar(100),
)
GO
CREATE TABLE Paises(
	Id int identity(1,1) primary key,
	Codigo varchar(20),
	Nombre varchar(100),
)
GO
CREATE TABLE Departamentos(
	Id int identity(1,1) primary key,
	IdPais int references Paises(Id),
	Codigo varchar(20),
	Nombre varchar(100),
)
GO
CREATE TABLE Ciudades(
	Id int identity(1,1) primary key,
	IdDepartamento int references Departamentos(Id),
	Codigo varchar(20),
	Nombre varchar(100),
)
GO
CREATE TABLE Personas(
	Id int identity(1,1) primary key,
	IdCiudad int references Ciudades(Id),
	IdTipoDocumento int references TipoDocumento(Id) NOT NULL,
	NumeroDocumento varchar(100) NOT NULL,
	Nombre varchar(200)  NOT NULL,
	SegundoNombre varchar(200),
	Apellido varchar(200) NOT NULL,
	SegundoApellido varchar(200),
	FechaNacimiento smalldatetime,
	Telefono varchar(50),
	Celular varchar(50),
	Email varchar(200),
	Direccion varchar(300),
	Activo bit,
)
GO
CREATE TABLE Usuarios(
	Id int identity(1,1) primary key,
	IdPersona int references Personas(Id),
	Nombre varchar(100),
	Clave nvarchar(200),
	Activo bit,
)
GO
CREATE TABLE Roles(
	Id int identity(1,1) primary key,
	Codigo varchar(50),
	Nombre varchar(100),
)
GO
CREATE TABLE Permisos(
	Id int identity(1,1) primary key,	
	Codigo varchar(50),
	Nombre varchar(100),
)
GO
CREATE TABLE PermisosRol(
	Id int identity(1,1) primary key,
	IdRol int references Roles(Id),
	IdPermiso int references Permisos(Id),
)
GO
CREATE TABLE RolesUsuario(
	Id int identity(1,1) primary key,
	IdUsuario int references Usuarios(Id),
	IdRol int references Roles(Id),
)
GO