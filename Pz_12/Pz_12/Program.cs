namespace Pz_12
{
    internal class Program
    {
       public static void GetArea( double a, double b)
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double g = ((a * b) / 2);
            double h = ((a + b - c) / 2);
            Console.WriteLine("Гипотенуза = " + c);
            Console.WriteLine("Площадь = " + g);
            Console.WriteLine("Радиус = " + h);
        }
        
       public static void Main(string[] args)
        {
            Console.WriteLine("Введите значения катетов");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            GetArea(x, y);
            Console.WriteLine();
        }
    }
}