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
		String data = String.format("%15s", registration_id) +
					  String.format("%30s", name) + 
					  String.format("%20s", model) +
					  String.format("%10d", count) +
					  String.format("%10s", firm_name) +
					  String.format("%15f", price) +
					  String.format("%15s", date);
		return data;
	}
}
