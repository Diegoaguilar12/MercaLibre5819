CREATE USER IF NOT EXISTS 'userLibre'@'10.120.0.%' identified by 'contrauser';
CREATE USER IF NOT EXISTS 'admin'@'10.120.0.%' identified by 'contraadmin';


Grant insert,select,update(Teléfono, Pass, Email) on Usuario to 'userLibre'@'10.120.0.%';
Grant insert,select,update(precio, Cantidad) on Producto to 'userLibre'@'10.120.0.%';
Grant select,update(Teléfono, Pass, Email) on Usuario to 'admin'@'10.120.0.%';
Grant select on CompraVenta to 'userLibre'@'10.120.0.%';
Grant Delete on CompraVenta to 'admin'@'10.120.0.%';
