using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;

namespace ProgramaUsuario.Menu
{
    class MenuAgregarProducto: MenuComponente
    {
        private Producto Producto { get; set; }
        public Usuario Usuario { get; set; }

        public override void mostrar()
        {
            base.mostrar();
            
            var nombre = prompt("Ingrese nombre del producto");
            var precio = float.Parse(prompt("Ingrese precio unitario"));
            var cantidad = Convert.ToInt16(prompt("Ingrese stock"));

            Producto = new Producto()
            {
                NombreProducto = nombre,
                PrecioProducto = precio,
                Cantidad = cantidad,
                Estado = true
                
                
            }; 

            try
            {
                Usuario.ProductoVendidos = AdoUsuario.ADO.ProductosEnVentaDe(Usuario);
                Usuario.AgregarProducto(Producto);
                AdoUsuario.ADO.actualizarInfo(Usuario);
                Console.WriteLine("Producto agregado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo agregar el producto: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}