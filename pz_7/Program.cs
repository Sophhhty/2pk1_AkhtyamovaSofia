using System.Diagnostics;

namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]; //объявление одномерного массива
            for (int i = 0; i < 10; i++) //запись элементов массива
                a[i] = int.Parse(Console.ReadLine()); //ввод 
            int sum = 0;
            for (int i = 0; i < a.Length; i++) //вычислить сумму 
            {
                sum += a[i];
            }
            Console.WriteLine(sum);//вывод
        }
    }
}