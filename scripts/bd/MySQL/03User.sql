create user userLibre @'%' identified by 'contrauser';
create user admin @'%' identified by 'contraadmin';

Grant select, update(teléfono, contraseña, email) on Usuario to 'usuarioLibre'@'%';
Grant select,update(precio, cantidad) on Producto to 'usuarioLibre'@'%';
Grant select,update(teléfono, contraseña, email) on Usuario to 'admin'@'10.120.0.%';
Grant select on CompraVenta to 'usuarioLibre'@'%';
Grant Delete on CompraVenta to 'admin'@'10.120.0.%.';
