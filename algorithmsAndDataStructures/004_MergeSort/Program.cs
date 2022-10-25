using _004_MergeSort;

MergeSortEngine mergeSortEngine = new MergeSortEngine();

int[] array = { 3, 7, 4, 4, 6, 5, 8 };

mergeSortEngine.MergeSort(ref array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}