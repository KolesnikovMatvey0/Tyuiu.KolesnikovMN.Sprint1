using Tyuiu.KolesnikovMN.Sprint1.Task7.V16.Lib;

namespace Tyuiu.KolesnikovMN.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.026, res);
        }
    }
}