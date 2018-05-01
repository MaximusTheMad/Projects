//Author: Maxwell Winston
//Date Written: 2/29/16
//Time taken for LinkedList computeTo of a LinkedList of size 20: 159744 nanoseconds
//Time taken for ArrayDeque computeTo of a LinkedList of size 20: 218624 nanoseconds
//Not 100% accurate for every run-through, just time values of first run
//Limitations: Will not display proper percentage of primes for a max value of 2 or 3
//No Extra Credit Attempted


import java.util.ArrayDeque;
import java.util.Queue;


public class Sieve2 {
	Queue<Integer> first;
	Queue<Integer> primes;
	boolean called;
	int max;
	public Sieve2()
	{
		called=false;
	}
	
	public void computeTo2(int n)
	{
		long startTime=System.nanoTime();
		if(n<2)
		{
			throw new IllegalArgumentException("Please enter a value greater than or equal to 2");
		}
		else
		{
			max=n;
			first=new ArrayDeque<Integer>(n);
			primes=new ArrayDeque<Integer>(n);
			for(int i=2;i<=n;i++)
			{
				first.add(i);
			}
			int supprime;//Supposed prime
			
			do
			{
				Queue<Integer> temp = new ArrayDeque<Integer>();
				supprime=first.remove();
					primes.add(supprime);
					while(!first.isEmpty())
					{
						int prime2=first.remove();
						if(prime2%supprime!=0)
						{
							temp.add(prime2);
						}
					}
					if(!temp.isEmpty())
						first=temp;

		   }while(supprime<Math.sqrt(n));
		
		
		primes.addAll(first);
		called=true;
		long totalTime=System.nanoTime()-startTime;
		System.out.println("Total time for ArrayDeque: "+totalTime+ " nanoseconds");
		}
	}
	
	
	public void reportResults2()
	{
		if(!called)//checks to see if computeTo has been called first
		{
			throw new IllegalStateException("Call to reportResults was attempted without a call to computeTo");
		}
		else
		{
			int i=0;
			for(Integer temp : primes)
			{
				if(i%12==0)
					System.out.print("\n");
				System.out.print(temp + " ");
				i++;
				
			}
		}
	}
	
	public int getMax2()
	{
		if(!called)
		{
			throw new IllegalStateException("Call to getMax was attempted without a call to computeTo");
		}
		else
		{
			return max;
		}
		
	}
	
	public int getCount2()
	{
		if(!called)
		{
			throw new IllegalStateException("Call to getCount was attempted without a call to computeTo");
		}
		else
		{
			return primes.size();
		}
	}
}
