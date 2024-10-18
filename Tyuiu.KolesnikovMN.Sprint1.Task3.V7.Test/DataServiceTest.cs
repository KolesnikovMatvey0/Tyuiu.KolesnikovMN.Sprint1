using Tyuiu.KolesnikovMN.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KolesnikovMN.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(1066.8, res);
        }
    }
}