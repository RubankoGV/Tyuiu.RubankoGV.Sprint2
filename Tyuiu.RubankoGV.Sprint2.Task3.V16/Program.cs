using Tyuiu.RubankoGV.Sprint2.Task3.V16.Lib;
namespace Tyuiu.RubankoGV.Sprint2.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рубанко Г.В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема : Вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Рубанко Геннадий Вячеславович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает значения с клавиатуры и         *");
            Console.WriteLine("* вычисляет выражение.                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной Х: ");
            int x = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            double res = ds.Calculate(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции " + res);

            Console.ReadLine();
        }
    }
}
