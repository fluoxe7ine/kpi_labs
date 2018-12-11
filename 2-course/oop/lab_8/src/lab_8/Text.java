package lab_8;
import java.util.Scanner;

public class Text {
	public String data;
	public String symbol;
	public int k;
	
	public Text() {
		System.out.println("Enter your text: ");
		Scanner in = new Scanner(System.in);
		String text = in.nextLine();
		data = text;
	}
	
	public Text(String text) {
		this.data = text;
	}
	
	public void setKey(int key) {
		this.k = key;
	}
	
	public void setKey() {
		System.out.println("Enter key: ");
		Scanner in =  new Scanner(System.in);
		int key = in.nextInt();
		this.k = key;
	}
	
	public void setSymbol(String s) {
		this.symbol = s;
	}
	
	public void setSymbol() {
		System.out.println("Enter symbol: ");
		Scanner in = new Scanner(System.in);
		this.symbol = in.nextLine();
	}
	
	public void showText() {
		System.out.println(data);
	}
	
	public void formatText() {
		String[] wordsArray = data.split(" ");
		String newText = "";
		for (int i = 0; i < wordsArray.length; i++) {
//			if (wordsArray[i].length() >= k) {
				newText += replaceWord(wordsArray[i]) + " ";
//			}
		}
		data = newText;
		
	}
	
	public String replaceWord(String word) {
		String newWord = "";
		int count = 1;
		if (word.length() < k) return word;
		for (int i = 0; i < word.length(); i++) {
			if (count % k == 0 && word.toCharArray()[i] != '.' && word.toCharArray()[i] != '\n' && word.toCharArray()[i] != '-' && word.toCharArray()[i] != ',') {
				newWord += symbol;
			} else newWord += word.toCharArray()[i];
			count++;
		}
		return newWord;
	}
}
