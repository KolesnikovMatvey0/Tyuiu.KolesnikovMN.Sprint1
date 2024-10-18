using Tyuiu.KolesnikovMN.Sprint1.Task2.V16.Lib;

namespace Tyuiu.KolesnikovMN.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.CalculatePerimetrCircle(x) + 0.001;
            Assert.AreEqual(37.699, res);
        }
    }
}