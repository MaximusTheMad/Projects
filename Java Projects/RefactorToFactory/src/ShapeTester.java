import java.util.ArrayList;
import java.util.Collections;

import shapes.Shape;
import shapes.ShapeFactory;


public class ShapeTester {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ShapeFactory sfactory= new ShapeFactory();
		ArrayList<Shape> listOfShapes=new ArrayList<Shape>();
		
		listOfShapes.add(sfactory.createShapeSquare("Square", 5));
		listOfShapes.add(sfactory.createShape2Par("Triangle", 6, 10));
		listOfShapes.add(sfactory.createShapeSquare("Square", 7));
		listOfShapes.add(sfactory.createShapeCircle("Circle", 6));
		listOfShapes.add(sfactory.createShape2Par("Rectangle", 6, 12));
		listOfShapes.add(sfactory.createShape2Par("Rectangle", 7, 4));
		listOfShapes.add(sfactory.createShapeCircle("Circle", 3));
		listOfShapes.add(sfactory.createShapeCircle("Circle", 2.75));
		listOfShapes.add(sfactory.createShape2Par("Triangle", 4.5, 7.3));
		System.out.println("Before sort:");
		for(Shape listContent: listOfShapes)
			System.out.println("Name: "+listContent.getName()+"		Area: "+(listContent.getArea())+" ");
		System.out.println("\n");
		Collections.sort(listOfShapes);
		System.out.println("After sort:");
		for(Shape listContent: listOfShapes)
			System.out.println("Name: "+listContent.getName()+"		Area: "+(listContent.getArea())+" ");
		
	}

}
