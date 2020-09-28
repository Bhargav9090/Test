using System;
using System.Linq;

namespace Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Input the string : ");
            str = Console.ReadLine().ToLower();

            var res = str.GroupBy(p => p).Select(p => new { Count = p.Count(), Char = p.Key }).GroupBy(p => p.Count, p => p.Char).OrderByDescending(p => p.Key).First();


            foreach (var r in res)
            {
                Console.WriteLine("Frequent character : '{0}', Count : {1} \n\n", r, res.Key);
                return;
            }
        }
    }
}
