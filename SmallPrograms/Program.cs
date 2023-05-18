using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIndex("AB"));
            Console.ReadLine();
        }

        #region CheckPrimeNumber
        public static bool CheckPrime(int input)
        {
            if (input <= 1) return false;
            if (input == 2) return true;
            if (input % 2 == 0) return false;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0) return false;
            }

            return true;
        }
        #endregion

        #region Get Index of Excel Cell
        public static int GetIndex(string input)
        {
            int result = 0;
            for(int i=0; i<input.Length; i++)
            {
                result *= 26;
                result += input[i] - 'A' + 1;
            }
            return result - 1;
        }
        #endregion

        #region Number Sorting
        public static void Sorting(params int[] input)
        {
            if (input.Length == 0) input = new int[] { 1, 7, -5, 9, -12, 15 };

            int temp = 0;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
        #endregion
    }
}
