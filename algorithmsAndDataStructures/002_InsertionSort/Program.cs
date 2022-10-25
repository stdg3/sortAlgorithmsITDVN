
using _002_InsertionSort;


int[] array = {3, 7, 4, 4, 6, 5, 8 };
InsertionSortEngine insertionSortEngine = new InsertionSortEngine();
insertionSortEngine.InsertionSort(ref array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
