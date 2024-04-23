using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Sorting
    {

        class BubbleSorting
        {
            public void bubbleSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            BubbleSorting bubbleSorting = new BubbleSorting();
            

            int[] array = { 9, 7, 2, 3, 1, 4, 5, 6, 8 };

            bubbleSorting.bubbleSort(array);

            Console.WriteLine("Sorted array!");

            foreach (int nums in array)
            {
                Console.WriteLine(nums + " ");
            }

            Console.ReadKey();
        }
    }
}
