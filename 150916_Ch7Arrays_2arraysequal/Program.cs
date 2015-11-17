using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150916_Ch7Arrays_2arraysequal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which reads two arrays from the console and checks whether they are equal 
            //(two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).
            Console.WriteLine("Please provide two arrays of integers.");
            Console.Write("Array 1: ");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            Console.Write("Array 2: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[n2];
           

            if (array1.Length != array2.Length)
            {
                Console.WriteLine("These arrays are not equal.");
            }
            else if (array1.Length == array2.Length)
            {
                for (int index = 0; index < array1.Length;)
                { if (array1[index] != array2[index])
                    {
                       Console.WriteLine("These arrays are not equal.");
                    }
                               
                  else if (array1[index] == array2[index])
                    {
                        index++;
                        if (index == array1.Length)
                        {
                            Console.WriteLine("These arrays are equal.");
                        }
                    }
                }
                
                

            }


        }
    }
}
