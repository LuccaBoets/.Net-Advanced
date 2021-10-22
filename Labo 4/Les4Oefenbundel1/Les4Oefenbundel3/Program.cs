using System;
using System.Collections.Generic;
using System.Linq;

namespace Les4Oefenbundel3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 4;

            int max = 10;

            List<int> arr = new List<int>();

            for (int i = min; i <= max; i++)
            {
                arr.Add(i);
            }



            foreach (var item in arr.Where(x => x % 2 == 0).ToList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
