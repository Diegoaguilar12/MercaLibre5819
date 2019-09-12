using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MercaLibre58
{
    public abstract class EnteConCompras
    {
        
       
        public List<CompraVenta> CompraVentas { get; set; } 
        
        public EnteConCompras()
        {
            CompraVentas = new List<CompraVenta>(); 
        }
        public void AgregarCompra( CompraVenta kompra)
        {
            CompraVentas.Add(kompra);
        }
        
        
        
    }
}
