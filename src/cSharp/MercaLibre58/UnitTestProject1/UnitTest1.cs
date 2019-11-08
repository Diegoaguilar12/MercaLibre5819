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
            ADO = FactoryAdoMySQL.GetAdoDesdeJson("AppSettings.json", "root");
            ADO.Database.EnsureDeleted();
            ADO.Database.EnsureCreated();
        }

        [TestMethod]
        public void persistenciaUsuario()
        {        
            string passEncriptada = EncryptProvider.Sha256("123456");
            string otraPass = EncryptProvider.Sha256("234567");
            string nombreusuario = "aMejias";
            string otronombreUsuario = "MejiasA";

            Usuario usuario = new Usuario()
            {
                Email = "angeles.mejias22@gmail.com",
                Nombre = "Angeles",
                Apellido = "Mejias",
                NombreUsuario = nombreusuario,
                ContraseñaUsuario = passEncriptada
            };

            ADO.AltaUsuario(usuario);
            
            Usuario usuario2 = ADO.usuarioPorNomUsuarioPass(nombreusuario, otraPass);
            Assert.IsNull(usuario2, nombreusuario);

            Usuario usuario3 = ADO.usuarioPorNomUsuarioPass(otronombreUsuario, passEncriptada);
            Assert.IsNull(usuario3, otronombreUsuario);

            Usuario usuario4 = ADO.usuarioPorNomUsuarioPass(otronombreUsuario, otraPass);
            Assert.IsNull(usuario4);

            Usuario usuario5 = ADO.usuarioPorNomUsuarioPass(nombreusuario, passEncriptada);
            Assert.IsNotNull(usuario5);

            Assert.AreEqual("Mejias, Angeles", usuario5.NombreCompleto);           
        }
     
    }
}
