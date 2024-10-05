using Tyuiu.KolesnikovMN.Sprint1.Task1.V16.Lib;

namespace Tyuiu.KolesnikovMN.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 5.0;
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(30, res);
        }
    }
}