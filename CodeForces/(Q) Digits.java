import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
public class PJ {
    static boolean d=false;
    static boolean search(String s)
    {
        for(char c:s.toCharArray())
        {
            if(c=='7'||c=='4')
                continue;
            else
                return false;
        }
        d=true;
        return true ;
    }
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String  lines = br.readLine();
        String[] strs = lines.trim().split("\\s+");
        int [] a=new int[strs.length];
        for (int i = 0; i < strs.length; i++) {
            a[i] = Integer.parseInt(strs[i]);
        }
        int A=a[0];
        int B=a[1];
        int C=A;
        for(int i=0;i<=Math.abs(A-B);i++)
        {
 
            if(search(Integer.toString(C)))
            System.out.print(C+" ");
            C++;
        }
        if(!d)
            System.out.println(-1);
    }
}
