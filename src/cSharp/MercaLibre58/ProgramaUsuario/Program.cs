using System;
using MenuesConsola;
using ProgramaUsuario.Menu;
namespace ProgramaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaUsuario = new MenuAltaUsuario() { Nombre = "Registro" };

            ///////////////////////////////////////////////////
            var menuUsuarios = new MenuCompuesto() { Nombre = "Usuario" };
            menuUsuarios.agregarMenu(menuAltaUsuario);

            ///////////////////////////////////////////////////
            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu MERCA-LIBRE" };
            menuPrincipal.agregarMenu(menuUsuarios);


            menuPrincipal.mostrar();
        }
    }
}
