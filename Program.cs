using System;
using System.Collections.Generic;
using Lab3.SortingAlgorithms;
using System.Diagnostics;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = GenerateRandomIntList(1000, 500);
            //List<int> intList = GenerateNearlyOrderedIntList(1000, 500);
            //List<int> intList = GenerateReversedIntList(1000, 500);

            //int[] intArray = GenerateRandomIntArray(1000, 500);
            //int[] intArray = GenerateNearlyOrderedIntArray(1000, 500);
            int[] intArray = GenerateReversedIntArray(100000, 500000);

            TimeSpan totalTime = default(TimeSpan);
            TimeSpan averageTime = default(TimeSpan);


            //List<double> doubleList = GenerateRandomDoubleList(100, 500);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));


            /*BubbleSort<int> bubbleSort = new BubbleSort<int>();
            Console.WriteLine("BUBBLE SORT");

            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original array

                totalTime += TimeSort<int>(bubbleSort, intListCopy);
            }

            averageTime = totalTime / 11;
            Console.WriteLine($"{averageTime}");*/


            /*
                        InsertionSort<int> insertionSort = new InsertionSort<int>();
                        Console.WriteLine("INSERTION SORT");
                        totalTime = 0;

                        for (int i = 0; i < 11; i++)
                        {
                            List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                            totalTime += TimeSort<int>(insertionSort, intListCopy);
                        }

                        averageTime = totalTime / 11;
                        Console.WriteLine($"{averageTime}");
            */

            /*
            BucketSort bucketSort = new BucketSort();
            Console.WriteLine("BUCKET SORT");
            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                totalTime += TimeSort(bucketSort, intListCopy);
            }

            averageTime = totalTime / 11;
            Console.WriteLine($"Average time: {averageTime}");*/


            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));


            //bubbleSort.Sort(ref intListCopy);

            //BucketSort<int> bucketSort = new BucketSort<int>();
            //bucketSort.Sort(ref intListCopy);

            //HeapSort<int> heapSort = new HeapSort<int>();
            //heapSort.Sort(ref intList);

            /*MergeSort<int> MergeSort = new MergeSort<int>();
            Console.WriteLine("MERGE SORT");
            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                totalTime += TimeSort<int>(MergeSort, intListCopy);
            }

            averageTime = totalTime / 11;
            Console.WriteLine($"{averageTime}");*/

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //insertionSort.Sort(ref intList);

            //SelectionSort<int> selectionSort = new SelectionSort<int>();
            //selectionSort.Sort(ref intList);

            //quickSort.Sort(ref intList);
            //QuickSort<double> quickSortDouble = new QuickSort<double>();
            //quickSortDouble.Sort(ref doubleList);

            //TreeSort<int> treeSort = new TreeSort<int>();
            //treeSort.Sort(ref intList);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));

            //Console.WriteLine("QUICKSORT");
            //QuickSort<int> quickSort = new QuickSort<int>();
            //for( int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //    TimeSort(quickSort, intListCopy);
            //}

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //    TimeSort(mergeSort, intListCopy);
            //}

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(mergeSort, intListCopy);

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(insertionSort, intListCopy);

            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(bubbleSort, intListCopy);

            RadixSort RadixSort = new RadixSort();
            Console.WriteLine("RADIX SORT");
            totalTime = default(TimeSpan);

            for (int i = 0; i < 11; i++)
            {
                int[] intListCopy = intArray;   // make a copy of the original unsorted array

                // start timer
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                RadixSort.Sort(intListCopy);
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Console.WriteLine(ts);
                totalTime = stopWatch.Elapsed;
            }

            averageTime = totalTime / 11;
            Console.WriteLine($"Average: {averageTime}");
        }

        public static double TimeSort<T>(ISortable<T> sortable, List<T> items) where T : IComparable<T>
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(ref items);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;

        }

        public static double TimeSort(ISortableInt sortable, List<int> items)
        {
            int[] array = items.ToArray();

            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var sorted = sortable.Sort(array);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);


            return ts.TotalSeconds;
        }


        public static List<int> GenerateRandomIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for(int i=0; i < length; i++)
            {
                list.Add(random.Next(maxValue));               
            }

            return list;
        }

        public static List<double> GenerateRandomDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.NextDouble()* maxValue);
            }

            return list;
        }

        public static List<int> GenerateNearlyOrderedIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for(int i = 0; i < length; i++)
            {
                list.Add(i);
            }

            for(int i = 0; i < length / 40; i++)
            {
                int randomPos1 = random.Next(length);
                int randomPos2 = random.Next(length);
                int randomInt1 = list[randomPos1];
                int randomInt2 = list[randomPos2];

                list[randomPos1] = randomInt1;
                list[randomPos2] = randomInt2;
            }
            return list;
        }

        public static List<double> GenerateNearlyOrderedDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < length / 40; i++)
            {
                int randomPos1 = random.Next(length);
                int randomPos2 = random.Next(length);
                double randomDouble1 = list[randomPos1];
                double randomDouble2 = list[randomPos2];

                list[randomPos1] = randomDouble1;
                list[randomPos2] = randomDouble2;
            }
            return list;
        }

        public static List<int> GenerateReversedIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            for(int i = length; i > 0; i--)
            {
                list.Add(i);
            }
            return list;
        }

        public static List<double> GenerateReversedDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            for (int i = length; i > 0; i--)
            {
                list.Add(i);
            }
            return list;
        }
        public static int[] GenerateRandomIntArray(int length, int maxValue)
        {
            int[] array = new int[length];

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(maxValue);
            }

            return array;
        }
        public static int[] GenerateNearlyOrderedIntArray(int length, int maxValue)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < length / 40; i++)
            {
                int randomPos1 = random.Next(length);
                int randomPos2 = random.Next(length);
                int randomInt1 = array[randomPos1];
                int randomInt2 = array[randomPos2];

                array[randomPos1] = randomInt1;
                array[randomPos2] = randomInt2;
            }
            return array;
        }

        public static int[] GenerateReversedIntArray(int length, int maxValue)
        {
            int[] array = new int[length];

            for (int i = length - 1; i > 0; i--)
            {
                array[i] = length - i;
            }

            return array;
        }

    }
}
