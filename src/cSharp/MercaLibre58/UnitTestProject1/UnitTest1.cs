using Microsoft.VisualStudio.TestTools.UnitTesting;
using MercaLibre58;

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
    }
}
