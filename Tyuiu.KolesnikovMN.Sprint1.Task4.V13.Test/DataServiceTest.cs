using Tyuiu.KolesnikovMN.Sprint1.Task4.V13.Lib;

namespace Tyuiu.KolesnikovMN.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.045, res);
        }
    }
}