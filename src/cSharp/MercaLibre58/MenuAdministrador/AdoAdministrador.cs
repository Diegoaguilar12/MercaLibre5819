using Merca

namespace MenuAdministrador
{
    public static class AdoAdministrador
    {
        public static MySQL_ADO ADO { get; set; } =
           FactoryAdoMySQL.GetAdoDesdeJson("AppSettings.json", "usuario");
    }
}
