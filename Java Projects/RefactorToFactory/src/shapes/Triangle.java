package shapes;

class Triangle extends Shape {

	double base;
	double height;
	Triangle(String nam, double len, double tall) {
		super(nam);
		base=len;
		height=tall;
	}

	@Override
	protected double area() {
		return ((0.5)*(base)*(height));
	}

}
