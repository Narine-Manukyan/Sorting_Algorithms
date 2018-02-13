using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    /// <summary>
    /// This Class Implements Instertion Sort Algorithm.
    /// </summary>
    public static class InsertionSort
    {
        /// <summary>
        /// This Function is For Sorting Array.
        /// </summary>
        public static int[] Sort(int [] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                // Moving Elements of array[0]-array[i-1], which are greater than key,
                // to one position ahead of their current possition.
                while (j >= 0 && temp < array[j])
                {
                    // Swap array[j + 1] and array[j]
                    array[j + 1] = array[j];
                    // Decrement j by 1
                    j--;
                } 
                array[j + 1] = temp;
            }
            return array;
        }
    }
}
