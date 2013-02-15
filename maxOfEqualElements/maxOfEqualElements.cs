using System;

class maxOfEqualElements
{
    static void Main()
    {
        int[] elements = new int[10];
        int[] elements2 = new int[15];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }
        
        int tmp = 0;
        int tmp2 = 0;
        
        for (int i = 0; i < elements.Length - 1; i++)
        {
            if (elements[i] == elements[i + 1])
            {
                tmp++;
                if (tmp > tmp2)
                {
                    tmp2 = tmp;
                    elements2[0] = elements[i];
                }
            }
            else
            {
                tmp = 0;
            }
        }
        tmp2 += 1; 
        for (int i = 1; i <= tmp2; i++)
        {
            elements2[i] = elements2[0];
            Console.Write(elements2[i] + " ");
        }
        Console.WriteLine("max sequence = " + tmp2);
    }
}
