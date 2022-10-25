using _005_QuickSort;

QuickSortEngine quickSortEngine = new QuickSortEngine();

int[] array = { 3, 7, 4, 4, 6, 5, 8 };

quickSortEngine.QuickSort(ref array);

//quickSortEngine.asdasdasdasd();

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}