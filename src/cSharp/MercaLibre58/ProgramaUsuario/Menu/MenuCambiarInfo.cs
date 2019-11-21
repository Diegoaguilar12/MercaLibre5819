using MenuesConsola;
using MercaLibre58;
using System;
using NETCore.Encrypt;
using static System.ReadLine;

namespace ProgramaUsuario
{
    class MenuCambiarInfo:MenuComponente
    {
        public Usuario Usuario { get; set; }
        
        public override void mostrar()
        {
            base.mostrar();
           
            menuModificarInformacion();
        }
        private void menuModificarInformacion()
        {
            bool cambio = false;
            if (preguntaCerrada("- ¿ Desea modificar su Email ?" + "\n"))
            {
                Usuario.Email = prompt("Ingrese nuevo Email");
                cambio = true;
            }
            if (preguntaCerrada("- ¿ Desea modificar su Contraseña ?" + "\n"))
            {
                Usuario.ContraseñaUsuario = prompt(" - Ingrese nueva contraseña");
                Usuario.ContraseñaUsuario = EncryptProvider.Sha256(Usuario.ContraseñaUsuario);
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
