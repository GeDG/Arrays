using System;

class mergeSort
{
    static int[] MergeSort(int[] arr)
    {
        if (arr.Length == 1) {
            return arr;
        }
        

        int middle = arr.Length / 2;
        int[] left = new int[middle];
        
        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }
        
        int[] right = new int[arr.Length - middle];
        
        for (int i = 0; i < arr.Length - middle; i++)
        {
            right[i] = arr[i + middle];
        }
        
        left = MergeSort(left);
        right = MergeSort(right);

        int leftptr = 0;
        int rightptr = 0;

        int[] sorted = new int[arr.Length];
        for (int k = 0; k < arr.Length; k++)
        {
            if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
            {
                sorted[k] = left[leftptr];
                leftptr++;
            }
            else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
            {
                sorted[k] = right[rightptr];
                rightptr++;
            }
        }
        return sorted;
    }

    static void Main()
    {
        int[] arr = new int[] { 2, 4, 5, 45, 634, 645, 7, 56678, 4, 453, 4, 4, 12, 423, 5, 3, 423, 54 };

        arr = MergeSort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

