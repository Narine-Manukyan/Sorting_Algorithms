using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        /// <summary>
        /// Function for Showing Array elements.
        /// </summary>
        public static void ShowArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Function for Copiing array.
        public static int[] CopyArray(int[] array)
        {
            int[] arrayCopy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }
            return arrayCopy;
        }

        static void Main(string[] args)
        {
            // Asking the user to enter size of an array that must be sorted. 
            Console.WriteLine("Please enter the size of an array that you want to sort: ");
            int size = int.Parse(Console.ReadLine());

            // For a given size the program generates an array with random number and shows it.
            Random randomNumber = new Random();
            int[] array = new int[size];
            Console.WriteLine("\nGenerated Array: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = randomNumber.Next(0, 100);
            }
            ShowArray(array);

            // The program prompts the user to choose the algorithm.
            Console.WriteLine("\nSelect which algorithm you want to perform: ");
            Console.WriteLine("1. Bubble sort\n" +
                "2. Insertion sort\n3. Quick sort\n4. Heap sort\n5. Merge sort\n6. All");
            string answer = Console.ReadLine();

            // Array for various answers.
            string[] answers;

            // If Input Contains , then...
            if (answer.IndexOf(',') != -1)
            {
                answers = answer.Split(',');
            }
            // If Input is Range of Numbers...
            else if (answer.IndexOf('-') != -1)
            {
                answers = new string[int.Parse(answer[2].ToString()) - int.Parse(answer[0].ToString()) + 1];
                int j = int.Parse(answer.Split('-')[0]);
                for (int i = 0; i < answers.Length; i++)
                {
                    answers[i] = (j++).ToString();
                }
            }
            // If User Choosae All algorithms...
            else if (answer == "6") 
            {
                answers = new string[5];
                for (int i = 0; i < answers.Length; i++)
                {
                    answers[i] = (i + 1).ToString();
                }
            }
            // If Input is number...
            else
            {
                answers = new string[1];
                answers[0] = answer;
            }

            // For Deciding Fastest Runtime.
            long fastTime = Int64.MaxValue;
            // For Description of fastest Algorithm.
            string fastestAlgorithm = null;
            for (int i = 0; i < answers.Length; i++)
            {
                
                // Switch cases for user's answer.
                switch (answers[i])
                {
                    case "1":
                        // Bubble Sort
                        // For measure the execution time of a method.
                        Stopwatch sw1 = Stopwatch.StartNew();
                        // For calculating total memory.
                        int memoryUsage1 = array.Length * 4;

                        // Copy main array and Sort it.
                        int[] array1 = CopyArray(array);
                        array1 = BubbleSort.Sort(array1);

                        // Stop execution.
                        sw1.Stop();
                        long runtime1 = sw1.ElapsedMilliseconds;

                        // Showing sorted Array.
                        Console.WriteLine("\nSorted Array(Bubble): ");
                        ShowArray(array1);
                        Console.WriteLine("Running Time  With Milliseconds: " + runtime1
                            + "\nMemory Usage With Bytes: " + memoryUsage1);

                        // Decide fast executing time.
                        if (runtime1 < fastTime)
                        {
                            fastTime = runtime1;
                            fastestAlgorithm = "Bubble Sort\nRunning Time: " + runtime1 + 
                                "\nMemory Usage: " + memoryUsage1;
                        }
                        break;
                    case "2":
                        // Insertion Sort
                        // For measure the execution time of a method.
                        Stopwatch sw2 = Stopwatch.StartNew();
                        // For calculating total memory.
                        int memoryUsage2 = array.Length * 4;

                        // Copy main array and Sort it.
                        int[] array2 = CopyArray(array);
                        array2 = InsertionSort.Sort(array2);

                        // Stop execution.
                        sw2.Stop();
                        long runtime2 = sw2.ElapsedMilliseconds;

                        // Showing sorted Array.
                        Console.WriteLine("\nSorted Array(Insertion): ");
                        ShowArray(array2);
                        Console.WriteLine("Running Time  With Milliseconds: " + runtime2
                            + "\nMemory Usage With Bytes: " + memoryUsage2);

                        // Decide fast executing time.
                        if (runtime2 < fastTime)
                        {
                            fastTime = runtime2;
                            fastestAlgorithm = "Insertion Sort\nRunning Time: " + runtime2 + 
                                "\nMemory Usage: " + memoryUsage2;
                        }
                        break;
                    case "3":
                        // Quick Sort
                        // For measure the execution time of a method.
                        Stopwatch sw3 = Stopwatch.StartNew();
                        // For calculating total memory.
                        int memoryUsage3 = array.Length * 4;

                        // Copy main array and Sort it.
                        int[] array3 = CopyArray(array);
                        array3 = QuickSort.Sort(array3);

                        // Stop execution.
                        sw3.Stop();
                        long runtime3 = sw3.ElapsedMilliseconds;
                        memoryUsage3 += QuickSort.usedMemory;

                        // Showing sorted Array.
                        Console.WriteLine("\nSorted Array(Quick): ");
                        ShowArray(array3);
                        Console.WriteLine("Running Time  With Milliseconds: " + runtime3
                            + "\nMemory Usage With Bytes: " + memoryUsage3);

                        // Decide fast executing time.
                        if (runtime3 < fastTime)
                        {
                            fastTime = runtime3;
                            fastestAlgorithm = "Quick Sort\nRunning Time: " + runtime3 +
                                "\nMemory Usage: " + memoryUsage3;
                        }
                        break;
                    case "4":
                        // Heap Sort
                        // For measure the execution time of a method.
                        Stopwatch sw4 = Stopwatch.StartNew();
                        // For calculating total memory.
                        int memoryUsage4 = array.Length * 4;

                        // Copy main array and Sort it.
                        int[] array4 = CopyArray(array);
                        array4 = HeapSort.Sort(array4);

                        // Stop execution.
                        sw4.Stop();
                        long runtime4 = sw4.ElapsedMilliseconds;

                        // Showing sorted Array.
                        Console.WriteLine("\nSorted Array(Heap): ");
                        ShowArray(array4);
                        Console.WriteLine("Running Time  With Milliseconds: " + runtime4
                            + "\nMemory Usage With Bytes: " + memoryUsage4);

                        //Decide fast executing time.
                        if (runtime4 < fastTime)
                        {
                            fastTime = runtime4;
                            fastestAlgorithm = "Heap Sort\nRunning Time: " + runtime4 +
                                "\nMemory Usage: " + memoryUsage4;
                        }
                        break;
                    case "5":
                        // Merge Sort
                        // For measure the execution time of a method.
                        Stopwatch sw5 = Stopwatch.StartNew();
                        // For calculating total memory.
                        int memoryUsage5 = array.Length * 4;

                        // Copy main array and Sort it.
                        int[] array5 = CopyArray(array);
                        array5 = MergeSort.Sort(array5);

                        // Stop execution.
                        sw5.Stop();
                        long runtime5 = sw5.ElapsedMilliseconds;
                        memoryUsage5 += MergeSort.usedMemory;

                        // Showing sorted Array.
                        Console.WriteLine("\nSorted Array(Merge): ");
                        ShowArray(array5);
                        Console.WriteLine("Running Time  With Milliseconds: " + runtime5
                            + "\nMemory Usage With Bytes: " + memoryUsage5);

                        // Decide fast executing time.
                        if (runtime5 < fastTime)
                        {
                            fastTime = runtime5;
                            fastestAlgorithm = "Merge Sort\nRunning Time: " + runtime5 +
                                "\nMemory Usage: " + memoryUsage5;
                        }
                        break;
                    default:
                        throw new Exception("Unknown component type");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFastest Algorithm:\n" + fastestAlgorithm);
            Console.ResetColor();
        }
    }
}
