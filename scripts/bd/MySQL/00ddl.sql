Create database MercaLibre5819;

USE MercaLibre5819;

SET FOREIGN_KEY_CHECKS=0;




CREATE TABLE Compra
(
	idCompra INTEGER NOT NULL,
	idProducto INTEGER NOT NULL,
	idUsuario INTEGER NOT NULL,
	fechaHora DATETIME NOT NULL,
	CantUnidades TINYINT NOT NULL,
	PrecioCompra FLOAT(0) NOT NULL,
	PRIMARY KEY (idCompra),
	KEY (idUsuario),
	KEY (idProducto)
) 
;


CREATE TABLE Producto
(
	idProducto INTEGER NOT NULL,
	precio FLOAT(0) NOT NULL,
	cantidad INTEGER NOT NULL,
	nombreProducto VARCHAR(45) NOT NULL,
	idVendedor  INTEGER NOT NULL,
	fechaPublicacion DATE NOT NULL,
	PRIMARY KEY (idProducto),
	KEY (idVendedor )
) 
;


CREATE TABLE Usuario 
(
	idUsuario INTEGER NOT NULL,
	nombre VARCHAR(45) NOT NULL,
	apellido VARCHAR(45) NOT NULL,
	telefono TINYINT NOT NULL,
	email VARCHAR(45) NOT NULL,
	nombre_usuario VARCHAR(45) NOT NULL,
	contrasena_usuario VARCHAR(45) NOT NULL,
	PRIMARY KEY (idUsuario),
	UNIQUE UQ_Clientes_email(email),
	UNIQUE UQ_Clientes_nombre_usuario(nombre_usuario),
	UNIQUE UQ_Clientes_telefono(telefono)
) 
;



SET FOREIGN_KEY_CHECKS=1;


ALTER TABLE Compra ADD CONSTRAINT FK_Compra_Clientes  
	FOREIGN KEY (idUsuario) REFERENCES Usuario  (idUsuario)
;

ALTER TABLE Compra ADD CONSTRAINT FK_Compra_Producto 
	FOREIGN KEY (idProducto) REFERENCES Producto (idProducto)
;

ALTER TABLE Producto ADD CONSTRAINT FK_Producto_Usuario  
	FOREIGN KEY (idVendedor ) REFERENCES Usuario  (idUsuario)
;
