package shapes;

class Square extends Shape {

	double length;
	
	Square(String nam, double len) {
		super(nam);
		length=len;
		// TODO Auto-generated constructor stub
	}

	@Override
	protected double area() {
		// TODO Auto-generated method stub
		return (Math.pow(length, 2));
	}

}
