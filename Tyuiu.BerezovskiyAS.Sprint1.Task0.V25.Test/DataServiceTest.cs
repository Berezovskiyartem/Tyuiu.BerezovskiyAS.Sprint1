using Tyuiu.BerezovskiyAS.Sprint1.Task0.V25.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task0.V25.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
