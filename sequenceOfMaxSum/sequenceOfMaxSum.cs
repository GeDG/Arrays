using System;

class sequenceOfMaxSum
{
    static void Main()
    {
        int[] arr = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int end = 0, start = 0;
        int maxSum = 0, sum = 0;
        int tmpStart = 0;

        for (int i = 0; i < arr.Length; ++i)
        {
            sum += arr[i];

            if (sum > maxSum || (sum == maxSum && (end - start) < (i - tmpStart)))
            {
                maxSum = sum;
                start = tmpStart;
                end = i;
            }
            if (sum < 0)
            {
                sum = 0;
                tmpStart = i + 1;
            }
        }

        for (int j = start; j <= end; j++)
        {
            Console.Write(arr[j] + " ,");
        }
    }
}
