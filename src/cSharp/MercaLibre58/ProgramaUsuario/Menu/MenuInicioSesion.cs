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
            var menuCambioInfo = new MenuCambiarInfo() { Nombre = "Cambio Informacion" };
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
                var menuPrincipalUsuario = new MenuCompuesto() { Nombre = "Menu Principal Usuario" };
                menuPrincipalUsuario.agregarMenu(menuCambioInfo);
            }

            Console.ReadKey();
        }
    }
}
