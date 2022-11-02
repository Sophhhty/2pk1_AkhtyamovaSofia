namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //замена места первого и последнего предложения в тексте
            string a = Console.ReadLine();
            string[] subs = a.Split('.');
            string newString = subs[subs.Length - 1];
            for (int i = 1; i < subs.Length - 1; i++)
            {
                newString += "." + subs[i];
            }
            newString += "." + subs[0];
            Console.WriteLine(newString);
            //        //замена местами превого и последнего слова в предложении
            //        string a = Console.ReadLine();
            //        string[] subs = a.Split('.');
            //        foreach (var sub in subs)
            //        { }
            //        string A = a.Substring(0, a.IndexOf(' '));
            //        string B = a.Substring(a.LastIndexOf(' ') + 1);
            //        a = a.Remove(0, a.IndexOf(' '));
            //        a = a.Remove(a.LastIndexOf(' ') + 1);
            //        Console.WriteLine(B + a + A);
        }
    }

}