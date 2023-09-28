/*
descomenta cada unas de las partes una ves compilada volver a comentar con: /*  */
*/

CREATE DATABASE Ordenes_retiro_materiales_114188
GO
USE Ordenes_retiro_materiales_114188
GO
/*1*/
/*
CREATE TABLE Materiales(
	codigo int NOT NULL,
	nombre varchar(100) NOT NULL,
	stock int,
	CONSTRAINT PK_Material PRIMARY KEY (codigo)
)

CREATE TABLE Ordenes_Retiros(
	nroOrden int identity(1,1) NOT NULL,
	fecha datetime NOT NULL,
	responsable varchar(100)
	CONSTRAINT PK_Ordenes_Retiros PRIMARY KEY (nroOrden)
)

CREATE TABLE Detalles_Ordenes(
	nroDetalle int NOT NUll,
	codigo int NOT NULL,
	nroOrden int NOT NULL,
	cantidad int NOT NULL,
	CONSTRAINT PK_Detalles_Ordenes PRIMARY KEY(nroDetalle),
	CONSTRAINT FK_Ordenes_Retiros FOREIGN KEY(nroOrden)
		REFERENCES Ordenes_Retiros (nroOrden),
    CONSTRAINT FK_Materiales FOREIGN KEY(codigo)
		REFERENCES Materiales (codigo)
)
*/
/************ 2 INSERT DE ORDEN RETIRO*******************/
/*INSERT INTO Ordenes_Retiros(fecha,responsable)
					VALUES('1/09/2023','Juan')

/************ 3 INSERT DE Materiales *****************/
INSERT INTO Materiales(codigo,nombre,stock)
		         VALUES(1,'Producto A',999),
						(2,'Producto B',130),
						(3,'Producto C',80)
*/
/************** 4 INSERT DETALLE DE ORDENES *************************/
/*INSERT INTO Detalles_Ordenes(nroDetalle,nroOrden,codigo,cantidad)
						VALUES(1, 1, 1, 10)
*/
/************* 5 SP del Proyecto Ordenes_retiro_materiales_114188 *********************/
/*CREATE PROC PROXIMO_ID
@next int OUTPUT
AS
SET @next=(SELECT MAX(nroOrden)+1 FROM Ordenes_Retiros)
*/
/*CREATE PROC Consultar_Materiales
AS
SELECT * FROM Materiales;*/

/*CREATE PROC SP_INSERTAR_DETALLES
@nroDetalle int,
@nroOrden int,
@codigo int,
@cantidad int
AS
BEGIN
	INSERT INTO	Detalles_Ordenes(nroDetalle,nroOrden,codigo,cantidad)
	                     VALUES(@nroDetalle,@nroOrden,@codigo,@cantidad);
END
*/
/*CREATE PROC SP_INSERTAR_ORDEN
@responsable varchar(255), 
@nro int output
AS
BEGIN
	INSERT INTO Ordenes_Retiros(fecha,responsable)
						VALUES(GETDATE(), @responsable);
	SET @nro = SCOPE_IDENTITY();
END*/
