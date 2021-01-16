import java.util.*;
public class Main {
 
    public static void main(String[] args) {
	// write your code here
        Scanner in = new Scanner(System.in);
        //store the input number
        int x=in.nextInt();
        //variable to store the last digit of number
        int reminder=0;
        //iterate the number until zero
        while (x!=0)
        {
            //store the digits of number
            reminder=x%10;
            //dived number to break the loop
            x/=10;
        }
        //check is the last digit is ODD or EVEN
        if(reminder%2==0)
            System.out.println("EVEN");
        else
            System.out.println("ODD");
        
    }
}
