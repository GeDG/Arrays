using System;

class maxIncreasingSequence
{
    static void Main()
    {
        int[] numbers = new int[3, 2, 3, 4, 2, 2, 4, 3, 2, 3, 4, 2];
        int[] numbers2 = new int[5];
        int[] numbers3 = new int[5];
        int temp = 1;
        int temp2 = 1;
        Console.WriteLine("Numbers are " + numbers);
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == (numbers[i + 1] - 1))
            {
                temp++;
                if (temp > temp2)
                {
                    temp2 = temp;
                }
            }
            else
            {
                temp = 0;
            }
            numbers2.Length = temp2;
            if (numbers2.Length > numbers3.Length)
            {
                numbers3.Length = numbers2.Length;

            }
            numbers3[0] = numbers[i - temp2];
        }
        for (int i = 0; i < temp2; i++)
        {
            numbers3[i + 1] = numbers3[i] + 1;
        }
        Console.WriteLine("max sequence = " + numbers3);
    }
}

