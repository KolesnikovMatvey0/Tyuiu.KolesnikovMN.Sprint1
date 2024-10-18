using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KolesnikovMN.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int value)
        {
            double perimetr = 2 * 3.1415 * value + 0.001;
            return perimetr;
        }
    }
}
