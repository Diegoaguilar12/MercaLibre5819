using Microsoft.VisualStudio.TestTools.UnitTesting;
using MercaLibre58;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ado = new MySQL_ADO();
            ado.Database.EnsureCreated();

        }
    }
}
