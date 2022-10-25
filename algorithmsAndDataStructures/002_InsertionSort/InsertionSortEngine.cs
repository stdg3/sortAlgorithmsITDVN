using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_InsertionSort
{
    public class InsertionSortEngine
    {
        public void InsertionSort(ref int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex -1 ]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }
                sortedRangeEndIndex++;
            }
        }

        private static int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("index not found");
        }

        private static void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            int temp = itemArray[indexInsertingAt];
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            for (int current = indexInsertingFrom; current > indexInsertingFrom ; current++)
            {
                itemArray[current] = itemArray[current - 1];
            }

            itemArray[indexInsertingAt + 1] = temp;
        }

    }
}
