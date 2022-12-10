namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\newfl.txt", FileMode.Open, FileAccess.Read);
        
            Console.WriteLine("Введите произвольный текст в ваш файл:");
           
            StreamWriter stream = new StreamWriter(fileStream);
    fileStream.Close();
          
            int count = File.ReadAllLines(@"D:\newfl.txt").Length; 
            Console.WriteLine(count);
            string[] txt = File.ReadAllLines(@"D:\newfl.txt");
            int a = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i];
                int b = txt[i].Split().Length;
                a += b;
            }

            // = txt.Split(" ");
            //    int txt = File.ReadAllText(@"D:\newfl.txt").Length;
            //    Console.WriteLine(txt);












        }
    }
}