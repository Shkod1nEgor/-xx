using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] ar = { 0, 1, 2, 3, 4, 5 };
                int A = 5;
                ar = ar.Select(x => (x * 2 - A) / ar[0]).ToArray();
            }
        }
    }   
}
