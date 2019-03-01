using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiplicationBy10
{
    class NumbersMultiplicationBy10
    {
        public int[] InputNumbers()
        {
            int[] input_numbers = new int[5];
            Console.WriteLine("Please enter 5 numbers: ");
            for (int i = 0; i < input_numbers.Length; i++)
            {
                input_numbers[i] = Int32.Parse(Console.ReadLine());
            }
            return input_numbers;
        }
        public void PrintsNumbersMultipliedBy10(int[] input_numbers)
        {
            Console.WriteLine("User input finished. Processing...");
            for (int j = 0; j < input_numbers.Length; j++)
            {
                Console.Write(input_numbers[j] * 10 + " ");
            }
        }
        static void Main(string[] args)
        {
            NumbersMultiplicationBy10 n = new NumbersMultiplicationBy10();
            n.PrintsNumbersMultipliedBy10(n.InputNumbers());
            Console.ReadKey();
        }
    }
}