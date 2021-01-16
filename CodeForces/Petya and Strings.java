import java.lang.reflect.Array;
import java.util.*;
public class Main {
 
    public static  int isEqual(char [] arr1, char [] arr2)
    {
        for(int i=0;i<arr1.length;i++)
        {
            if(arr1[i]<arr2[i])
            {
               return -1;
            }
            else if(arr1[i]>arr2[i])
            {
               return 1;
            }
 
        }
        return 0;
    }
 
    public static void main(String[] args) {
	// write your code here
        Scanner in = new Scanner(System.in);
        String s1=in.nextLine().toLowerCase();
        String s2=in.nextLine().toLowerCase();
        char [] ch1=s1.toCharArray();
        char [] ch2=s2.toCharArray();
        int result=isEqual(ch1,ch2);
        System.out.println(result);
 
    }
}
