using System;


class readsTwoArraysAndCompare
{
    static void Main()
    {
        int[] arrOne = new int[5];
        int[] arrTwo = new int[5];
        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrTwo.Length; i++)
        {
            arrTwo[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrTwo.Length; i++)
        {
            if (arrOne[i] < arrTwo[i])
            {
                Console.Write(arrTwo[i]);
            }
            else 
            {
                Console.Write(arrOne[i]);
            }
        }
        Console.WriteLine();
}

