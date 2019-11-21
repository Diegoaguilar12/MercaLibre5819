using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;

namespace ProgramaUsuario.Menu
{
    class MenuInicioSesion: MenuComponente
    {
        public Usuario Usuario { get; set; }
        public MenuCompuesto MenuPrincipalUsuario { get; set; }

        public override void  mostrar()
        {
           
            base.mostrar();

            var nombreUsuario = prompt("Ingrese su nombre de usuario");
            var contraseña = prompt("Ingrese contraseña");
            contraseña = EncryptProvider.Sha256(contraseña);
            Usuario = AdoUsuario.ADO.usuarioPorNomUsuarioPass(nombreUsuario, contraseña);

            if(Usuario is null)
            {
                Console.WriteLine("El nombre de usuario o la contraseña es incorrecto");
                
            }
            else
            {
                instanciarMenues();
                MenuPrincipalUsuario.mostrar();

            }

            Console.ReadKey();
        }

        private void instanciarMenues()
        {
            var menuCambioInfo = new MenuCambiarInfo() { Nombre = "Cambio Informacion" };
            var menuAgregoProducto = new MenuAgregarProducto() { Nombre = "Agregar Producto Para Vender" };
            var menuListaProductos = new MenuProductosEnVenta() { Nombre = "Lista De Mis Productos En Venta" };
            var menuModificarProductos = new MenuModificarProductosVenta() { Nombre = "Modificar Productos En Venta" };
            var menuBuscarProducto = new BuscarProducto() { Nombre = "Buscar Producto " };
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            menuBuscarProducto.Usuario = Usuario;
            menuModificarProductos.Usuario = Usuario;
            menuListaProductos.Usuario = Usuario;
            menuAgregoProducto.Usuario = Usuario;
            menuCambioInfo.Usuario = Usuario;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            MenuPrincipalUsuario = new MenuCompuesto() { Nombre = "Menu Principal Usuario" };
            
            MenuPrincipalUsuario.agregarMenu(menuCambioInfo);
            MenuPrincipalUsuario.agregarMenu(menuAgregoProducto);
            MenuPrincipalUsuario.agregarMenu(menuListaProductos);
            MenuPrincipalUsuario.agregarMenu(menuModificarProductos);
            MenuPrincipalUsuario.agregarMenu(menuBuscarProducto);
        }
    }
}
