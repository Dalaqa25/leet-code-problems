using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class insertion
    {
        class Insertion
        {
            public void sortingInsertion(int[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > temp)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = temp;
                }
            }
        }



        static void Main(string[] args)
        {
            Insertion insertion = new Insertion();
            int[] array = { 3, 2, 1, 4, 5 };

            insertion.sortingInsertion(array);
            foreach (int nums in array)
            {
                Console.WriteLine(nums + " ");
            }

            Console.ReadKey();
        }
    }
}
