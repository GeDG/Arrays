using System;

class remainingArraySortedIncreasingOrder
{
    static void Main()
    {       
        int[] arr = new int[] { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int[] newArr = arr; //{ 0, 1, 3, 3, 4, 4, 5, 6, 6 }
        int len = arr.Length;
        int j = 0;
        int k = 0 , tmp = 0;
        int[] result = new int[20];
        Array.Sort(newArr);

        for (int i = 0; i < len; i++)
        {
            while (j < len) 
            {
                if (newArr[i] == arr[j]) 
                {
                    result[k] = arr[j];
                    k++;
                }
                j++;
            }
        }


        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(result[i]);
        }

    }
}

