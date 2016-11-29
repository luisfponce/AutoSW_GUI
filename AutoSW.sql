CREATE DATABASE AutoSW
USE AutoSW

--############ PROCEDIMIENTOS ALMACENADO ##########
ALTER PROCEDURE ShowAllContactsAToZ
AS
SELECT P.IdPersona, P.Nombre, P.ApellidoPaterno, P.ApellidoMaterno, C.Email FROM Personas P
INNER JOIN Contactos C ON C.IdPersona = P.IdPersona
ORDER BY P.Nombre ASC
GO

ALTER PROCEDURE ShowAllContactsNameCoincidence
@contactName varchar(50)
As
SELECT P.IdPersona, P.Nombre, P.ApellidoPaterno, P.ApellidoMaterno, C.Email FROM Personas P
INNER JOIN Contactos C ON C.IdPersona = P.IdPersona
WHERE P.Nombre LIKE @contactName OR P.Nombre LIKE '%'+ @contactName +'%' OR P.Nombre LIKE @contactName+'%'
OR P.Nombre LIKE '%'+@contactName
GO

ALTER PROCEDURE ShowAllContactsAPCoincidence
@contactAP varchar(50)
As
SELECT P.IdPersona, P.Nombre, P.ApellidoPaterno, P.ApellidoMaterno, C.Email FROM Personas P
INNER JOIN Contactos C ON C.IdPersona = P.IdPersona
WHERE P.ApellidoPaterno LIKE @contactAP OR P.ApellidoPaterno LIKE '%'+ @contactAP +'%' OR P.ApellidoPaterno LIKE @contactAP+'%'
OR P.ApellidoPaterno LIKE '%'+@contactAP
GO

ALTER PROCEDURE ShowAllContactsAMCoincidence
@contactAM varchar(50)
As
SELECT P.IdPersona, P.Nombre, P.ApellidoPaterno, P.ApellidoMaterno, C.Email FROM Personas P
INNER JOIN Contactos C ON C.IdPersona = P.IdPersona
WHERE P.ApellidoMaterno LIKE @contactAM OR P.ApellidoMaterno LIKE '%'+ @contactAM +'%' OR P.ApellidoMaterno LIKE @contactAM+'%'
OR P.ApellidoMaterno LIKE '%'+@contactAM
GO


ALTER PROCEDURE ShowAllContactsEmailCoincidence
@theEmail varchar(50)
As
SELECT P.IdPersona, P.Nombre, P.ApellidoPaterno, P.ApellidoMaterno, C.Email FROM Contactos C
INNER JOIN Personas P ON C.IdPersona = P.IdPersona
WHERE C.Email LIKE @theEmail OR C.Email LIKE '%'+ @theEmail +'%' OR C.Email LIKE @theEmail+'%'
OR C.Email LIKE '%'+@theEmail
GO

CREATE PROCEDURE InsertNewContact
@name varchar(50), @firstLastName varchar(50), 
@secondLastName varchar(50), @email varchar(50)
AS
BEGIN TRAN insertNewContact 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
DECLARE @ID INT 
BEGIN 
INSERT Personas(Nombre, ApellidoPaterno, ApellidoMaterno) VALUES (@name, @firstLastName, @secondLastName)
SET @ID = SCOPE_IDENTITY()
INSERT Contactos(IdPersona, Email) VALUES (@ID, @email)
END
COMMIT TRAN insertNewContact 
GO

CREATE PROCEDURE UpdateContact
@name varchar(50), @firstLastName varchar(50), 
@secondLastName varchar(50), @email varchar(50),
@IdPersona INT
AS
BEGIN TRAN insertNewContact 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN 
UPDATE Personas
SET Nombre = @name, ApellidoPaterno = @firstLastName, ApellidoMaterno = @secondLastName
WHERE
IdPersona = @IdPersona
UPDATE Contactos
SET Email = @email 
WHERE
IdPersona = @IdPersona
END
COMMIT TRAN insertNewContact 
GO

ALTER PROCEDURE ShowLatestConfig
AS
BEGIN TRAN getlatestIDconf 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
DECLARE @ID INT 
BEGIN  
SET @ID = (SELECT MAX(IdConfiguracion) FROM Configuraciones)
SELECT Con.Modalidad, Con.Periodicidad, Con.FechaConfiguracion, U.Celular, U.CodigoPostal, Con.IdPersona, Con.IdUsuario, P.Nombre, P.ApellidoPaterno, P.ApellidoMaterno FROM Personas P
INNER JOIN Configuraciones Con ON Con.IdPersona = P.IdPersona
INNER JOIN Usuarios U ON U.IdPersona = P.IdPersona
WHERE Con.IdConfiguracion = @ID 
END
COMMIT TRAN getlatestIDconf 
GO

