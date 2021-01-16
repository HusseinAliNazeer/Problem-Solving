
/* package whatever; // don't place package name! */

import java.util.*;
import java.lang.*;
import java.io.*;

/* Name of the class has to be "Main" only if the class is public. */
public class Ideone
{
	public static void main (String[] args) throws java.lang.Exception
	{
		// your code goes here
		Scanner input=new Scanner(System.in);
		int nItems=input.nextInt();
		long [] arr = new long[nItems];
		long sum=0;
		for(int i=0;i<nItems;i++)
		{
			arr[i]=input.nextLong();
			sum+=arr[i];
		}
		System.out.println(Math.abs(sum));
	}
}
