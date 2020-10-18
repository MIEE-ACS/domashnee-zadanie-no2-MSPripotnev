using System;

namespace Homework
{
    using static Console;
    class Program
    {
        /// <summary>
        /// Прямая k = -1, b = -2;
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double y1(double x) => -x - 2;
        /// <summary>
        /// Окружность.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        static double y2(double x, double R)
        {
            double x0 = -1, y0 = 0; //центр

            if (Math.Abs(x - x0) > R)
                return 1-Int32.MaxValue;
            return Math.Sqrt(R*R - (x-x0)*(x-x0)) - y0;
        }

        static double y3(double x) => 1;
        static double y4(double x) => -2 * x + 3;
        static double y5(double x) => -1;

        static void Main(string[] args)
        {
            double R;
            Console.Write("Введите параметр R=");
            while (!double.TryParse(Console.ReadLine(), out R) || R < 0 || R > 1)
            {
                Console.WriteLine("Некорректный ввод! R должен быть от 0 до 1!");
                Console.Write("Введите параметр R=");
            }

            for (double x = -3; x <= 5; x += 0.2)
            {
                x = Math.Round(x, 3);
                if (x < -3)
                    WriteLine("Функция не определена");
                else if (x <= -2)
                    WriteLine($"y({x:0.00}) = {y1(x):0.00}");
                else if (x < -1)
                    if (y2(x, R) != 1 - Int32.MaxValue)
                        WriteLine($"y({x:0.00}) = {y2(x, R):0.00}");
                    else
                        WriteLine("Функция не определена");
                else if (x <= 1)
                    WriteLine($"y({x:0.00}) = {y3(x):0.00}");
                else if (x <= 2)
                    WriteLine($"y({x:0.00}) = {y4(x):0.00}");
                else if (x <= 5)
                    WriteLine($"y({x:0.00}) = {y5(x):0.00}");
                else
                    WriteLine("Функция не определена");
            }
        }
    }
}
