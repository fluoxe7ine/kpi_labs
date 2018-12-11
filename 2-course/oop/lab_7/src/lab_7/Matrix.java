package lab_7;
import java.util.Random;

public class Matrix {
	public short data[][];
	
	public Matrix(int n) {
		data = new short[n][n];
	}
	
	public void fillMatrix() {
		Random rand = new Random();
		for (int i = 0; i < data.length; i++) {
			for (int j = 0; j < data.length; j++) {
				data[i][j] = (short)(rand.nextInt(254) - 127);
			}
		}
	}
	
	public void showMatrix() {
		System.out.println();
		for (int i = 0; i < data.length; i++) {
			for (int j = 0; j < data[0].length; j++) {
				System.out.printf("%5d", data[i][j]);
			}
			System.out.println();
		}
		System.out.println();
	}
	
	public void findMaxAndDelete() {
		short max = data[0][0];
		short newData[][] = new short[data.length][data.length - 1];
		int column_number = 0;
		
		for (int i = 0; i < data.length; i++) {
			for (int j = 0; j < data.length; j++) {
				if (data[i][j] > max) {
					max = data[i][j];
					column_number = j;
				}
			}
		}
		
		System.out.println("Max value: " + max + " " + "Column index: " + column_number);
		
		for (int i = 0; i < data.length; i++) {
			int q = 0;
			for (int j = 0; j < data.length; j++) {
				if (j == column_number) continue;
				newData[i][q] = data[i][j];
				++q;	
			}
		}
		
		data = newData;
	}
}
