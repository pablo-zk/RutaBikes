CREATE DATABASE RutaBikesDb
GO
use RutaBikesDb
GO
CREATE TABLE Usuario(
	id int primary key IDENTITY(1,1),
	email varchar(255) not null,
	contrasena varchar(255) not null,
	telefono int not null,
	numCuenta varchar(20) not null,
	monedero float not null
)
GO
CREATE TABLE Estacion(
	id int primary key IDENTITY(1,1),
	ubicacion varchar(255) not null
)
GO
CREATE TABLE Bicicleta(
	id varchar(6) primary key,
)
GO
CREATE TABLE Anclaje(
	idEstacion int not null foreign key references Estacion(id),
	id int primary key not null IDENTITY(1,1),
	idBici varchar(6) foreign key references Bicicleta(id),
)
GO
CREATE TABLE Viaje(
	id int primary key not null IDENTITY(1,1),
	idUser int foreign key references Usuario(id),
	idBici varchar(6) foreign key references Bicicleta(id),
	fechaInicio datetime2,
	fechaFin datetime2 not null,
	idAnclajeIni int foreign key references Anclaje(id),
	idAnclajeFin int foreign key references Anclaje(id),
	precio float not null,
)
GO
CREATE TABLE Tarifa(
	id int primary key IDENTITY(1,1),
	minTiempo int not null,
	maxTiempo int not null,
	precioBase float not null,
)
GO