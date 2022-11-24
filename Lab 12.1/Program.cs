using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());

            double L = Func.GetL(r);
            double S = Func.GetS(r);
            bool isCheck = Func.CheckPoint(x, y, r, x0, y0);
            Console.WriteLine("Длина {0} Площадь {1} Принадлежность окружности: {2}", L, S, isCheck);
            Console.ReadKey();
        }
    }
}
