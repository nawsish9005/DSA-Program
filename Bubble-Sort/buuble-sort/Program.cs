using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the array is sorted
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 5, 3, 8, 4, 2 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        BubbleSort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }
}
