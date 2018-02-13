using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    /// <summary>
    /// This Class Implements Bubble Sort Algorithm.
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// This Function is For Sorting Array.
        /// </summary>
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    // Compare array[j] and array[j + 1]
                    if (array[j] > array[j + 1])
                    {
                        // Swapping array[j] and array[j + 1].
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
