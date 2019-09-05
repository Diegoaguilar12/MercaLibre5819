using System;
using System.Collections.Generic;
using System.Text;

namespace MercaLibre58
{
    public abstract class EnteConCompras
    {
        public List<Compra> Compras { get; set; }
        public EnteConCompras()
        {
            Compras = new List<Compra>();
        }
        public void agregarCompra( Compra kompra)
        {
            Compras.Add(kompra);
        }
        
        
        
    }
}
