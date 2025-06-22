using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }
    }
}
