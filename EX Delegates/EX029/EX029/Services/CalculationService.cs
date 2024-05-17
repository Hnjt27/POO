using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX029.Services
{
    internal class CalculationService
    {
        public static double Max(double x, double y)
        {
            return x > y ? x : y; // if else simplificado  - x é maior q y? se sim, x recebe y
        }
        public static double Sum(double x, double y)
        { 
            return x + y;
        }

        public static double Square(double x) 
        {
            return x = x * x;
        }
        

    }
}
