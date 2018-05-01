import java.io.File;
import java.io.IOException;
import java.util.Scanner;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Pattern;
import org.mindrot.jbcrypt.BCrypt;

//Team Members: Maxwell Winston, Brian Buermann, Sean Gormley
//Code written 2/18/2018
//Code for BCrypt downloaded from https://www.mindrot.org/projects/jBCrypt/
//Limitations:
//Errors are logged in ErrorLogFile.log

//Things defended against:
//Improper input
//Bad or illegal file names
//Any attempts to overwrite system files
//Anyone being able to see password entry in console
//Integer overflow when attempts are made to enter numbers greater than Integer.MAX_VALUE or less than Integer.MIN_VALUE
//Integer overflow when calculating sum and product when writing to file
//Any errors are reported to a log file

//Java already has buffer overflow protection
public class CSCDAssignment6Java
{
	// C:\Users\BeerM\workspace\cscd437_hw6\safjasfnasfn.txt
	//private static String forbiddenWindowsFileCharPattern="^(([^/:*?\"<>|^]*([\\\\/:*?\"<>|\\\\^])[^\\\\/:*?\"<>|^]*)|((?i)( |[.]|[.].*|.*[.]| .*|.*([.][.]txt)|.*[\\s]((.txt)?)|CON((.txt)?)|PRN((.txt)?)|AUX((.txt)?)|NUL((.txt)?)|COM[1-9]((\\..+)?)|LPT[1-9]((\\..+)?)|(\\\\x[0-9])|(\\\\x[1-3][0-9]))))$";
	private static String namePattern="^(?=.{1,50}$)(\\p{L}+([\\p{Space}'-]\\p{L}+)*)$";
	private static String intPattern="^([+-]?)([0-9]{1,10})$";
	// private static String forbiddenWindowsFileCharPattern="^(?=(((?i)( |[.]|[.].*|.*[.]| .*|.*([.][.]txt)|.*[\\s]((.txt)?)|CON((.txt)?)|PRN((.txt)?)|AUX((.txt)?)|NUL((.txt)?)|COM[1-9]((\\..*)?)|LPT[1-9]((\\..*)?)|(\\\\x[0-9])|(\\\\x[1-3][0-9])))))$|^(?=[^/:*?\"<>|^]*([\\\\/:*?\"<>|\\\\^])[^\\\\/:*?\"<>|^]*)$";
	private static String forbiddenMacFileCharPattern="^([^:]*)[:]([^:]*)$";
	private static String forbiddenUnixFileCharPattern="^(.*/.*)$";
	private static String forbiddenFileNameLength="^((.{1,255}))$";
	private static String forbiddenWindowsFileCharPattern="^((.*[/:*?\"<>|^].*)|((?i)( |[.]|[.].*|.*[.]| .*|.*([.][.]txt)|.*[\\s]((.txt)?)|CON((.txt)?)|PRN((.txt)?)|AUX((.txt)?)|NUL((.txt)?)|COM1((.txt)?)|COM2((.txt)?)|COM3((.txt)?)|COM4((.txt)?)|COM5((.txt)?)|COM6((.txt)?)|COM7((.txt)?)|COM8((.txt)?)|COM9((.txt)?)|LPT1((.txt)?)|LPT2((.txt)?)|LPT3((.txt)?)|LPT4((.txt)?)|LPT5((.txt)?)|LPT6((.txt)?)|LPT7((.txt)?)|LPT8((.txt)?)|LPT9((.txt)?)|(\\\\x[0-9])|(\\\\x[1-3][0-9]))))$";
	private static String passwordPattern="^((?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!?^.;:+-_=#$%&*])(.{10,}))$";

	private static long readInt(Scanner input)
	{
		String firstNumTemp=input.nextLine();
		long num=0;
		boolean correctInput=false;
		while(!correctInput)
		{
			if(Pattern.matches(intPattern, firstNumTemp))
			{
				Long tester=Long.parseLong(firstNumTemp);
				if(tester>=Integer.MIN_VALUE && tester<=Integer.MAX_VALUE)
				{
					correctInput=true;
					num=tester;
				}
				else
				{
					System.out.println("\nInput Invalid, the number you used outside the range.  Try Again: ");
					firstNumTemp=input.nextLine();
					correctInput=Pattern.matches(intPattern, firstNumTemp);
				}
			}
			else
			{
				System.out.println("\nInput Invalid, I need an INTEGER number: ");
				firstNumTemp=input.nextLine();
			};
		}
		return num;
	}

