using System;

namespace ConsoleApp2._2
{
    class Program
    {
        static void Main()
        {
            double x, y, R;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите R:");
            R = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) <= R) Console.WriteLine("Точка ({0};{1}) входит в окружность с радиусом {2}", x, y, R);
            else Console.WriteLine("Точка ({0};{1}) не входит в окружность с радиусом {2}", x, y, R);
            Console.ReadKey(true);
        }
    
    }
}
