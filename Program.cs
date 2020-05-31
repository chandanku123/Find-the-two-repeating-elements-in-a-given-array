using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DublicateElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the two repeating elements in a given array
            int[] array = { 4, 2, 4, 5, 2, 2, 3, 1, 4 };
            Dictionary<int, int> duplicateNumbers = new Dictionary<int, int>();
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                count = 1;
                if (!duplicateNumbers.ContainsKey(array[i]))
                {
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        if (array[i] == array[j + 1])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        duplicateNumbers.Add(array[i], count);
                    }
                }
            }
            foreach (var num in duplicateNumbers)
            {
                Console.WriteLine("Duplicate numbers, Number-{0}, Occurrence- {1}", num.Key, num.Value);
            }
            Console.ReadLine();
        }
    }
}
