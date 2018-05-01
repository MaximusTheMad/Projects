package shapes;

class Circle extends Shape {

		private double radius;
		Circle(String nam,double rad)
		{
			super(nam);
			radius=rad;
			area();
		}
		protected double area()
		{
			return (Math.PI*(Math.pow(radius, 2)));
		}
}
