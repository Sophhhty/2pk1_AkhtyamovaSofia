namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while ( i * i <= n)
            {
                Console.Write(i * i + " ");
                i++;
            }
            Console.WriteLine();
        }
    }
}