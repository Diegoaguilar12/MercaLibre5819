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
            Console.Clear();
            Console.WriteLine("Busqueda Productos");

            nombreProducto = prompt("Nombre a buscar");
            var producto = seleccionarElemento();
            var cantidad = Convert.ToInt16(prompt("Ingrese La Cantidad Que Desea"));

            Usuario.Comprar(producto, cantidad);

            try
            {
                AdoUsuario.ADO.actualizarInfo(Usuario);
                Console.WriteLine("Compra realizada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo comprar por: {e.InnerException.Message}");
            }
            Console.ReadKey();
        }

    }
}
