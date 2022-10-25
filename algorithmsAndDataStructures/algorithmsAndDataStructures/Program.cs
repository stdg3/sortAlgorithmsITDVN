using _001_BubbleSort;

int[] array = { 3, 7, 4, 4, 6, 5, 8 };

Console.WriteLine("before sort");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

BubbleSortEngine bubbleSort = new BubbleSortEngine();

bubbleSort.BubbleSort(ref array);

Console.WriteLine("after sort");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

