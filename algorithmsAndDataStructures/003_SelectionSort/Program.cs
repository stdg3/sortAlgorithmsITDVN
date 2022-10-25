using _003_SelectionSort;

SelectionSortEngine selectionSortEngine = new SelectionSortEngine();


int[] array = { 3, 7, 4, 4, 6, 5, 8 };
selectionSortEngine.SelectionSort(ref array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}