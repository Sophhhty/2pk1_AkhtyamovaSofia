using System.Globalization;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задача 1");
            int a = 0;
            for (a = 0; a <= 100; a += 2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("задача 2");
            char c = 'a';
            for (int i = 0; i < 5; i++)
            {
                Console.Write(c);
                c++;
            }
            Console.WriteLine("задача 3");
            char b = '#';
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
            Console.WriteLine("задание 4");
            for (int i = 0; i <= 100; i += 1)
            {
                if (i % 3 == 0)
                    Console.WriteLine($"{i}");
            }
            Console.WriteLine("задание 5");
            for (int i = 1, j = 40; j - i != 10; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}