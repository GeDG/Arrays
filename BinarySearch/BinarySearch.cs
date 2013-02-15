using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = new int[] { 2, 4, 5, 67, 7, 8, 23, 1, 3, 123, 14, 32, 4, 534, 4};
        int first = 0;
        int last = arr.Length - 1;
        int mid;
        int key = int.Parse(Console.ReadLine());

        while (first <= last)
        {
            mid = (first + last) / 2;
            if (key > arr[mid])
            {
                last = mid - 1;
            }
            else if (key < arr[mid])
            {
                first = mid + 1;
            }
            else
            {
                Console.WriteLine(mid); break;
            } 
        }
    }
}

