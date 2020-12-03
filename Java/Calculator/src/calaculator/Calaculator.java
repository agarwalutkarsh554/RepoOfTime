package calaculator;

import java.util.Scanner;

public class Calaculator {

	public static void main(String[] args) {		
		int a = 0;
		int b = 0;
		char oper = ' ';
		Scanner input = new Scanner(System.in);
		
		System.out.println("Calaculator\nType in a number:");
		a = input.nextInt();
		System.out.println("Type in a operator:");
		oper = input.next().charAt(0);
		System.out.println("Type in a another number:");
		b = input.nextInt();
		Calculate(a, oper, b);
		input.close();
	}

	private static void Calculate(int a, char oper, int b) {
		double result = 0.0;
		
		if (oper == '+') {
			result = a + b;
		} else if (oper == '-') {
			result = a - b;
		} else if (oper == '*') {
			result = a * b;
		} else if (oper == '/') {
			if (b == 0) {
				System.out.printf("Divided by zero error");
				System.exit(1);
			} else {
				result = a / b;
			}
		}
		System.out.println(result);
	}
}
