using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_QuickSort
{
    public class QuickSortEngine
    {
        //public void asdasdasdasd()
        //{
        //    int[] array = { 3, 7, 4, 4, 6, 5, 8 };
        //    QuickSort(array);

        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        public void QuickSort(ref int[] array)
        {
            QuickSort(array, 0, array.Length -1);
        }
        public static void QuickSort(int[] array, int left, int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2]; // >> 1 === /2 на побитовом уровне

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // swap
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i++;
                    j--;
                }
            }

            //recursive valls
            if (left < j)
            {
                QuickSort(array, left, j);
            }

            if (i < right)
            {
                QuickSort(array, i, right);
            }
        }
    }
}
