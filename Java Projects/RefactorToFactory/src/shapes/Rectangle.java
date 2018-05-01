package shapes;

class Rectangle extends Shape {

	private double length;
	private double width;
	Rectangle(String nam, double len, double wid) {
		super(nam);
		length=len;
		width=wid;
		// TODO Auto-generated constructor stub
	}

	
	protected double area() {
		// TODO Auto-generated method stub
		return length*width;
	}

}
