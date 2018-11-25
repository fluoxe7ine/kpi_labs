package lab_8;

public class Text {
	public String data;
	public String symbol;
	public int k;
	
	public Text() {
		System.out.println("You choose manual input!");
	}
	
	public Text(String text) {
		this.data = text;
		System.out.println("You choose string literal input");
	}
	
	public void setKey(int k) {
		this.k = k;
	}
	
	public void setKey() {
		
	}
	
}