	private static boolean isValidFilename(String input, String os)
	{
		if (!Pattern.matches(forbiddenFileNameLength, input))
			return false;
		return isValidFilenameOS(input, os, "win", forbiddenWindowsFileCharPattern)
				|| isValidFilenameOS(input, os, "mac", forbiddenMacFileCharPattern)
				|| isValidFilenameOS(input, os, "nix", forbiddenUnixFileCharPattern)
				|| isValidFilenameOS(input, os, "nux", forbiddenUnixFileCharPattern)
				|| isValidFilenameOS(input, os, "aix", forbiddenUnixFileCharPattern);
	}

	private static boolean isValidFilenameOS(String input, String os, String term, String forbidden)
	{
		boolean a = os.contains(term) && !Pattern.matches(forbidden, input);
		return os.contains(term) && !Pattern.matches(forbidden, input);
	}

	private static void setupLogFile(Logger log)
	{
		try
		{
			FileHandler fileHandling=new FileHandler("ErrorLogFile.log");
			log.addHandler(fileHandling);
			java.util.logging.SimpleFormatter formatter=new java.util.logging.SimpleFormatter();
			fileHandling.setFormatter(formatter);

			log.setUseParentHandlers(false);
		}
		catch(Exception e)
		{
			System.out.println("Log file could not be created");
		}
	}

	private static String readName(Scanner input, String msg)
	{
		String name = input.nextLine();
		boolean correctInput=Pattern.matches(namePattern, name);
		while(!correctInput)
		{
			System.out.println(msg);
			name=input.nextLine();
			correctInput=Pattern.matches(namePattern, name);
		}
		return name;
	}

