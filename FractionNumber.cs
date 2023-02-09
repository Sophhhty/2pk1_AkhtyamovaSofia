using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PZ_21
{
   
    internal class FractionNumber
    {
        public double dividend = 0;
        public double divider = 0;
        static char sign;
        static int counter;
        static int GetCounter() { return counter; }
        public double Dividend() { return dividend; }
        public double Divider() { return divider; }

        public FractionNumber() //конструктор 
        {
            dividend= 1;
            divider= 1;


        }
        public FractionNumber(int dividend, int divider)// конструктор
        {
            
            this.dividend = dividend;
            this.divider = divider;
            if (divider == 0)//усл-е знаменатель = 0 и числитель целое число
            {
                Console.WriteLine("на 0 делить нельзя");
                this.dividend = Math.Abs(dividend);
            }
            else if (dividend % divider == 0)
            {
                this.dividend = Math.Abs(dividend);
            }
        }

        public override string ToString()//вывод дроби
        {
            
            GetNumber();
           
            return sign + dividend.ToString() + "/" + divider.ToString();
        }

        //метод с выбором знака, который не работает:(
        public void GetNumber()
        {
            if ((dividend > 0 & divider < 0) || (dividend < 0 & divider > 0))
            {
                sign = '-';
                //Console.WriteLine($"{dividend}\n{sign} --\n {dividend}");
            }
            else
            {
                sign = '+';
                //Console.WriteLine($"{dividend}\n{sign} --\n {dividend}");
            }
        } 
    }
}
