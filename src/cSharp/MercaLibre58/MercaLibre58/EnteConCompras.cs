using System;
using System.Collections.Generic;
using System.Text;

namespace MercaLibre58
{
    public abstract class EnteConCompras
    {
        public List<CompraVenta> Compras { get; set; } 
        public List<CompraVenta> venta { get; set; }
    public EnteConCompras()
        {
            Compras = new List<CompraVenta>();
        }
        public void agregarCompra( CompraVenta kompra)
        {
            Compras.Add(kompra);
        }
        
        
        
    }
}
