delimiter //
#punto2

CREATE FUNCTION  recaudacionPara (unidProducto int,
			                      cotainf datetime,
                                  cotasup datetime)
								  returns float
begin 
      declare suma_recaudado float;
      Select Sum(PrecioCompra) into suma_recaudado
      from Compra
      where idProducto = unidProducto 
      and fechaHora between cotainf and cotasup;
      return suma_recaudado;
end//
      