import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class PinewoodCar {

	
	
	private String identifier;
	private double surfaceAreaToAir;
	private double coefficientFriction=0.05;
	private double baseDragCoefficient=0.8;
	private double basePerimeter=0.06985*0.127;
	private double weightOfCar;
	private double trackAngle=30.0; //in degrees
	private double gravityAcceleration=9.81;
	private double curVelocity;
	private double accelerationWithoutFriction;
	private double accelerationWithFriction;
	private double frictionalForce;
	private double distanceTraveled;
	private double timeElapsed;
	private double airResistance;
	private double dragCoefficient;
	private final BufferedWriter _outfileExcel;
	/**
	 * 
	 * @param name - Identifier for the car
	 * @param mass - The mass of the car in kilograms (maximum .141748 kilograms(5 ounces) with a minimum of at least 60)
	 * @param length - Length of the car in meters(maximum 0.1778(7 inches) meters with a minimum of at least 0.1524(6 inches))
	 * @param width - Width of the car in meters(maximum 0.06985 meters (2.75 inches) with a minimum of at least 0.0254(1 inch))
	 * @param height - Height of the car in meters(maximum 0.127 meters (5 inches) with a minimum of 0.0254 meters(1 inch, rules dictate at least 3/8 inch clearance underneath the body but I prefer to keep it rounded) 
	 * @throws IOException 
	 */
	/**
	 * 
	 * @param name
	 * @param wOC
	 * @param length
	 * @param width
	 * @param height
	 * @param fC
	 * @param friction
	 * @param airResist
	 * @param fileName
	 * @throws IOException
	 */
	PinewoodCar(String name, double wOC, double length, double width, double height,double  fC, boolean friction, boolean airResist, String fileName) throws IOException
	{
		weightOfCar=wOC;
		coefficientFriction=fC;
		curVelocity=0.0;
		surfaceAreaToAir=width*height;
		dragCoefficient=baseDragCoefficient;
		System.out.println("Name: "+name+ "\tDrag Coefficient:" + dragCoefficient);
		identifier=name;
		//rampFriction=weightOfCar*Math.sin(Math.toRadians(trackAngle))*coefficientFriction;
		accelerationWithoutFriction=gravityAcceleration*Math.sin(Math.toRadians(trackAngle));
		distanceTraveled=0.0;
		frictionalForce=(coefficientFriction*gravityAcceleration*Math.cos(Math.toRadians(trackAngle)));
		accelerationWithFriction=(gravityAcceleration*Math.sin(Math.toRadians(trackAngle)))-frictionalForce;
	    _outfileExcel = new BufferedWriter(new FileWriter(fileName + ".csv"));
	    _outfileExcel.write("id,time,distance,velocity,acceleration,Frictional Force,airResistance\n");
	    if(!airResist&&!friction)
	    {
	    	_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+accelerationWithoutFriction+",0.0,0.0\n");
	    }
	    else if(!airResist&&friction)
	    {
	    	_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+accelerationWithFriction+","+frictionalForce+",0.0\n");
	    }
	    else if(airResist&&!friction)
	    {
	    	_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+accelerationWithoutFriction+",0.0,0.0\n");
	    }
	    else
	    {
	    	_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+accelerationWithoutFriction+","+frictionalForce+",0.0\n");
	    }
	    
	    
	}
	
	public void frictionlessStep(double timeStep) throws IOException
	{
		timeElapsed+=timeStep;
		double tempVel=curVelocity+(this.accelerationWithoutFriction*timeStep);
		double distanceTraveledInStep=(curVelocity*timeStep)+(0.5*this.accelerationWithoutFriction*Math.pow(timeStep, 2));
		distanceTraveled+=distanceTraveledInStep;
		curVelocity=tempVel;
		_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+accelerationWithoutFriction+",0.0,0.0\n");
	}
	public void frictionlessTransistion()
	{
		this.accelerationWithoutFriction=0.0;
	}
	public void frictionTransition()
	{
		this.accelerationWithFriction=0.0-(coefficientFriction*gravityAcceleration*Math.cos(Math.toRadians(0)));
	}
	public void frictionStep(double timeStep) throws IOException
	{
		timeElapsed+=timeStep;
		double tempVel=curVelocity+(this.accelerationWithFriction*timeStep);
		double distanceTraveledInStep=(curVelocity*timeStep)+(0.5*this.accelerationWithFriction*Math.pow(timeStep, 2));
		distanceTraveled+=distanceTraveledInStep;
		curVelocity=tempVel;
		_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+accelerationWithFriction+","+frictionalForce+",0.0\n");
	}
	public void airResitanceStep(double timeStep) throws IOException
	{
		timeElapsed+=timeStep;
		double acceleration=this.accelerationWithoutFriction-airResistance;
		double tempVel=curVelocity+(acceleration*timeStep);
		double distanceTraveledInStep=(curVelocity*timeStep)+(0.5*acceleration*Math.pow(timeStep, 2));
		distanceTraveled+=distanceTraveledInStep;
		this.airResistance=((0.5*1.292*this.dragCoefficient*this.surfaceAreaToAir*tempVel)/(this.weightOfCar/this.gravityAcceleration));
		curVelocity=tempVel;
		_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+acceleration+",0.0,"+airResistance+"\n");
	}
	public void frictionAndAirResitanceStep(double timeStep) throws IOException
	{
		timeElapsed+=timeStep;
		double acceleration=this.accelerationWithFriction-airResistance;
		double tempVel=curVelocity+(acceleration*timeStep);
		double distanceTraveledInStep=(curVelocity*timeStep)+(0.5*acceleration*Math.pow(timeStep, 2));
		distanceTraveled+=distanceTraveledInStep;
		this.airResistance=((0.5*1.292*this.dragCoefficient*this.surfaceAreaToAir*tempVel)/(this.weightOfCar/this.gravityAcceleration));
		curVelocity=tempVel;
		_outfileExcel.write(this.identifier+","+timeElapsed+","+distanceTraveled+","+curVelocity+","+acceleration+","+frictionalForce+","+airResistance+"\n");
	}
	public double getDistance()
	{
		return this.distanceTraveled;
	}
	
	public void terminate() throws IOException
	{
	      _outfileExcel.close();
	}
}
