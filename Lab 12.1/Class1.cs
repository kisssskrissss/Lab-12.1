using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    static class Func

    {
        static public double GetL(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetS(double r)
        {
            return Math.PI * r * r;
        }
        public static bool CheckPoint(double x, double y, double r, double x0, double y0)
        {
            return !(Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0)) >= r);
        }
    }


}
