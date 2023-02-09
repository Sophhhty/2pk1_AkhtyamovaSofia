using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_21
{
    internal class Print
    {
        static void Main(string[] args)
        {
            
            FractionNumber fn = new FractionNumber(-6,-7);
            Console.WriteLine(fn);
            FractionNumber fn1 = new FractionNumber(4, 6);
            Console.WriteLine(fn1);
            FractionNumber fn2 = new FractionNumber(6, -7);
            Console.WriteLine(fn2);
            FractionNumber fn3 = new FractionNumber(4, 6);
            Console.WriteLine(fn3); 
            FractionNumber fn4 = new FractionNumber(-6, -7);
            Console.WriteLine(fn4);

            Console.WriteLine($"Количество положительных дробных чисел: {FractionNumber.plusValue}");
            Console.WriteLine($"Количество отрицательных дробных чисел: {FractionNumber.minusValue}");

        }

    }
}
