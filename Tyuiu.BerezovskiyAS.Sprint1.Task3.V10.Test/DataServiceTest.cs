using Tyuiu.BerezovskiyAS.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 23.6;
            Assert.AreEqual(ds.NumberToMoney(236), "23.6 руб. - это 23 руб. 60 коп.");
        }
    }
}
