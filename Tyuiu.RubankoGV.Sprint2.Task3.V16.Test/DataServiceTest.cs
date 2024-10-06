using Tyuiu.RubankoGV.Sprint2.Task3.V16.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 29;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.8333333;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 128;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -21;
            double res = ds.Calculate(x);
            double wait = -230.952380;
            Assert.AreEqual(wait, res);
        }
    }
}