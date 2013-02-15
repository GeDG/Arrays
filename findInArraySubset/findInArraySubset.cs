using System;

class findInArraySubset
{
    static void FindNumbers(long[] list, int index, long current, long goal, int elements, ref int howMany)
    {
        int element = 0;
        if (list.Length < index || elements < element)
            return;
        for (int i = index; i < list.Length; i++)
        {
            if (current + list[i] == goal)
            {
                howMany++;
                element++;
                if (list[i] <= 0)
                {
                    FindNumbers(list, i + 1, current + list[i], goal, elements, ref howMany);
                }
            }
            else if (list[i] <= 0 || current + list[i] < goal)
            {
                FindNumbers(list, i + 1, current + list[i], goal, elements, ref howMany);
            }
        }
    }

    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        long s = long.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());

        Array.Sort(numbers);
        int numberOfSubsets = 0;
        FindNumbers(numbers, 0, 0, s, k, ref numberOfSubsets);

        if(numberOfSubsets > 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
