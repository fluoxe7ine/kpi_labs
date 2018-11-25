package lab_7;
import lab_7.Matrix;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		System.out.println("Made by Kozyriev Oleksandr, IP-71");
		Scanner in = new Scanner(System.in);
		
		System.out.println("Enter matrix size: ");
		int n = in.nextInt();
		in.close();
		
		Matrix m1 = new Matrix(n);
		m1.fillMatrix();
		System.out.println("Matrix before removing:");
		m1.showMatrix();
		m1.findMaxAndDelete();
		System.out.println("Matrix after removing:");
		m1.showMatrix();
	}
}
