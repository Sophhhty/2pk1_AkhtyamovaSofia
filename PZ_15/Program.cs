using System.Net;

namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\newfile.txt", FileMode.Append);

            Console.WriteLine("Введите произвольную строку в ваш файл:");
            string fi = Console.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileStream);
            streamwriter.Write(fi);
            fileStream.Close();

            string[] str = { ".опа", "Привет", "помогите", "хочуспать" };

            int count = File.ReadAllLines(@"D:\newfile.txt").Length;

            for (int i = 0; i < count; i++)
            {
                string s = File.ReadAllLines(@"D:\newfile.txt").Skip(i).FirstOrDefault();

                for (int j = 0; j < str.Length; j++)
                {
                    if (s.Contains(str[j]))
                    {
                        Console.WriteLine(s);
                    }
                }
            }



        }
    }
}