using System;


class ComparesTwoChar
{
    static void Main()
    {
        char[] arrOne = new char[5];
        char[] arrTwo = new char[5];
        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrTwo.Length; i++)
        {
            arrTwo[i] = char.Parse(Console.ReadLine());
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
}

