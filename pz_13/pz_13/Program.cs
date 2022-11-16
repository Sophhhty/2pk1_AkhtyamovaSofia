namespace pz_13
{
    internal class Program
    {
        static void CharsRepeat(char[] array)
        {
            int count;
            int max = 0;
            char c = ' ';

            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j + 1])
                        count++;
                }
                if (count > max)
                    c = array[i];
            }

            Console.WriteLine($"Самый часто встречающийся символ: {c}");


        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            CharsRepeat(array);
        }
    }
}