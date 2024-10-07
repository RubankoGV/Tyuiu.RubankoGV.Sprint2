using Tyuiu.RubankoGV.Sprint2.Task6.V11.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task6.V11.Test
{
    public class DataServiceTest
    {
        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindDateOfNextDay(1990, 1, 1));
            Assert.AreEqual("Февраль", ds.FindDateOfNextDay(1990, 2, 1));
            Assert.AreEqual("Март", ds.FindDateOfNextDay(1990, 3, 1));
            Assert.AreEqual("Апрель", ds.FindDateOfNextDay(1990, 4, 1));
            Assert.AreEqual("Май", ds.FindDateOfNextDay(1990, 5, 1));
            Assert.AreEqual("Июнь", ds.FindDateOfNextDay(1990, 6, 1));
            Assert.AreEqual("Июль", ds.FindDateOfNextDay(1990, 7, 1));
            Assert.AreEqual("Август", ds.FindDateOfNextDay(1990, 8, 1));
            Assert.AreEqual("Сентябрь", ds.FindDateOfNextDay(1990, 9, 1));
            Assert.AreEqual("Октябрь", ds.FindDateOfNextDay(1990, 10, 1));
            Assert.AreEqual("Ноябрь", ds.FindDateOfNextDay(1990, 11, 1));
            Assert.AreEqual("Декабрь", ds.FindDateOfNextDay(1990, 12, 1));
        }
    }
}