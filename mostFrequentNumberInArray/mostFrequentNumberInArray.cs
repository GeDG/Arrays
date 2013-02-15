using System;

class mostFrequentNumberInArray
{
    static void Main()
    {
        int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Array.Sort(arr);
        int Br = 1;
        int current = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[current])
                Br++;
            else
                Br--;

            if (Br == 0)
            {
                current = i;
                Br = 1;
            }
        }
        Console.WriteLine(arr[current]);
    }
}

