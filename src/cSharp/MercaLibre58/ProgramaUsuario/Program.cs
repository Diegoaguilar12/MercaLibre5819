using MenuesConsola;
using ProgramaUsuario.Menu;
namespace ProgramaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaUsuario = new MenuAltaUsuario() { Nombre = "Registro" };
            var menuInicioSesion = new MenuInicioSesion() { Nombre = "Inicio Sesion" };
            var ValidarInvalidar = new MenuValidarInvalidar() { Nombre = "Validar - Invalidar" };
            ///////////////////////////////////////////////////
            var menuUsuarios = new MenuCompuesto() { Nombre = "Usuario" };
            menuUsuarios.agregarMenu(menuAltaUsuario);
            menuUsuarios.agregarMenu(menuInicioSesion);
            var menuAdministrador = new MenuCompuesto() { Nombre = "Administrador" };

        
            ///////////////////////////////////////////////////
            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu MERCA-LIBRE" };
            menuPrincipal.agregarMenu(menuUsuarios);
            menuPrincipal.agregarMenu(menuAdministrador);


            menuPrincipal.mostrar();
        }
    }
}
