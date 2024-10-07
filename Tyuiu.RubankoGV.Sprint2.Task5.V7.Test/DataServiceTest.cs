using Tyuiu.RubankoGV.Sprint2.Task5.V7.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task5.V7.Test
{
    public class DataServiceTest
    {
        [Test]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("������", ds.FindMonthName(1990, 1));
            Assert.AreEqual("�������", ds.FindMonthName(1990, 2));
            Assert.AreEqual("����", ds.FindMonthName(1990, 3));
            Assert.AreEqual("������", ds.FindMonthName(1990, 4));
            Assert.AreEqual("���", ds.FindMonthName(1990, 5));
            Assert.AreEqual("����", ds.FindMonthName(1990, 6));
            Assert.AreEqual("����", ds.FindMonthName(1990, 7));
            Assert.AreEqual("������", ds.FindMonthName(1990, 8));
            Assert.AreEqual("��������", ds.FindMonthName(1990, 9));
            Assert.AreEqual("�������", ds.FindMonthName(1990, 10));
            Assert.AreEqual("������", ds.FindMonthName(1990, 11));
            Assert.AreEqual("�������", ds.FindMonthName(1990, 12));


        }
    }
}