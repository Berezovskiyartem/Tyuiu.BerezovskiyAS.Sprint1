using Tyuiu.BerezovskiyAS.Sprint1.Task6.V6.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string value = "Hello World";
            string wait = "ello orld";
            var res = ds.DeleteFirstLetter(value);
            Assert.AreEqual(wait, res);
        }
    }
}
