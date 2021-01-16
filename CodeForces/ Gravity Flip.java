import java.lang.reflect.Array;
import java.util.*;
public class Main {
 
    public static void main(String[] args) {
	// write your code here
        Scanner in = new Scanner(System.in);
        int n=in.nextInt();
        int [] arr=new int[n];
        for(int i=0;i<arr.length;i++)
        {
            arr[i]=in.nextInt();
        }
        Arrays.sort(arr);
        for(int i=0;i<arr.length;i++)
        {
            System.out.println(arr[i]);
        }
    }
}
