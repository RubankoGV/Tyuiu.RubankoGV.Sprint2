using Tyuiu.RubankoGV.Sprint2.Task7.V2.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task7.V2.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.9;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}