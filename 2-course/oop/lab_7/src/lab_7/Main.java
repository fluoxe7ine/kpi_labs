package lab_7;
import lab_7.Matrix;

public class Main {
	public static void main(String[] args) {
		Matrix m1 = new Matrix(7);
		m1.fillMatrix();
		m1.showMatrix();
		m1.findMaxAndDelete();
		m1.showMatrix();
		
		Matrix m2 = new Matrix(12);
		m2.fillMatrix();
		m2.showMatrix();
		m2.findMaxAndDelete();
		m2.showMatrix();
	}
}
