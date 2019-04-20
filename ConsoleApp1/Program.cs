using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Parminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[10] { 3, 11, 9, 11, 4, 11, 5, 9, 2, 1 };
            ArrayProcessing(inputArray);
        }

        public static void ArrayProcessing(int[] newArray)
        {
            int[] newArray2 = newArray;
            for(int i = 0; i < newArray2.Length; i++)
            {
                int counter = 0;
                
                for(int j = 0; j<newArray2.Length; j++)
                {
                    if (newArray2[j] == newArray2[i])
                    {
                        counter++;
                        if (counter == 3)
                        {
                            Console.WriteLine("Number that is repeated three time is"+newArray2[i]);
                        }
                    }
                }
            }

        }
    }
}
