using System;
using System.Collections.Generic;
class Permute	 
{ 
	private void swap (ref char a, ref char b)
	{
	    if(a==b)return;
	    a^=b;
	    b^=a;
	    a^=b;
	}
	public void setper(char[] list)
	{
	    int x=list.Length-1;
	    go(list,0,x);
	}

    private void go(char[] list, int k, int m)
    {
        int i;
        if (k == m)
        {
            Console.Write(list);
            Console.WriteLine(" ");
        }
        else
        {
            for (i = k; i <= m; i++)
            {
                swap(ref list[k], ref list[i]);
                go(list, k + 1, m);
                swap(ref list[k], ref list[i]);
            }
        }
    }
}
	 
public class allPermutations
{
    static void Main() 
	{
	 
	    Permute perm = new Permute();
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        string permArr = string.Join("", arr);

        char[] permCharArr = permArr.ToCharArray();

        perm.setper(permCharArr);
	}
}





