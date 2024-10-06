using Tyuiu.RubankoGV.Sprint2.Task2.V14.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task2.V14.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}