ALTER PROCEDURE InsertNewConfig
@modalidad BIT, @periodicidad INT, 
@idPersona INT, @idUsuario INT
AS
BEGIN TRAN NewConfig 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
DECLARE @ID INT 
BEGIN  
SET @ID = (SELECT MAX(IdConfiguracion) FROM Configuraciones)+1
INSERT Configuraciones(IdConfiguracion,Modalidad, Periodicidad, FechaConfiguracion, IdPersona, IdUsuario) 
VALUES (@ID, @modalidad, @periodicidad, SYSDATETIME(), @idPersona, @idUsuario) 
END
COMMIT TRAN NewConfig 
GO

CREATE PROCEDURE ShowLatestMailingInfo
AS
BEGIN TRAN getlatestIDmailing 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
DECLARE @ID INT 
BEGIN  
SET @ID = (SELECT MAX(IdEnvio) FROM Envios)
SELECT E.CantidadContactos, E.CantidadArchivos, E.TamanioArchivos, E.IdConfiguracion, Con.IdPersona, Con.IdUsuario, P.Nombre, P.ApellidoPaterno, U.CodigoPostal FROM Envios E
INNER JOIN Configuraciones Con ON Con.IdConfiguracion = E.IdConfiguracion
INNER JOIN Usuarios U ON U.IdUsuario = Con.IdUsuario
INNER JOIN Personas P ON P.IdPersona = U.IdPersona
WHERE E.IdEnvio = @ID 
END
COMMIT TRAN getlatestIDmailing  
GO

CREATE PROCEDURE InsertNewMailingInfo
@CantidadContactos INT, @CantidadArchivos INT, 
@TamanioArchivos FLOAT
AS
BEGIN TRAN InsertConfig 
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
DECLARE @IDconfig INT 
BEGIN  
SET @IDconfig = (SELECT MAX(IdConfiguracion) FROM Configuraciones)
INSERT Envios(CantidadContactos, CantidadArchivos, TamanioArchivos, IdConfiguracion) 
VALUES (@CantidadContactos, @CantidadArchivos, @TamanioArchivos, @IDconfig) 
END
COMMIT TRAN InsertConfig 
GO

ALTER PROCEDURE ShowAllMailingInfo
AS
SELECT E.CantidadContactos'No.Contactos', E.CantidadArchivos AS 'Cant Archivos Adjuntos', E.TamanioArchivos AS 'Tamaño Archivos MB', P.Nombre AS 'Configurado Por', P.ApellidoPaterno FROM Envios E
INNER JOIN Configuraciones Con ON Con.IdConfiguracion = E.IdConfiguracion
INNER JOIN Usuarios U ON U.IdUsuario = Con.IdUsuario
INNER JOIN Personas P ON P.IdPersona = U.IdPersona  
GO

EXECUTE ShowAllContactsAToZ
EXECUTE ShowAllContactsNameCoincidence 'Luis'
EXECUTE ShowAllContactsAPCoincidence 'Marmol'
EXECUTE ShowAllContactsAMCoincidence 'Carrillo'
EXECUTE ShowAllContactsEmailCoincidence 'fabiola'
EXECUTE InsertNewContact 'Pedro', 'Pica', 'Piedras', 'Picapiedras@autosw.com'
EXECUTE UpdateContact 'Pablo', 'Marmol', 'Piedras', 'Marmolpiedras@autosw.com', 20

EXECUTE ShowLatestConfig
EXECUTE InsertNewConfig 1, 15, 2, 2

EXECUTE ShowLatestMailingInfo
EXECUTE InsertNewMailingInfo 8, 3, 14.5
EXECUTE ShowAllMailingInfo

--SQL authentication account for database ownership
ALTER AUTHORIZATION ON DATABASE::AutoSW TO [sa];

--############Personas Table############
SELECT *FROM Personas
DROP TABLE Personas

CREATE TABLE Personas(
IdPersona INT not null IDENTITY (1,1)PRIMARY KEY,
Nombre VARCHAR (50),
ApellidoPaterno VARCHAR (50),
ApellidoMaterno VARCHAR (50)
)


