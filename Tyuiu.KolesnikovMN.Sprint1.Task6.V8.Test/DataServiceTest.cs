using Tyuiu.KolesnikovMN.Sprint1.Task6.V8.Lib;

namespace Tyuiu.KolesnikovMN.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string message = "hello world";
            var res = ds.MoveLetterToEnd(message);
            string wait = "elloh orldw";
            Assert.AreEqual(wait, res);
        }
    }
}