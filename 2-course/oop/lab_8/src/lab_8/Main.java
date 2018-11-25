package lab_8;
import lab_8.Text;

public class Main {
	public static void main(String[] args) {
		System.out.println("Made by Kozyriev Oleksandr, IP-71");
		
		//manual input
		Text man = new Text();
		man.setKey();
		man.setSymbol();
		System.out.println("Key: " + man.k);
		System.out.println("Symbol: " + man.symbol);
		System.out.println("Text before formatting: ");
		man.showText();
		man.formatText();
		System.out.println("Text after formatting: ");
		man.showText();
		
		//auto input
		Text auto = new Text("lorem ipsum dolor sit amet.\n lorem ipsum dolor sit amet.\n lorem ipsum dolor sit amet.");
		auto.setKey(2);
		auto.setSymbol("!");
		System.out.println("Key: " + auto.k);
		System.out.println("Symbol: " + auto.symbol);
		System.out.println("Text before formatting: ");
		auto.showText();
		auto.formatText();
		System.out.println("Text after formatting: ");
		auto.showText();
		
	}
}
