using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = GetInputArray();
            PrintArray(inputArray);

            Sort(inputArray);

            PrintArray(inputArray);
            Console.ReadLine();
        }

        static void Sort(int[] inputArray)
        {
            bool isSorted = true;
            int temp;

            while (true)
            {
                isSorted = true;
                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i-1] > inputArray[i])
                    {
                        isSorted = false;
                        temp = inputArray[i - 1];

                        inputArray[i - 1] = inputArray[i];
                        inputArray[i] = temp;
                    }
                }

                if (isSorted)
                {
                    break;
                }
            }
        }

        static int[] GetInputArray()
        {
            List<int> inputList = new List<int>();
            Console.WriteLine("Enter ints to be sorted, enter string to quit: ");

            while (true)
            {
                int i;
                string num = Console.ReadLine();
                if (Int32.TryParse(num, out i))
                {
                    inputList.Add(i);
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }

            return inputList.ToArray();
        }
        static void PrintArray(int[] inputArray)
        {
            foreach (int i in inputArray)
            {
                if (inputArray[inputArray.Length - 1] == i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
