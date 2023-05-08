namespace PZ_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("результат:" + Registers(str));
        }

        static string Registers(string str)
        {

            char[] c = str.ToCharArray();

            for (int i = 0; i < c.Length;i++)
            {
                if (char.IsUpper(c[i]))
                {
                    c[i] = char.ToLower(c[i]);
                }
                else if (char.IsLower(c[i]))
                {
                    c[i] = char.ToUpper(c[i]);
                }
            }
            string str_1;
            str_1 = new string(c);
            Console.WriteLine(str_1);
            return str_1;
        }
    }
}