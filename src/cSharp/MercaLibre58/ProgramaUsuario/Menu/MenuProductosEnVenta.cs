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
        public Producto Producto { get; set; }

        public override void imprimirElemento(Producto p) => Console.WriteLine(p.ToString());

        public override List<Producto> obtenerLista() => AdoUsuario.ADO.ProductosEnVentaDe(Usuario);
        public MenuListadorProductosVendidos MenuDe = new MenuListadorProductosVendidos();

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine("Mis productos");

            Producto = seleccionarElemento();
           
            MenuDe.Producto = Producto;
            VerVendidos();

        }
        private void VerVendidos()
        {
            bool cambio = false;
            if (preguntaCerrada(" ¿ Quiere Ver Cuantos Fueron Vendidos ?"))
                cambio = true;            

            if (cambio)
            {
                try
                {
                    AdoUsuario.ADO.VentasDe(Producto);
                    MenuDe.mostrar();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"No se pudo mostrar la lista : {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
            
            
        }
        
            
        
    }
}
