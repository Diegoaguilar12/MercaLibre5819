using Microsoft.VisualStudio.TestTools.UnitTesting;
using MercaLibre58;
using NETCore.Encrypt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public static MySQL_ADO ADO { get; set; }


        [ClassInitialize]
        public static void SetUpClase(TestContext context)
        {
            ADO = new MySQL_ADO();
            ADO.Database.EnsureDeleted();
        }
        [TestMethod]
        public void TestMethod1()
        {
            ADO.Database.EnsureCreated();

        }

        [TestMethod]
        public void persistenciaUsuario()
        {
            ADO = new MySQL_ADO();

            string passEncriptada = EncryptProvider.Sha256("123456");
            string otraPass = EncryptProvider.Sha256("234567");
            string email = "angeles.mejias22@gmail.com";
            string otroEmail = "johannysmejias@gmail.com";

            Usuario usuario = new Usuario()
            {
                Email = email,
                Nombre = "Angeles",
                Apellido = "Mejias",
                ContraseñaUsuario = passEncriptada
            };

            ADO.AltaUsuario(usuario);
            ADO = new MySQL_ADO();
           
            

        }
        
    }
}
