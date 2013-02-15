using System;

class indexMultiplyByFive
{
    static void Main()
    {
        int[] arr = new int(20);
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
        }

        Console.WriteLine(arr.ToString());
    }
}

