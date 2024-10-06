using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RubankoGV.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x == 2 && (y == 4 | y == 5)) | (x >= 3 && x <= 5 && ((y >= 3 && y <= 7) | y == 11)) | (x == 6 && (y >= 5 && y <= 11)) | (x >= 7 && x <= 8 && (y >= 5 && y <= 12)) | (x == 9 && (y == 11 | y == 12 | y == 5)) | (x == 10 && ((y >= 2 && y <= 5) | (y == 11 | y == 12))) | (x >= 11 && x <= 12 && ((y >= 2 && y <= 5) | y == 11)) | (x == 13 && ((y == 2 | y == 3) | (y >= 9 && y <= 13)))) 
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
