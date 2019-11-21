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
        
        public override void  mostrar()
        {
           
            base.mostrar();

            var nombreUsuario = prompt("Ingrese su nombre de usuario");
            var contraseña = prompt("Ingrese contraseña");
            contraseña = EncryptProvider.Sha256(contraseña);
            var usuario = AdoUsuario.ADO.usuarioPorNomUsuarioPass(nombreUsuario, contraseña);

            if(usuario is null)
            {
                Console.WriteLine("El nombre de usuario o la contraseña es incorrecto");
                
            }
            else
            {
                var menuCambioInfo = new MenuCambiarInfo() { Nombre = "Cambio Informacion" };
                var menuAgregoProducto = new MenuAgregarProducto() { Nombre = "Agregar Producto Para Vender" };
                menuCambioInfo.Usuario = usuario;
                Console.WriteLine("\n"+"Inicio de sesion exitoso");
                var menuPrincipalUsuario = new MenuCompuesto() { Nombre = "Menu Principal Usuario" };
                menuPrincipalUsuario.agregarMenu(menuCambioInfo);
                menuPrincipalUsuario.agregarMenu(menuAgregoProducto);
                menuPrincipalUsuario.mostrar();
                
            }

            Console.ReadKey();
        }
    }
}
