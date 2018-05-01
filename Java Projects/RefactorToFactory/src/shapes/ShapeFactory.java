package shapes;

public class ShapeFactory {
	
	private Shape shape=null;
	
	public Shape createShapeSquare(String type, double length){
		if(type.equalsIgnoreCase("square"))
		{
			shape= new Square(type, length);
		}
		return shape;
	}
	public Shape createShape2Par(String type, double length, double width){
		if(type.equalsIgnoreCase("rectangle"))
		{
			shape=new Rectangle(type, length, width);
		}
		else if(type.equalsIgnoreCase("triangle"))
		{
			shape=new Triangle(type, length, width);
		}
		return shape;
	}
	
	public Shape createShapeCircle(String type, double radius)
	{
		if(type.equalsIgnoreCase("circle"))
			shape=new Circle(type, radius);
		
		return shape;
	}
	
	
}
