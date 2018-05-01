
public class LinkedQueue<T>
{

	private class Node<T>
	{
		private T data;
		private Node<T> next;
		
		public Node(T data, Node<T> next)
		{
			this.data=data;
			this.next=next;
		}
		
	}
	private Node<T> back;
	
	
	
	
	public boolean isEmpty()
	{
		return this.back==null;
	}
	
	public void enque(T data)
	{
		Node<T> temp=new Node<T>(data, null);
		if(isEmpty())
		{
			this.back=temp;
			temp.next=temp;
		}
		else
		{
			temp.next=this.back.next;
			this.back.next=temp;
			this.back=temp;
		}
	}
	
	public T deque()
	{
		if(isEmpty())
		{
			throw new IllegalStateException("Queue empty, cannot remove elements");
		}
		else
		{
			T temp=this.back.data;
			back=back.next;
			return temp;
		}
	}
}
