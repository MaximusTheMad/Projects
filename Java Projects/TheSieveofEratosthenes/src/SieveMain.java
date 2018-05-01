//Author: Maxwell Winston
//Date Written: 2/29/16
//Time taken for LinkedList computeTo of a LinkedList of size 20: 159744 nanoseconds
//Time taken for ArrayDeque computeTo of a LinkedList of size 20: 218624 nanoseconds
//Not 100% accurate for every run-through, just time values of first run
//Limitations: Will not display proper percentage of primes for a max value of 2 or 3
//No Extra Credit Attempted
import java.util.*;

public class SieveMain {
    
    public static void main(String[] args) {
        System.out.println("This program computes all prime numbers up to a");
        System.out.println("maximum using the Sieve of Eratosthenes.");
        System.out.println();
        Scanner console = new Scanner(System.in);
        Sieve s = new Sieve();
        Sieve2 s2=new Sieve2();
        System.out.println("This part will use a LinkedList");
        displayMenu();
        int choice=console.nextInt();
        while(choice!=0)
        {
        	switch(choice)
        	{
        	case 0:
        		break;
        	case 1:	
        		try
        		{
        			System.out.print("Maximum n to compute (0 to quit)? ");
        			int max = console.nextInt();
        			System.out.println();
        			s.computeTo(max);
        		}
        		catch(IllegalArgumentException e)
        		{
        			e.printStackTrace();
        			break;
        		}
        		break;
        	case 2:
        		try
        		{
        			s.reportResults();
        		}
        		catch(IllegalStateException e)
        		{
        			e.printStackTrace();
        			break;
        		}
        		break;
        	case 3:
        		try
        		{
        		
        			int percent = s.getCount() * 100 / s.getMax();
        			System.out.println("\n% of primes = " + percent);
        			System.out.println();
        		}
        		catch(IllegalStateException e)
        		{
        			e.printStackTrace();
        			break;
        		}
        		break;
        	default:
        		System.out.println("Illegal value entered, please try again");
        		break;
        	}
        	displayMenu();
            choice=console.nextInt();
        }
        System.out.print("\n\nThis time, we'll use an ArrayDeque");
        displayMenu();
        choice=console.nextInt();
        while(choice!=0)
        {
        	switch(choice)
        	{
        	case 0:
        		break;
        	case 1:	
        		try
        		{
        			System.out.print("Maximum n to compute? ");
        			int max = console.nextInt();
        			System.out.println();
        			s2.computeTo2(max);
        		}
        		catch(IllegalArgumentException e)
        		{
        			e.printStackTrace();
        			break;
        		}
        		break;
        	case 2:
        		try
        		{
        			s2.reportResults2();
        		}
        		catch(IllegalStateException e)
        		{
        			e.printStackTrace();
        			break;
        		}
        		break;
        	case 3:
        		try
        		{
        		
        			double percent = s2.getCount2() * 100 / s2.getMax2();
        			System.out.println("\n% of primes = " + percent);
        			System.out.println();
        		}
        		catch(IllegalStateException e)
        		{
        			e.printStackTrace();
        			break;
        		}
        		break;
        	default:
        		System.out.println("Illegal value entered, please try again");
        		break;
        	}
        	displayMenu();
            choice=console.nextInt();
        }
        console.close();
    }
    
    private static void displayMenu()
    {
    	System.out.println("\n1. Enter a number and calculate the primes from 2 to that number(computeTo)");
    	System.out.println("2. Display the primes found (requires a call to computeTo)");
    	System.out.println("3. Display the what percent of the original list are primes(requires a call to computeTo)");
    	System.out.print("Enter your choice here(0 to quit): ");
    }

}