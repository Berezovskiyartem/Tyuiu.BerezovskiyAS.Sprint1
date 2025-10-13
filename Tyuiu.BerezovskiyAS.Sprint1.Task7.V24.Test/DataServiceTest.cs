using Tyuiu.BerezovskiyAS.Sprint1.Task7.V24.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 8;
            double wait = 1.617;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
