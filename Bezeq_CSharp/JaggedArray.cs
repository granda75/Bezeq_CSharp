using System;
using System.Collections.Generic;
using System.Linq;

namespace Bezeq_CSharp
{
    public class JaggedArray
    {
        public int[][] CreateArrayAndReturn()
        {
            int[][] array = new int[6][];
            array[0] = new int[] { 1, 3 };
            array[1] = new int[] { 5, 7, 9 };
            array[2] = new int[] { 3, 1 };
            array[3] = new int[] { 3, 6, 7 };
            array[4] = new int[] { 9, 7, 5 };
            array[5] = new int[] { 3, 67 };
            return array;
        }

        public int[][] RemoveDuplicates(int[][] array)
        {
            var dict = new Dictionary<string, int[]>();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].OrderBy(r => r).Select(r => r).ToArray();
                string arrayStr = string.Join(",", array[i]);
                if (!dict.ContainsKey(arrayStr)) dict.Add(arrayStr, array[i]);
            }

            return dict.Select(g => g.Value).ToArray();
        }


        public void PrintArray(int[][] array)
        {
            foreach (var row in array)
            {
                foreach (var item in row)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }
        }
    }
}
