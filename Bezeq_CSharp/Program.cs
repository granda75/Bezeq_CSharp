using System;
using System.Collections.Generic;
using System.Linq;

namespace Bezeq_CSharp
{
    internal class Program
    {
        static void Main()
        {
            //Task 1
            Console.WriteLine("Input string, please :");
            string inputStr = Console.ReadLine();
            if (string.IsNullOrEmpty(inputStr))
            {
                Console.WriteLine("The input string is empty");
            }
            else
            {
                Console.WriteLine("");
                GroupWordsInString(inputStr);
            }
            Console.ReadLine();

            //Task 2
            try
            {
                var jaggedArray = new JaggedArray();
                var array =jaggedArray.CreateArrayAndReturn();
                array = jaggedArray.RemoveDuplicates(array);
                jaggedArray.PrintArray(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.ReadLine();

        }

        private static void GroupWordsInString(string inputStr)
        {
            string[] parts = inputStr.Split(' ');
            var list = parts?.ToList<string>();
            list = list.Where(l => l != string.Empty).Select(l => l).ToList();

            var dict = list.GroupBy(word => word).ToDictionary(g => g.Key, g => g.Count());
            foreach (KeyValuePair<string, int> pair in dict.OrderByDescending(g => g.Value))
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
        }
    }
}
