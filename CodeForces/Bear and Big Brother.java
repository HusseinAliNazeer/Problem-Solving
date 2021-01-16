import java.util.*;
public class Main {
 
    public static void main(String[] args) {
	// write your code here
        Scanner in = new Scanner(System.in);
        int li3=in.nextInt();
        int bob2=in.nextInt();
        int c=0;
        while(bob2>=li3)
        {
            c++;
            li3*=3;
            bob2*=2;
        }
        System.out.println(c);
    }
}
