using MercaLibre58;

namespace ProgramaAdministrador
{
    class AdoAdministrador
    {
        public static MySQL_ADO ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("AppSettings.json", "administrador");

    }
}
