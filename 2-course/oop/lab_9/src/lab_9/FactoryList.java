package lab_9;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Random;
import lab_9.Factory;
import java.util.Scanner;
import java.util.List;

public class FactoryList {
	public List<Factory> fl = new ArrayList<Factory>();
	
	public FactoryList() {
		System.out.println("Factory list was created.");
	}
	
	public void fillList() {
		Random rand = new Random();
		String[] names = {"PS4", "XBOX ONE", "Prostokvashino", "Coca-Cola", "Teterev"};
		String[] models = {"Super", "Mini", "Maxi", "KING SIZE", "Light"};
		String[] firm_names = {"Sony", "Lenovo", "RD", "Apple"};
		String reg_id, name, model, firm_name, date;
		int count;
		double price;
		
		for (int i = 0; i < 10; i++) {
			reg_id =  "ID" + (rand.nextInt(89999) + 10000);
			name = names[rand.nextInt(names.length)];
			model = models[rand.nextInt(names.length)];
			count = rand.nextInt(9) + 1;
			firm_name = firm_names[rand.nextInt(firm_names.length)];
			price = rand.nextDouble() * 100;
			date = new SimpleDateFormat("dd.MM.yyyy").format(Calendar.getInstance().getTime());
			Factory f = new Factory(reg_id, name, model, count, firm_name, price, date);
			fl.add(f);
		}
	}
	
	public List<Factory> searchByFirmName() {
		Scanner in = new Scanner(System.in);
		System.out.println("Type firm name to filter: ");
		String text = in.next();
		List<Factory> result = new ArrayList<Factory>();
		
		for (int i = 0; i < fl.size(); i++) {
			if (fl.get(i).firm_name.equals(text)) result.add(fl.get(i));
		}
		
		return result;
		
	}
	
	public List<Factory> searchByName() {
		Scanner in = new Scanner(System.in);
		System.out.println("Type name to filter: ");
		String text = in.next();
		List<Factory> result = new ArrayList<Factory>();
		
		for (int i = 0; i < fl.size(); i++) {
			if (fl.get(i).name.equals(text)) result.add(fl.get(i));
		}
		
		return result;
		
	}
	
	
}
