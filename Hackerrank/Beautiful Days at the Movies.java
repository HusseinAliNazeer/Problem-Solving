import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k) {
             int [] arr= new int [Math.abs(i-j)+1];
        int [] revArr=new int [arr.length];
        int h=0;
        for (int itr=i;itr<=j;itr++)
        {
            arr[h]=itr;
            h++;
        }
        h=0;
        String s ="";
        for (int itr=i;itr<=j;itr++)
        {
            int m=arr[h];
            int l=String.valueOf(arr[h]).length();
            for(int i1=1;i1<=l;i1++)
            {
                int r=arr[h]%10;
                s+=Integer.toString(r);
                arr[h]/=10;
            }

            revArr[h]=Integer.parseInt(s);
            s="";
            arr[h]=m;
            h++;

        }

        int counter=0;
        for (int e =0;e<arr.length;e++)
        {
            if(Math.abs(arr[e]-revArr[e])%k==0)
                counter++;
        }

        return counter;



    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] ijk = scanner.nextLine().split(" ");

        int i = Integer.parseInt(ijk[0]);

        int j = Integer.parseInt(ijk[1]);

        int k = Integer.parseInt(ijk[2]);

        int result = beautifulDays(i, j, k);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
