using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    /// <summary>
    /// This Class Implements Merge Sort Algorithm.
    /// </summary>
    public static class MergeSort
    {
        // This Is a Counter For Calculating Used Memory.
        public static int usedMemory = 0;

        /// <summary>
        /// This Function is For Sorting Array.
        /// </summary>
        public static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }

        private static int[] Sort(int[] array, int begin, int end)
        {
            if (begin < end)
            {
                int middle = (begin + end) / 2;

                // Merge
                // Sort First and Second halves with recursion.
                int[] leftArray = Sort(array, begin, middle);
                usedMemory += leftArray.Length * 4;
                int[] rightArray = Sort(array, middle + 1, end);
                usedMemory += rightArray.Length * 4;

                // Create temporary arrays.
                leftArray = new int[middle - begin + 1];
                usedMemory += leftArray.Length * 4;
                rightArray = new int[end - middle];
                usedMemory += rightArray.Length * 4;

                // Copy data to these arrays.
                Array.Copy(array, begin, leftArray, 0, middle - begin + 1);
                Array.Copy(array, middle + 1, rightArray, 0, end - middle);


                // Initial indexes of first and second arrays.
                int i = 0;
                int j = 0;
                // Merge temporary arrays.
                for (int k = begin; k < end + 1; k++)
                {
                    if (i == leftArray.Length)
                        array[k] = rightArray[j++];
                    else if (j == rightArray.Length)
                        array[k] = leftArray[i++];
                    else if (leftArray[i] <= rightArray[j])
                        array[k] = leftArray[i++];
                    else
                        array[k] = rightArray[j++];
                }
            }
            return array;
        }
    }
}
