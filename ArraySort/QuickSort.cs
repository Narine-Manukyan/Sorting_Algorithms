using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    /// <summary>
    /// This Class Implements Quick Sort Algorithm.
    /// </summary>
    public static class QuickSort
    {
        // This Is a Counter For Calculating Used Memory.
        public static int usedMemory = 0;

        public static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// This Function is For Sorting Array.
        /// </summary>
        private static int[] Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Partioning index, array[index] is now in right place.
                int index = Partition(array, left, right);

                // Recursively sort elements before and after partition.   
                int[] leftArray = Sort(array, left, index - 1);
                usedMemory += leftArray.Length * 4;
                int[] rightArray = Sort(array, index + 1, right);
                usedMemory += rightArray.Length * 4;
            }
            return array;
        }

        /// <summary>
        /// This function takes last element as pivot, places the pivot element 
        /// at its correct position in sorted array, and places all smaller than 
        /// pivot to left of pivot and all greater elements to right of pivot.*/
        /// </summary>
        private static int Partition(int[] array, int begin, int end)
        {
            // In the left side of the pivot must be smaller than pivot.
            // In the right side of the pivot must be greater than pivot.
            int pivot = array[end];

            // Index of smaller element.
            int i = begin;
            for (int j = begin; j < end; j++)
            {
                if (array[j] <= pivot)
                {
                    // Swap array[i] and array[j].
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;
                }
            }

            // When j reaches the end pivot should be at i
            // Swap array[i + 1] and array[end] or pivot.
            array[end] = array[i];
            array[i] = pivot;

            return i;
        }
    }
}
