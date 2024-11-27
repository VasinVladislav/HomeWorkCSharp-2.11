using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.
            Console.WriteLine("Программа для вычисления гипотенузы прямоугольного треугольника. Через катеты");
        imputOne:
            Console.Write("Введите катет \"a\": ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
            imputTwo:
                Console.Write("Введите катет \"b\": ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b > 0)
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    Console.WriteLine("Гипотенуза прямоугольного треугольника \"c\" равна: " + c.ToString("#.##"));
                    return;
                }
                else
                {
                    Console.WriteLine("Недопустимое значение");
                    goto imputTwo;
                }
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
                goto imputOne;
            }
        }
    }
}
