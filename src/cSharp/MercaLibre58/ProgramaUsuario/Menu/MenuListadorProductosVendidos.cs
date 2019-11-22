using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;
using System.Collections.Generic;

namespace ProgramaUsuario.Menu
{
    class MenuListadorProductosVendidos:MenuListador<CompraVenta>
    {
        public  Producto Producto { get; set; }

        public override void imprimirElemento(CompraVenta p) => Console.WriteLine("Fecha de Venta : " + p.FechaHora.ToShortDateString() + " Cantidad Vendidos : " + p.CantUnidades);
        public override List<CompraVenta> obtenerLista() => AdoUsuario.ADO.VentasDe(Producto);
        

    }
}
