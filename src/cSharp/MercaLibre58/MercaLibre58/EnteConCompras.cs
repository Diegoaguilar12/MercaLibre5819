using System;
using System.Collections.Generic;
using System.Text;

namespace MercaLibre58
{
    public abstract class EnteConCompras
    {
        public List<CompraVenta> ComprasVentas { get; set; } 
        
        public EnteConCompras()
        {
            ComprasVentas = new List<CompraVenta>();
        }
        public void agregarCompra( CompraVenta kompra)
        {
            ComprasVentas.Add(kompra);            
        }    
        
        
    }
}
