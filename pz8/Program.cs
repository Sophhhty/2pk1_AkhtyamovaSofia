using System;

namespace pz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 5];
            Random r = new Random();
            for (int i = 0; i <4; i++)
            {
                for (int j =0; j<5; j++)
                {
                    a[i,j] = r.Next(10);
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальные элементы в каждом столбце");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                int tempmax = int.MinValue;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[j,i] > tempmax)
                    {
                        tempmax = a[j, i];
                    }

                }
                Console.Write(tempmax + " ");
            }
        }
    }
}
