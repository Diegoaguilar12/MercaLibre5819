using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;
using System.Collections.Generic;

namespace ProgramaUsuario.Menu
{
    class BuscarProducto:MenuListador<Producto>
    {
        public Usuario Usuario { get; set; }
        public string nombreProducto { get; set; }


        public override void imprimirElemento(Producto p) => Console.WriteLine(p.ToString());        
        public override List<Producto> obtenerLista() => AdoUsuario.ADO.BuscarPor(nombreProducto, Usuario);

        public override void mostrar()
        {
            var producto = seleccionarElemento();
            var cantidad = ;
            Usuario.Comprar(producto, cantidad );

        }

    }
}
