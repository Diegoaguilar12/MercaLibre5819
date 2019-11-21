using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;

namespace ProgramaUsuario.Menu
{
    class MenuModificarProductosVenta:MenuProductosEnVenta
    {
       
        public Producto Producto { get; set; }
        
       
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Producto = seleccionarElemento();
            Console.WriteLine();
            menuModificarProductos();
        }
        private void menuModificarProductos()
        {
            bool cambio = false;
            if (preguntaCerrada(" - ¿ Cambiar Precio Del Producto ? "))
            {
                Producto.PrecioProducto = float.Parse(prompt("Ingrese nuevo precio"));
                cambio = true;
            }
            if (preguntaCerrada(" - ¿ Cambiar Stock Del Producto ? "))
            {
                Producto.Cantidad = Convert.ToInt16(prompt("Ingrese nuevo stock"));
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoUsuario.ADO.actualizarInfo(Usuario);
                    Console.WriteLine("Producto actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
        }
    }
}
