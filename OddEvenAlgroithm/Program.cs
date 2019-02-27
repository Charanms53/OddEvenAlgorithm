////Question
//// Place the odd no in odd place and even number in even place and swap the no and create the same output with odd number in odd position and even number in even 
////    position and find the minimal swaps

////Sample Input:			Saample	Output:
////6,4,5,14,13,15			5,4,13,6,15,14

////Minimum No of swaps: 4
////1) 5,4,6,14,13,15
////2) 5,4,13,14,6,15
////3) 5,4,13,6,14,15
////4) 5,4,13,6,15,14

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenAlgroithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[6] { 5, 4, 6, 14, 13, 15 };

            OddEvenClass oddEvent = new OddEvenClass();
            oddEvent.CalculateOddEvenAlgorithm(arrayA);
        }
    }

    public class OddEvenClass
    {
        public void CalculateOddEvenAlgorithm(int[] data)
        {

        }
    }
}