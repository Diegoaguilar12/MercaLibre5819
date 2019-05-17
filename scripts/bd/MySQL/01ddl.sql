Delimiter //
#Punto 1 
create procedure altaUsuario ( unidUsuario smallint,
                               unNombre varchar(45),
					           unApellido varchar(45),
					           unTelefono tinyint,
					           unemail varchar(45),
							   unnombre_usuario varchar(45),
							   unaContraseña_Usuario varchar(45))
begin
insert into Usuario (idUsuario, nombre, apellido, telefono, email, nombre_usuario, contraseña_usuario)
                      values(unidUsuario, unNombre, unApellido,unTelefono,unemail,unNombre_Usuario, unaContraseña_Usuario);

end//




create procedure altaProducto ( unidProducto int,
					            unprecio float ,
								uncantidad int,
					            unnombreProcuto varchar(45),
					            undueñoProducto varchar(45),
					            unafechaPublicacion date)

begin 
insert into Producto (idProducto, precio, cantidad, nombreProducto, dueñoProducto, fechaPublicacion)
		values(unidProducto,unprecio,unacantidad, unnombreProducto ,undueñoProducto, unafechaPublicacion);

end//





                                     