	private static char [] readPass(java.io.Console console, Logger log)
	{
		boolean correctInput = false;
		char [] pass = null;
		while(!correctInput)
		{
			try
			{
				pass=console.readPassword();
				correctInput=Pattern.matches(passwordPattern, new String(pass));
				if(!correctInput)
				{
					System.out.println("\nIllegal input detected. Try again.");
				}
				else
				{
					System.out.println("Successful password.");
				}
			}
			//Buffer overflow protection(in case a person tries to enter a password with >Integer.MAX_VALUE characters)
			catch(java.lang.ArrayIndexOutOfBoundsException e)
			{
				log.log(Level.WARNING, "Attempt was made to flood buffer during password entering",e);
			}
			catch(NullPointerException e)
			{
				System.out.println("Console does not exist.");
			}
		}
		return pass;
	}
	public static void main(String[] args)
	{
		//https://stackoverflow.com/questions/15758685/how-to-write-logs-in-text-file-when-using-java-util-logging-log
		Logger log = Logger.getLogger(CSCDAssignment6Java.class.getName());
		setupLogFile(log);

		//Regexes for input validation
		//String namePattern="^(?!(([^-]*-.*){4,}))(?!(([^-]*[\\-][\\-].*)))(?!(([^.]*[.].*){4,}))(?!(([^ ]*[ ].*){3,}))[A-Z]{1}[a-zA-Z�-�\\-\\. ]{0,49}$"

		String os=System.getProperty("os.name").toLowerCase();

		// String requiredExtensionPattern="^.*([.]{1}txt)([/]?)$";
		Scanner input=new Scanner(System.in);
		System.out.println("Welcome to Defend your code! Java Edition by 7th Dimension.\n");
		System.out.println("Enter your last name\r\n(Maximum of 50 characters): ");
		String lastName=readName(input, "\r\nInput Invalid, enter your last name: ");

		System.out.println("\nEnter your first name\r\n(Maximum of 50 characters): ");
		String firstName=readName(input, "\r\nInput Invalid, Enter your first name: ");
		System.out.println("\nEnter an integer (between -2147483648 and 2147483647):");
		long firstNum = readInt(input);
		System.out.println("\nEnter a second integer (between -2,147,483,648 and 2,147,483,647):");
		long secondNum= readInt(input);
		boolean correctInput=false;
		File inputFile = null;
		String inputFileName = null;
		while(!correctInput)
		{
			System.out.println("\nEnter a filename to read from.\r\nThe file must exist and cannot contian a path.");
			inputFileName=input.nextLine();
			if (isValidFilename(inputFileName, os))
			{
				inputFile=new File(inputFileName);
				correctInput = (inputFile.isFile()&&inputFile.canRead());
				if(!correctInput)
				{
					System.out.println("\nThe file cannot not be found, or the file cannot be read from.  Please try again.");
				}
			}
			else
				System.out.println("Cannot open that file. It may be in a forbidden location.");

		}
		correctInput=false;
		File outputFile = null;
		while(!correctInput)
		{
			System.out.println("\nEnter a file to write the output to.\nThe file name must not be the input file, must not contain any illegal characters,\nmust not be an illegal name, and must be less than 255 characters: ");
			String outputFileName=input.nextLine();
			if(isValidFilename(outputFileName, os))
			{
				outputFile=new File(outputFileName);
				try {

					correctInput=(!outputFileName.equalsIgnoreCase("ErrorLogFile.log")&&!outputFileName.equals(inputFileName) && (!os.contains("win") || !outputFileName.equalsIgnoreCase(inputFileName)));
					if(!correctInput)
					{
						System.out.println("Error. Enter file name to write to.");
					}
					else
					{
						outputFile.createNewFile();
					}

				} catch (IOException e)
				{
					log.log(Level.WARNING, "File "+outputFileName+" could not be created",e);
					System.out.println("Error.  Please try again.");
				}
			}
			else
			{
				System.out.println("\nError.\nTry again.");
			}
		}

		java.io.Console console = System.console();
		System.out.println("\nEnter a password.\nMust be at least 10 characters, at least 1 Capital letter, at least 1 "
				+ "lowercase letter, at least 1 number, at least one of the following symbols: !?^.;:+-_=#$%&*).\n"
				+ "For security purposes, you won't be able to see what you enter.");

		correctInput=false;
		char[] pass=readPass(console, log);
		java.security.SecureRandom saltGen=new java.security.SecureRandom();
		String passwordHashed=BCrypt.hashpw(new String(pass), BCrypt.gensalt(4,saltGen));

		pass=null;
		System.out.println("\nReenter password:");
		correctInput=false;
		char[] secondPass=null;
		while(!correctInput)
		{
			try
			{
				secondPass=console.readPassword();
				correctInput=true;
			}
			//Buffer overflow protection(in case a person tries to enter a password with >Integer.MAX_VALUE characters)
			catch(java.lang.ArrayIndexOutOfBoundsException e)
			{
				log.log(Level.WARNING, "Error",e);
			}
		}
		correctInput=false;
		while(!correctInput)
		{
			if(BCrypt.checkpw(new String(secondPass), passwordHashed))
			{
				secondPass=null;
				System.out.println("Writing to file.");

				correctInput=true;
			}
			else
			{
				System.out.println("Error. Try again:");
				secondPass=console.readPassword();
			}
		}

		java.io.BufferedWriter write;
		try
		{
			write=new java.io.BufferedWriter(new java.io.FileWriter(outputFile));
			java.io.BufferedReader read=new java.io.BufferedReader(new java.io.FileReader(inputFile));
			write.write("First Name: "+firstName+"\nLast Name: "+lastName+"\n");
			//Turning to long to ensure that integer overflow does not occur
			Long sum=firstNum+secondNum;
			Long product=firstNum*secondNum;
			write.write("Sum of the two numbers: "+sum.toString()+"\n");
			write.write("Product of the two numbers: "+product.toString()+"\n");
			write.newLine();
			String line="";
			while((line=read.readLine())!=null)
			{
				write.write(line+"\n");
			}
			read.close();
			write.close();
		}
		catch (IOException e)
		{
			log.log(Level.SEVERE,"Something went wrong" ,e);
		}
		System.out.println("Writing complete");
		input.close();
	}
}
