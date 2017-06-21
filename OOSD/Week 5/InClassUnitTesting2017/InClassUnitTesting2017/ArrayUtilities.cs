using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassUnitTesting2017
{
    public class ArrayUtilities
    {
        // int LargestValue(int[] inputValues)
        // Accepts an array of integer and returns the largest value in the array
        public int LargestValue(int[] inputValues)
        {
            int max = Int32.MinValue;

            for (int index = 0; index < inputValues.Length; index++)
            {
                if (inputValues[index] > max)
                    max = inputValues[index];
            }
            return max;
        }
    }
}