INSERT Personas
VALUES ('Luis','Ponce','Navarro')
INSERT Personas
VALUES ('Jose','Castillo','Juarez')
INSERT Personas
VALUES ('Miguel','Rodriguez','Fernandez')
INSERT Personas
VALUES ('Victor','Hernandez','Delgado')
INSERT Personas
VALUES ('Elizabeth','Paredes','Hernandez')
INSERT Personas
VALUES ('Luis','Perez','Perez')
INSERT Personas
VALUES ('Aharon','Martinez','Garcia')		
INSERT Personas
VALUES ('Angel','Acevedo','Carrillo')		
INSERT Personas
VALUES ('Rigoberto','Siordia','Oceguera')		
INSERT Personas
VALUES ('Juan','Gomez','Gomez')		
INSERT Personas
VALUES ('Rocio','Garcia','Hernandez')		
INSERT Personas
VALUES ('Abraham','Pulido','Ramirez')		
INSERT Personas
VALUES ('Fabiola','Gonzalez','Navarro')		
INSERT Personas
VALUES ('Liliana','Pena','Avalos')		
INSERT Personas
VALUES ('Ivan','Gutierrez','Campos')		
INSERT Personas
VALUES ('Saul','Garcia','Varela')		
INSERT Personas
VALUES ('Fernando','Luna','Camacho')		
INSERT Personas
VALUES ('Rosa','Rodriguez','Curiel')		
INSERT Personas
VALUES ('Myriam','Altamirano','Guzman')	


--############Contactos Table############
SELECT *FROM Contactos 
DROP TABLE Contactos

CREATE TABLE Contactos(
IdPersona INT,
IdContacto INT not null IDENTITY (1,1),
PRIMARY KEY (IdPersona,IdContacto),
Email VARCHAR (50)
)

INSERT Contactos
VALUES (6,'Luis@autosw.com')
INSERT Contactos
VALUES (7,'Aharon@autosw.com')
INSERT Contactos
VALUES (8,'Angel@autosw.com')
INSERT Contactos
VALUES (9,'Rigoberto@autosw.com')
INSERT Contactos
VALUES (10,'Juan@autosw.com')
INSERT Contactos
VALUES (11,'Rocio@autosw.com')
INSERT Contactos
VALUES (12,'Abraham@autosw.com')
INSERT Contactos
VALUES (13,'Fabiola@autosw.com')
INSERT Contactos
VALUES (14,'Liliana@autosw.com')
INSERT Contactos
VALUES (15,'Ivan@autosw.com')
INSERT Contactos
VALUES (16,'Saul@autosw.com')
INSERT Contactos
VALUES (17,'Fernando@autosw.com')
INSERT Contactos
VALUES (18,'Rosa@autosw.com')
INSERT Contactos
VALUES (19,'Myriam@autosw.com')


--############Usuarios Table############
SELECT* FROM Usuarios
DROP TABLE Usuarios

CREATE TABLE Usuarios(
IdPersona INT,
IdUsuario INT not null IDENTITY (1,1),
PRIMARY KEY (IdPersona,IdUsuario),
Calle VARCHAR (50),
Numero VARCHAR (20),
CodigoPostal INT,
Celular VARCHAR (20)
)

INSERT Usuarios
VALUES (1,'Mariano Otero','175',45650,'')	
INSERT Usuarios
VALUES (2,'Aquiles Serdan','230',45667,'3322110014')	
INSERT Usuarios
VALUES (3,'Antonio Ramirez','1',45000,'3310987654')
INSERT Usuarios
VALUES (4,'Lopez Mateos','3600',44324,'')	
INSERT Usuarios
VALUES (5,'Circuito Canada','45',45650,'3312569876')


--############Operadores Table############
SELECT* FROM Operadores
DROP TABLE Operadores

CREATE TABLE Operadores(
IdPersona INT,
IdUsuario INT,
PRIMARY KEY (IdPersona,IdUsuario),
PrivilegioO INT
)

INSERT Operadores
VALUES (4,4,1)
INSERT Operadores
VALUES (5,5,1)


--############Publicistas Table############
SELECT *FROM Publicistas
DROP TABLE Publicistas

CREATE TABLE Publicistas(
IdPersona INT,
IdUsuario INT,
PRIMARY KEY (IdPersona,IdUsuario),
PrivilegioP INT
)

INSERT Publicistas
VALUES (2,2,2)
INSERT Publicistas
VALUES (3,3,2)


