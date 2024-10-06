using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RubankoGV.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = b - 2 >= c | c + 2 <= d;
            res[1] = b != a & c !=d;
            res[2] = a < d || c < b;
            res[3] = d > a && c > a;
            res[4] = !(!res[0]);
            res[5] = a == d ^ c == a;

            return res;
        }
    }
}
