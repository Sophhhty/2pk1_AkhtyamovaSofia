﻿using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String A = Console.ReadLine();
            String B = Console.ReadLine();
            bool isFind = false;

            if (A.Contains(B))
            {
                isFind = true;
            }

            if (isFind == true)
            {
                char[] arr = B.ToCharArray();
                Array.Reverse(arr);

                foreach (var item in arr)
                {
                    Console.Write(item);
                }
            }
        }
    }
   
}