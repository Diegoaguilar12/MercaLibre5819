using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;

namespace ProgramaUsuario
{
    class MenuCambiarInfo:MenuCompuesto
    {
        public Usuario Usuario { get; set; }
        
        public override void mostrar()
        {
            base.mostrar();

            var NewEmail = prompt("Ingrese su nuevo email");
            var NewContraseña = prompt("Ingrese nueva contraseña");

            Usuario.Email = NewEmail;
            Usuario.ContraseñaUsuario = NewContraseña;

            
        }

       
        
    }
}
