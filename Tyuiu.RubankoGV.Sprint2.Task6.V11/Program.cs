using Tyuiu.RubankoGV.Sprint2.Task6.V11.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рубанко Г.В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема : оператор switch                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Рубанко Геннадий Вячеславович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает значения с клавиатуры и         *");
            Console.WriteLine("* вычисляет выражение.                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string res;

            if ((m < 1) || (m > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это месяц" + ds.FindDateOfNextDay(g, m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
