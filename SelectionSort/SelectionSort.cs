using System;


class SelectionSort
{
    static void Main()
    {
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int tmp,min;

        for (int j = 0; j < arr.Length - 1; j++){
            min = j;
            for (int k = j + 1; k < arr.Length; k++){
                if (arr[k] < arr[min]){
                    min = k;
                }
            }
 
            tmp = arr[min];
            arr[min] = arr[j];
            arr[j] = tmp;
        }

        for (int i = 0; i < arr.Length; i++)
			{
			    Console.Write(arr[i] + ", ");
			}
    }
}

