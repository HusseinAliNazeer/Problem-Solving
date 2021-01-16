import java.util.*;
public class Main {
 
    public static void main(String[] args) {
	// write your code here
        Scanner in = new Scanner(System.in);
        int [][] arr=new int[5][5];
        int r=0;
        int c=0;
        for(int i=0;i<arr.length;i++)
        {
            for(int j=0;j<arr.length;j++)
            {
                arr[i][j]=in.nextInt();
                if(arr[i][j]==1)
                {
                    r=i;
                    c=j;
                }
            }
        }
        r=Math.abs(r-2);
        c=Math.abs(c-2);
        System.out.println(r+c);
    }
}
