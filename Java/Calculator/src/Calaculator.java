
import java.util.Scanner;

public class Calaculator {

	public static void main(String[] args) {
		boolean endApp = false;
		while (!endApp) {
			String a = " ";
			String b = " ";
			char oper = ' ';
			double result = 0.0;
			Scanner input = new Scanner(System.in);
			
			System.out.println("Calaculator\nType in a number:");
			a = input.nextLine();
			
			double cleana = 0.0;
			
			System.out.println("Type in a operator:");
			oper = input.next().charAt(0);
			
			System.out.println("Type in a another number:");
			b = input.nextLine();
			
			double cleanb = 0.0;
			
			input.close();
			result = Calculate(cleana, oper, cleanb);
			System.out.println(result);
		}
	}
	
	private static double Calculate(double cleana, char oper, double cleanb) {
		double result = 0.0;
		switch (oper)
		{
		case '+':
			result = cleana + cleanb;
			break;
		case '-':
			result = cleana - cleanb;
			break;
		case '*':
			result = cleana * cleanb;
			break;
		case '/':
			Scanner nonzero = new Scanner(System.in);				
			while (cleanb == 0) {
				System.out.println("Enter a non-zero divisor: ");
				cleanb = nonzero.nextInt();
			}
			nonzero.close();
			if (cleanb != 0) result = cleana / cleanb;
		default:
			break;
		}
		return result;
	}
}
