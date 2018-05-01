package shapes;

public abstract class Shape implements Comparable<Shape>{

	private String name;
	
	protected Shape(String nam)
	{
		name=nam;
	}
	protected abstract double area();
	
	public double getArea()
	{
		return this.area();
	}
	public int compareTo(Shape toComp) {
		if(this.getName().compareTo(toComp.getName())==0)
		{
			return Double.compare(this.area(), toComp.area());
		}
		return this.getName().compareTo(toComp.getName());
	}
	public String getName() {
		return name;
	}
}
