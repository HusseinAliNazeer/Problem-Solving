import java.util.*;
import java.io.*;
public class Main {


    public static boolean checkPalindrom(int [] arr)
    {
        int j=arr.length-1;
        for(int i=0;i<arr.length/2;i++)
        {
            if(arr[i]!=arr[j])
                return false;
            j--;
        }
        return true;
    }


    public static void main(String[] args) throws IOException {
        // write your code here
        Scanner in = new Scanner(System.in);
        int n=in.nextInt();
        int [] arr= new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i]=in.nextInt();
        }
        if(checkPalindrom(arr))
            System.out.println("YES");
        else
            System.out.println("NO");

    }
}
