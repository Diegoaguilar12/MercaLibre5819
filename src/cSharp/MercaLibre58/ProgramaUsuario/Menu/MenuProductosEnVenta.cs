using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;
using System.Collections.Generic;

namespace ProgramaUsuario.Menu
{
    class MenuProductosEnVenta: MenuListador<Producto>
    {
        public Usuario Usuario { get; set; }

        public override void imprimirElemento(Producto p) => Console.WriteLine(p.ToString());

        public override List<Producto> obtenerLista() => AdoUsuario.ADO.ProductosEnVentaDe(Usuario);
    }
}
