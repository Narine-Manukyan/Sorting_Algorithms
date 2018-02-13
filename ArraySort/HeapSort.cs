using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    /// <summary>
    /// This Class Implements Heap Sort Algorithm.
    /// </summary>
    public static class HeapSort
    {
        /// <summary>
        /// This Function is For Sorting Array.
        /// </summary>
        public static int[] Sort(int[] array)
        {
            // Build-Max-Heap
            int heapSize = array.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                Heapify(array, heapSize, p);

            // Do this while heap has more one elements.
            for (int i = array.Length - 1; i > 0; i--)
            {
                // Swap first and last elements.
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;

                // Decrement the current heap's size.
                heapSize--;
                Heapify(array, heapSize, 0);
            }
            return array;
        }

        /// <summary>
        /// This function is for heap's normalization at root of heap.
        /// </summary>
        private static void Heapify(int[] array, int heapSize, int index)
        {
            // Left and right indexes for current root.
            int leftIndex = (index + 1) * 2 - 1;
            int rightIndex = (index + 1) * 2;
            // The largest Index between them.
            int largestIndex = 0;

            // Comparison.
            if (leftIndex < heapSize && array[leftIndex] > array[index])
                largestIndex = leftIndex;
            else
                largestIndex = index;

            // Comparison.
            if (rightIndex < heapSize && array[rightIndex] > array[largestIndex])
                largestIndex = rightIndex;

            if (largestIndex != index)
            {
                // Swapping.
                int temp = array[index];
                array[index] = array[largestIndex];
                array[largestIndex] = temp;

                // Recursive call of this Function.
                Heapify(array, heapSize, largestIndex);
            }
        }
    }
}