--############Administradores Table############
SELECT *FROM Administradores
DROP TABLE Administradores

CREATE TABLE Administradores(
IdPersona INT,
IdUsuario INT,
PRIMARY KEY (IdPersona,IdUsuario),
PrivilegioA INT
)


INSERT Administradores
VALUES (1,1,3)

--############Envios Table############
SELECT *FROM Envios
DROP TABLE Envios

CREATE TABLE Envios(
IdEnvio INT not null IDENTITY (1,1)PRIMARY KEY,
CantidadContactos INT,
CantidadArchivos INT,
TamanioArchivos FLOAT,
IdConfiguracion INT,
)

INSERT Envios
VALUES (6,2,5.8,1)
INSERT Envios
VALUES (6,2,5,1)
INSERT Envios
VALUES (6,2,4.99,1)
INSERT Envios
VALUES (6,3,8.7,1)
INSERT Envios
VALUES (6,3,9.8,1)
INSERT Envios
VALUES (6,5,9.99,1)
INSERT Envios
VALUES (9,3,8.4,2)
INSERT Envios
VALUES (12,3,9.2,2)
INSERT Envios
VALUES (12,1,2.7,3)
INSERT Envios
VALUES (12,1,3.2,3)
INSERT Envios
VALUES (13,1,3.4,3)
INSERT Envios
VALUES (13,3,14.6,4)
INSERT Envios
VALUES (14,3,9.3,4)


--############Detalle_Envios Table############
SELECT *FROM Detalle_Envios
DROP TABLE Detalle_Envios
SELECT *FROM Envios,Contactos

CREATE TABLE Detalle_Envios(
IdContacto INT,
IdEnvio INT,
FechaEnvio DATE,
PRIMARY KEY(IdContacto,IdEnvio,FechaEnvio),
HoraEnvio TIME
)


INSERT Detalle_Envios
VALUES (1,1,'2016-01-16', '09:50')
INSERT Detalle_Envios
VALUES (2,1,'2016-01-16', '09:50')
INSERT Detalle_Envios
VALUES (3,1,'2016-01-16', '09:50')
INSERT Detalle_Envios
VALUES (4,1,'2016-01-16', '09:50')
INSERT Detalle_Envios
VALUES (5,1,'2016-01-16', '09:50')
INSERT Detalle_Envios
VALUES (6,1,'2016-01-16', '09:50')
INSERT Detalle_Envios
VALUES (1,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (2,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (3,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (4,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (5,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (6,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (7,2,'2016-01-23', '10:00')
INSERT Detalle_Envios
VALUES (8,2,'2016-01-23', '10:00')


--############Configuraciones Table############
SELECT *FROM Configuraciones
DROP TABLE Configuraciones

ALTER TABLE Configuraciones CHECK CONSTRAINT ALL
ALTER TABLE Usuarios CHECK CONSTRAINT ALL

--The following 4 stepd are only examples, I used but the CREATE table was fixed and doesn't need those steps.
--Rename a Column: EXEC sp_rename 'Configuraciones.IdUsuari','IdUsuario'
--Drop a Column: ALTER TABLE Configuraciones DROP COLUMN IdUsuario
--ADD a Column: ALTER TABLE Configuraciones ADD IdUsuari INT
--Update a Table already created: UPDATE Configuraciones set IdUsuario=3 WHERE IdConfiguracion=4


CREATE TABLE Configuraciones(
IdConfiguracion INT not null IDENTITY (1,1)PRIMARY KEY,
Modalidad BIT,
Periodicidad INT,
FechaConfiguracion DATE,
IdPersona INT,
IdUsuario INT
)

INSERT Configuraciones
VALUES (1,1,1,'2016-01-16',1,1)
INSERT Configuraciones
VALUES (2,1,2,'2016-02-16',1,1)
INSERT Configuraciones
VALUES (3,1,3,'2016-03-16',2,2)
INSERT Configuraciones
VALUES (4,1,4,'2016-04-16',3,3)

--############Assign FOREIGN KEYS ############
ALTER TABLE Envios ADD CONSTRAINT FK_Envios_IdConfiguracion FOREIGN KEY (IdConfiguracion) 
REFERENCES Configuraciones (IdConfiguracion)

ALTER TABLE Configuraciones ADD CONSTRAINT FK_Configuraciones_IdUsuario FOREIGN KEY (IdPersona,IdUsuario)
REFERENCES Usuarios (IdPersona,IdUsuario)





--#################################################--
--Store Procedures--




