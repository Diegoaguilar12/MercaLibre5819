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
            menuAgregoProducto.Usuario = Usuario;
            menuCambioInfo.Usuario = Usuario;
            Console.WriteLine("\n" + "Inicio de sesion exitoso");
            MenuPrincipalUsuario = new MenuCompuesto() { Nombre = "Menu Principal Usuario" };
            MenuPrincipalUsuario.agregarMenu(menuCambioInfo);
            MenuPrincipalUsuario.agregarMenu(menuAgregoProducto);
        }
    }
}
