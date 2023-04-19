use master
go
IF NOT EXISTS(SELECT name FROM master.dbo.sysdatabases WHERE NAME = 'DBPRUEBAS')
CREATE DATABASE DBPRUEBAS

GO 

USE DBPRUEBAS

GO

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'USUARIO')
create table USUARIO(
IdUsuario int primary key identity(1,1),
DocumentoIdentidad varchar(60),
Nombres varchar(60),
Telefono varchar(60),
Correo varchar(60),
Ciudad varchar(60),
FechaRegistro datetime default getdate()
)

go

select * from dbo.USUARIO