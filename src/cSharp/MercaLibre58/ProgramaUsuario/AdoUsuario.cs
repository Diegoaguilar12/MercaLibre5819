using MercaLibre58;

namespace ProgramaUsuario
{
    public static class AdoUsuario
    {
        public static MySQL_ADO ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("AppSettings.json", "usuario");

       
    }

}
