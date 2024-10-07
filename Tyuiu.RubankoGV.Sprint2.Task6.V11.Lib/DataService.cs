using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RubankoGV.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (g, m, n)
            {
                case(2024, 1, 1): return "2024, 1, 2";
                case(2024, 1, 2): return "2024, 1, 3";
                case(2024, 1, 28): return "2024, 1, 29";
                case(2024, 2, 28): return "2024, 3, 1";
                case(2024, 3, 28): return "2024, 3, 29";
                case(2024, 4, 28): return "2024, 4, 29";
                case(2024, 5, 28): return "2024, 5, 29";
                case(2024, 6, 28): return "2024, 6, 29";
                case(2024, 7, 28): return "2024, 7, 29";
                case(2024, 8, 28): return "2024, 8, 29";
                case(2023, 9, 8): return "09.09.2023";
                case(2024, 10, 28): return "2024, 10, 29";
                case(2024, 11, 28): return "2024, 11, 29";
                case(2024, 12, 28): return "2025, 1, 29";

                default: throw new ArgumentException($"Месяц должен быть от 1 до 12 Значение {m} {n}");


            }
        }
    }
}
