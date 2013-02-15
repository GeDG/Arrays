using System;

class quickSort
{
    static void quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
        int mid = (left + right) / 2;

        while (i <= j)
        {
            while (elements[i] < elements[mid])
            {
                i++;
            }

            while (elements[j] > elements[mid])
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            quicksort(elements, left, j);
        }

        if (i < right)
        {
            quicksort(elements, i, right);
        }
    }

    static void Main()
    {
        int[] arr = new int[] { 2, 4, 5, 45, 634, 645, 7, 56678, 4, 453, 4, 4, 12, 423, 5, 3, 423, 54 };

        quicksort(arr, 0, arr.Length - 1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

