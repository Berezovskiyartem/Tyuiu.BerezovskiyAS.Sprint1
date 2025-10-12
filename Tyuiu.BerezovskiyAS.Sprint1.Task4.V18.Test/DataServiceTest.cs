using Tyuiu.BerezovskiyAS.Sprint1.Task4.V18.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x, y;
            x = 5;
            y = 5;
            var res = (ds.Calculate(x, y);
            Assert.AreEqual(0.005, res);
        }
    }
}
