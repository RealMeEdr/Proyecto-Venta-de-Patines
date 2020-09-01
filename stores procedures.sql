CREATE DATABASE PATINESFINAL

USE PATINESFINAL

CREATE TABLE Empresa(
ID_EMPRESA int identity (1,1) not null,
NOM_EMPRESA VARCHAR(50) NOT NULL,
PAIS VARCHAR(50) NOT NULL,
ICONO IMAGE NOT NULL,
MOD_PATINES VARCHAR(50) NOT NULL,
PUBLICO VARCHAR(50) NOT NULL
)

CREATE TABLE Usuario(
id_usuario int identity (1,1) not null,
nom_usuario varchar(70) not null,
pass varchar(70) not null,
icono image
)


-- REGISTRO DE EMPRESAS
CREATE PROCEDURE NUEV_EMPRESA
@NOM_EMPRESA as VARCHAR(50),
@PAIS varchar (50),
@ICONO IMAGE,
@MOD_PATINES VARCHAR(MAX),
@PUBLICO VARCHAR(100)
AS
IF EXISTS(SELECT NOM_EMPRESA FROM Empresa WHERE NOM_EMPRESA = @NOM_EMPRESA)
RAISERROR('EMPRESA YA EXISTE', 16,1)
ELSE
INSERT INTO Empresa
VALUES( @NOM_EMPRESA, @PAIS, @ICONO, @MOD_PATINES, @PUBLICO)

-- create usuarios
CREATE PROC NUEV_USUARIO
@nom_usuario varchar(70),
@pass varchar(70),
@icono image
as
IF EXISTS(SELECT nom_usuario FROM Usuario where nom_usuario = @nom_usuario)
raiserror('Usuario en existencia', 16,1)
ELSE
insert into Usuario
values(@nom_usuario, @pass, @icono)


--actualizar datos
create proc ACT_EMPRESA
@ID_EMPRESA int,
@NOM_EMPRESA as varchar(MAX),
@PAIS varchar(MAX),
@ICONO image,
@MOD_PATINES varchar(MAX),
@PUBLICO VARCHAR(MAX)
as
if EXISTS(SELECT NOM_EMPRESA from Empresa Where NOM_EMPRESA = @NOM_EMPRESA AND ID_EMPRESA <> @ID_EMPRESA)
RAISERROR('NO SE PUDO ACTUALIZAR LOS DATOS PORQUE EL ID YA ESTÁ EN USO', 16,1)
else
update Empresa set NOM_EMPRESA=@NOM_EMPRESA, PAIS=@PAIS, ICONO=@ICONO, MOD_PATINES=@MOD_PATINES
Where ID_EMPRESA= @ID_EMPRESA


-- inicio de sesión
CREATE PROC INICIO_SESION
@nom_usuario varchar(70),
@pass varchar(70)
as
SELECT nom_usuario, pass FROM Usuario WHERE nom_usuario=@nom_usuario and pass = @pass