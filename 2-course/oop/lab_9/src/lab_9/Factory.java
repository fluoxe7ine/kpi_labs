package lab_9;

public class Factory {
	
	public String registration_id;
	public String name;
	public String model;
	public int count;
	public String firm_name;
	public double price;
	public String date;
	
	public Factory(String registration_id, String name, String model, int count, String firm_name, double price, String date) {
		this.registration_id = registration_id;
		this.name = name;
		this.model = model;
		this.count = count;
		this.firm_name = firm_name;
		this.price = price;
		this.date = date;
	}
	
	public String toString() {
//		String data = String.format()
		String data = String.format(
				"%15s%30s%20s%10d%10s%15f%15s", 
				registration_id, name, model, count, firm_name, price, date
		);
		return data;
	}
}
