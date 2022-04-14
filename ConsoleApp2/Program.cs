using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] result = "Предложение из десяти слов, с кучей пробелов   и запятыми, точками.".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < result.Length; i++)
                result[i] = result[i].Trim().Replace(",", String.Empty).Replace(".", String.Empty);

        }
    }   
}
