using Tyuiu.BerezovskiyAS.Sprint1.Task1.V11.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 12.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}
