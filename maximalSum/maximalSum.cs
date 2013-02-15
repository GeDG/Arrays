using System;

class maximalSum
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        
        for (int i = n - 1; i >= n - k; i--)
        {
            Console.WriteLine(numbers[i]);    
        }
    }
}

