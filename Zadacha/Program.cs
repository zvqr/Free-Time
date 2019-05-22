using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            //106/2
            Console.WriteLine("Total elements ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Searched number ");
            int searchnum = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int index1 = 0;
            int index2 = n - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[index1] + array[index2] > searchnum)
                    index2--;
                else if (array[index1] + array[index2] < searchnum)
                    index1++;
                else if (index1 != index2)
                {
                    Console.WriteLine($"numbers {array[index1]} and {array[index2]} equals {searchnum}");
                    return;
                }
            }
            Console.WriteLine($"there is not number equal {searchnum}");
        }
    }
    }

