using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;

namespace ProgramaUsuario.Menu
{
    class MenuAltaUsuario:MenuComponente
    {
        public Usuario Usuario { get; set; }
        public override void mostrar()
        {
            base.mostrar();

            var email = prompt("Ingrese su email");
            var nombre = prompt("Ingrese su nombre");
            var apellido = prompt("Ingrese su apellido");
            var nombreUsuario = prompt("Ingrese su nombre de usuario");
            var contraseña = ReadPassword("Ingrese contraseña");
            contraseña = EncryptProvider.Sha256(contraseña);

            Usuario = new Usuario()
            {
                Email = email,
                Nombre = nombre,
                Apellido = apellido,
                NombreUsuario = nombreUsuario,
                ContraseñaUsuario=contraseña
            };

            try
            {
                AdoUsuario.ADO.AltaUsuario(Usuario);
                Console.WriteLine("Operacion registro exitosa");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo registrar correctamente : {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
