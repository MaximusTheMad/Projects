import java.io.IOException;

public class Main {

	public static void main(String[] args) throws IOException {
		int testNum=1;
		while (testNum<=6){
		
		switch(testNum)
		{
		case 1:
			frictionAndAirResistanceWithDifferentWeights();
			break;
		case 2:
			frictionAndAirResistanceWithDifferentFriction();
			break;
		case 3:
			frictionAndAirResistanceWithDifferentDimensions();
			break;
		case 4:
			frictionWithDifferentFrictionCoefficients();
			break;
		case 5:
			airResitanceWithDifferentWeights();
			break;
		case 6:
			airResitanceWithDifferentDimensions();
			break;
		}
			testNum++;
		}

	}
	
	private static void airResitanceWithDifferentDimensions() throws IOException {
		double distance = 0;
		PinewoodCar baseCar0=new PinewoodCar("carARHWBase",.100,0.1778,0.06985,0.127,0.05, true, true, "carARHWBase");
		PinewoodCar car1=new PinewoodCar("carARH0.122",.100,0.1778,0.06985,0.122,0.05, true, true, "carARH0_122");
		PinewoodCar car2=new PinewoodCar("carARH0.117",.100,0.1778,0.06985,0.117,0.05, true, true, "carARH0_117");
		PinewoodCar car3=new PinewoodCar("carARH0.112",.100,0.1778,0.06985,0.112,0.05, true, true, "carARH0_112");
		PinewoodCar car4=new PinewoodCar("carARH0.107",.100,0.1778,0.06985,0.107,0.05, true, true, "carARH0_107");
		PinewoodCar car5=new PinewoodCar("carARH0.102",.100,0.1778,0.06985,0.102,0.05, true, true, "carARH0_102");
		PinewoodCar car6=new PinewoodCar("carARW0.06485",.100,0.1778,0.06485,0.127,0.05,true, true, "carARW0_06485");
		PinewoodCar car7=new PinewoodCar("carARW0.05985",.100,0.1778,0.05985,0.127,0.05, true, true, "carARW0_05985");
		PinewoodCar car8=new PinewoodCar("carARW0.05485",.100,0.1778,0.05485,0.127,0.05, true, true, "carARW0_05485");
		PinewoodCar car9=new PinewoodCar("carARW0.04985",.100,0.1778,0.04985,0.127,0.05, true, true, "carARW0_04985");
		PinewoodCar car10=new PinewoodCar("carARW0.04485",.100,0.1778,0.04485,0.127,0.05, true, true, "carARW0_04485");
		do
		{
			baseCar0.airResitanceStep(0.001);
			distance=baseCar0.getDistance();
		}while(distance<2.5);
		baseCar0.frictionTransition();
		do
		{
			baseCar0.airResitanceStep(0.001);
			distance=baseCar0.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		baseCar0.terminate();
		
		do
		{
			car1.airResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<2.5);
		car1.frictionTransition();
		do
		{
			car1.airResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		car1.terminate();
		do
		{
			car2.airResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<2.5);
		car2.frictionTransition();
		do
		{
			car2.airResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car2.terminate();
		do
		{
			car3.airResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<2.5);
		car3.frictionTransition();
		do
		{
			car3.airResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<6.5);
		distance=0;
		car3.terminate();
		do
		{
			car4.airResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<2.5);
		car4.frictionTransition();
		do
		{
			car4.airResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car4.terminate();
		do
		{
			car5.airResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<2.5);
		car5.frictionTransition();
		do
		{
			car5.airResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<6.5);
		distance=0;
		car5.terminate();
		do
		{
			car6.airResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<2.5);
		car6.frictionTransition();
		do
		{
			car6.airResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<6.5);
		car6.terminate();
		distance=0;
		do
		{
			car7.airResitanceStep(0.001);
			distance=car7.getDistance();
		}while(distance<2.5);
		car7.frictionTransition();
		do
		{
			car7.airResitanceStep(0.001);
			distance=car7.getDistance();
		}while(distance<6.5);
		car7.terminate();
		distance=0;
		do
		{
			car8.airResitanceStep(0.001);
			distance=car8.getDistance();
		}while(distance<2.5);
		car8.frictionTransition();
		do
		{
			car8.airResitanceStep(0.001);
			distance=car8.getDistance();
		}while(distance<6.5);
		car8.terminate();
		distance=0;
		do
		{
			car9.airResitanceStep(0.001);
			distance=car9.getDistance();
		}while(distance<2.5);
		car9.frictionTransition();
		do
		{
			car9.airResitanceStep(0.001);
			distance=car9.getDistance();
		}while(distance<6.5);
		car9.terminate();
		distance=0;
		do
		{
			car10.airResitanceStep(0.001);
			distance=car10.getDistance();
		}while(distance<2.5);
		car10.frictionTransition();
		do
		{
			car10.airResitanceStep(0.001);
			distance=car10.getDistance();
		}while(distance<6.5);
		car10.terminate();
		
	}

	private static void airResitanceWithDifferentWeights() throws IOException {
		double distance = 0;
		PinewoodCar car1=new PinewoodCar("carAR100g",.100,0.1778,0.06985,0.127,0.05, false, true, "carAR100g");
		PinewoodCar car2=new PinewoodCar("carAR105g",.105,0.1778,0.06985,0.127,0.05, false, true, "carAR105g");
		PinewoodCar car3=new PinewoodCar("carAR110g",.110,0.1778,0.06985,0.127,0.05, false, true, "carAR110g");
		PinewoodCar car4=new PinewoodCar("carAR115g",.115,0.1778,0.06985,0.127,0.05,false, true, "carAR115g");
		PinewoodCar car5=new PinewoodCar("carAR120g",.120,0.1778,0.06985,0.127,0.05, false, true, "carAR120g");
		PinewoodCar car6=new PinewoodCar("carAR125g",.125,0.1778,0.06985,0.127,0.05, false, true, "carAR125g");
		do
		{
			car1.airResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<2.5);
		car1.frictionTransition();
		do
		{
			car1.airResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		car1.terminate();
		do
		{
			car2.airResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<2.5);
		car2.frictionTransition();
		do
		{
			car2.airResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car2.terminate();
		do
		{
			car3.airResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<2.5);
		car3.frictionTransition();
		do
		{
			car3.airResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<6.5);
		distance=0;
		car3.terminate();
		do
		{
			car4.airResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<2.5);
		car4.frictionTransition();
		do
		{
			car4.airResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car4.terminate();
		do
		{
			car5.airResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<2.5);
		car5.frictionTransition();
		do
		{
			car5.airResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<6.5);
		distance=0;
		car5.terminate();
		do
		{
			car6.airResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<2.5);
		car6.frictionTransition();
		do
		{
			car6.airResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<6.5);
		car6.terminate();
		
	}

	private static void frictionWithDifferentFrictionCoefficients() throws IOException {
		double distance = 0;
		PinewoodCar car1=new PinewoodCar("carF_05",.100,0.1778,0.06985,0.127,0.05, true, false, "carF_05");
		PinewoodCar car2=new PinewoodCar("carF_045",.100,0.1778,0.06985,0.127,0.045, true, false, "carF_045");
		PinewoodCar car3=new PinewoodCar("carF_04",.100,0.1778,0.06985,0.127,0.04, true, false, "carF_04");
		PinewoodCar car4=new PinewoodCar("carF_035",.100,0.1778,0.06985,0.127,0.035, true, false, "carF_035");
		PinewoodCar car5=new PinewoodCar("carF_030",.100,0.1778,0.06985,0.127,0.030, true, false, "carF_030");
		PinewoodCar car6=new PinewoodCar("carF_025",.100,0.1778,0.06985,0.127,0.025, true, false, "carF_025");
		do
		{
			car1.frictionStep(0.001);
			distance=car1.getDistance();
		}while(distance<2.5);
		car1.frictionTransition();
		do
		{
			car1.frictionStep(0.001);
			distance=car1.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		car1.terminate();
		do
		{
			car2.frictionStep(0.001);
			distance=car2.getDistance();
		}while(distance<2.5);
		car2.frictionTransition();
		do
		{
			car2.frictionStep(0.001);
			distance=car2.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car2.terminate();
		do
		{
			car3.frictionStep(0.001);
			distance=car3.getDistance();
		}while(distance<2.5);
		car3.frictionTransition();
		do
		{
			car3.frictionStep(0.001);
			distance=car3.getDistance();
		}while(distance<6.5);
		distance=0;
		car3.terminate();
		do
		{
			car4.frictionStep(0.001);
			distance=car4.getDistance();
		}while(distance<2.5);
		car4.frictionTransition();
		do
		{
			car4.frictionStep(0.001);
			distance=car4.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car4.terminate();
		do
		{
			car5.frictionStep(0.001);
			distance=car5.getDistance();
		}while(distance<2.5);
		car5.frictionTransition();
		do
		{
			car5.frictionStep(0.001);
			distance=car5.getDistance();
		}while(distance<6.5);
		distance=0;
		car5.terminate();
		do
		{
			car6.frictionStep(0.001);
			distance=car6.getDistance();
		}while(distance<2.5);
		car6.frictionTransition();
		do
		{
			car6.frictionStep(0.001);
			distance=car6.getDistance();
		}while(distance<6.5);
		car6.terminate();
		
	}

	private static void frictionAndAirResistanceWithDifferentWeights() throws IOException
	{
		double distance = 0;
		PinewoodCar car1=new PinewoodCar("carFAR100",.100,0.1778,0.06985,0.127,0.05, true, true, "carFAR100");
		PinewoodCar car2=new PinewoodCar("carFAR105",.105,0.1778,0.06985,0.127,0.05, true, true, "carFAR105");
		PinewoodCar car3=new PinewoodCar("carFAR110",.110,0.1778,0.06985,0.127,0.05, true, true, "carFAR110");
		PinewoodCar car4=new PinewoodCar("carFAR115",.115,0.1778,0.06985,0.127,0.05,true, true, "carFAR115");
		PinewoodCar car5=new PinewoodCar("carFAR120",.120,0.1778,0.06985,0.127,0.05, true, true, "carFAR120");
		PinewoodCar car6=new PinewoodCar("carFAR125",.125,0.1778,0.06985,0.127,0.05, true, true, "carFAR125");
		do
		{
			car1.frictionAndAirResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<2.5);
		car1.frictionTransition();
		do
		{
			car1.frictionAndAirResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		car1.terminate();
		do
		{
			car2.frictionAndAirResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<2.5);
		car2.frictionTransition();
		do
		{
			car2.frictionAndAirResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car2.terminate();
		do
		{
			car3.frictionAndAirResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<2.5);
		car3.frictionTransition();
		do
		{
			car3.frictionAndAirResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<6.5);
		distance=0;
		car3.terminate();
		do
		{
			car4.frictionAndAirResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<2.5);
		car4.frictionTransition();
		do
		{
			car4.frictionAndAirResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car4.terminate();
		do
		{
			car5.frictionAndAirResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<2.5);
		car5.frictionTransition();
		do
		{
			car5.frictionAndAirResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<6.5);
		distance=0;
		car5.terminate();
		do
		{
			car6.frictionAndAirResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<2.5);
		car6.frictionTransition();
		do
		{
			car6.frictionAndAirResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<6.5);
		car6.terminate();
		
		
	}
	private static void frictionAndAirResistanceWithDifferentFriction() throws IOException
	{
		double distance = 0;
		PinewoodCar car1=new PinewoodCar("carFAR_05",.100,0.1778,0.06985,0.127,0.05, true, true, "carFAR_05");
		PinewoodCar car2=new PinewoodCar("carFAR_045",.100,0.1778,0.06985,0.127,0.045, true, true, "carFAR_045");
		PinewoodCar car3=new PinewoodCar("carFAR_04",.100,0.1778,0.06985,0.127,0.04, true, true, "carFAR_04");
		PinewoodCar car4=new PinewoodCar("carFAR_035",.100,0.1778,0.06985,0.127,0.035, true, true, "carFAR_035");
		PinewoodCar car5=new PinewoodCar("carFAR_030",.100,0.1778,0.06985,0.127,0.030, true, true, "carFAR_030");
		PinewoodCar car6=new PinewoodCar("carFAR_025",.100,0.1778,0.06985,0.127,0.025, true, true, "carFAR_025");
		do
		{
			car1.frictionAndAirResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<2.5);
		car1.frictionTransition();
		do
		{
			car1.frictionAndAirResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		car1.terminate();
		do
		{
			car2.frictionAndAirResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<2.5);
		car2.frictionTransition();
		do
		{
			car2.frictionAndAirResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car2.terminate();
		do
		{
			car3.frictionAndAirResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<2.5);
		car3.frictionTransition();
		do
		{
			car3.frictionAndAirResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<6.5);
		distance=0;
		car3.terminate();
		do
		{
			car4.frictionAndAirResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<2.5);
		car4.frictionTransition();
		do
		{
			car4.frictionAndAirResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car4.terminate();
		do
		{
			car5.frictionAndAirResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<2.5);
		car5.frictionTransition();
		do
		{
			car5.frictionAndAirResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<6.5);
		distance=0;
		car5.terminate();
		do
		{
			car6.frictionAndAirResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<2.5);
		car6.frictionTransition();
		do
		{
			car6.frictionAndAirResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<6.5);
		car6.terminate();
		
		
	}
	
	private static void frictionAndAirResistanceWithDifferentDimensions() throws IOException
	{
		double distance = 0;
		PinewoodCar baseCar0=new PinewoodCar("carFARHWBase",.100,0.1778,0.06985,0.127,0.05, true, true, "carFARHWBase");
		PinewoodCar car1=new PinewoodCar("carFARH0.122",.100,0.1778,0.06985,0.122,0.05, true, true, "carFARH0_122");
		PinewoodCar car2=new PinewoodCar("carFARH0.117",.100,0.1778,0.06985,0.117,0.05, true, true, "carFARH0_117");
		PinewoodCar car3=new PinewoodCar("carFARH0.112",.100,0.1778,0.06985,0.112,0.05, true, true, "carFARH0_112");
		PinewoodCar car4=new PinewoodCar("carFARH0.107",.100,0.1778,0.06985,0.107,0.05, true, true, "carFARH0_107");
		PinewoodCar car5=new PinewoodCar("carFARH0.102",.100,0.1778,0.06985,0.102,0.05, true, true, "carFARH0_102");
		PinewoodCar car6=new PinewoodCar("carFARW0.06485",.100,0.1778,0.06485,0.127,0.05,true, true, "carFARW0_06485");
		PinewoodCar car7=new PinewoodCar("carFARW0.05985",.100,0.1778,0.05985,0.127,0.05, true, true, "carFARW0_05985");
		PinewoodCar car8=new PinewoodCar("carFARW0.05485",.100,0.1778,0.05485,0.127,0.05, true, true, "carFARW0_05485");
		PinewoodCar car9=new PinewoodCar("carFARW0.04985",.100,0.1778,0.04985,0.127,0.05, true, true, "carFARW0_04985");
		PinewoodCar car10=new PinewoodCar("carFARW0.04485",.100,0.1778,0.04485,0.127,0.05, true, true, "carFARW0_04485");
		do
		{
			baseCar0.frictionAndAirResitanceStep(0.001);
			distance=baseCar0.getDistance();
		}while(distance<2.5);
		baseCar0.frictionTransition();
		do
		{
			baseCar0.frictionAndAirResitanceStep(0.001);
			distance=baseCar0.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		baseCar0.terminate();
		
		do
		{
			car1.frictionAndAirResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<2.5);
		car1.frictionTransition();
		do
		{
			car1.frictionAndAirResitanceStep(0.001);
			distance=car1.getDistance();
		}while(distance<6.5);
		
		distance=0;
		
		car1.terminate();
		do
		{
			car2.frictionAndAirResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<2.5);
		car2.frictionTransition();
		do
		{
			car2.frictionAndAirResitanceStep(0.001);
			distance=car2.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car2.terminate();
		do
		{
			car3.frictionAndAirResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<2.5);
		car3.frictionTransition();
		do
		{
			car3.frictionAndAirResitanceStep(0.001);
			distance=car3.getDistance();
		}while(distance<6.5);
		distance=0;
		car3.terminate();
		do
		{
			car4.frictionAndAirResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<2.5);
		car4.frictionTransition();
		do
		{
			car4.frictionAndAirResitanceStep(0.001);
			distance=car4.getDistance();
		}while(distance<6.5);
		
		distance=0;
		car4.terminate();
		do
		{
			car5.frictionAndAirResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<2.5);
		car5.frictionTransition();
		do
		{
			car5.frictionAndAirResitanceStep(0.001);
			distance=car5.getDistance();
		}while(distance<6.5);
		distance=0;
		car5.terminate();
		do
		{
			car6.frictionAndAirResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<2.5);
		car6.frictionTransition();
		do
		{
			car6.frictionAndAirResitanceStep(0.001);
			distance=car6.getDistance();
		}while(distance<6.5);
		car6.terminate();
		distance=0;
		do
		{
			car7.frictionAndAirResitanceStep(0.001);
			distance=car7.getDistance();
		}while(distance<2.5);
		car7.frictionTransition();
		do
		{
			car7.frictionAndAirResitanceStep(0.001);
			distance=car7.getDistance();
		}while(distance<6.5);
		car7.terminate();
		distance=0;
		do
		{
			car8.frictionAndAirResitanceStep(0.001);
			distance=car8.getDistance();
		}while(distance<2.5);
		car8.frictionTransition();
		do
		{
			car8.frictionAndAirResitanceStep(0.001);
			distance=car8.getDistance();
		}while(distance<6.5);
		car8.terminate();
		distance=0;
		do
		{
			car9.frictionAndAirResitanceStep(0.001);
			distance=car9.getDistance();
		}while(distance<2.5);
		car9.frictionTransition();
		do
		{
			car9.frictionAndAirResitanceStep(0.001);
			distance=car9.getDistance();
		}while(distance<6.5);
		car9.terminate();
		distance=0;
		do
		{
			car10.frictionAndAirResitanceStep(0.001);
			distance=car10.getDistance();
		}while(distance<2.5);
		car10.frictionTransition();
		do
		{
			car10.frictionAndAirResitanceStep(0.001);
			distance=car10.getDistance();
		}while(distance<6.5);
		car10.terminate();
		
		
		
	}
}
