using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MercaLibre58
{
    public static class FactoryAdoMySQL
    {
    
        public static MySQL_ADO GetADO (string cadena)
        {
            var dbContextOptions = new DbContextOptionsBuilder();
            dbContextOptions.UseMySQL(cadena);
            return new MySQL_ADO(dbContextOptions.Options);
        }
        public static MySQL_ADO GetAdoDesdeJson(string archivo,string atributoJson)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(archivo, optional: true, reloadOnChange: true)
                .Build();
            string cadena = config.GetConnectionString(atributoJson);
            return GetADO(cadena);
                
        }
    }
}
