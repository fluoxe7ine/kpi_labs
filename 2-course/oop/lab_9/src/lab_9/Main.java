package lab_9;
import lab_9.Factory;
import lab_9.FactoryList;
import lab_9.FactoryOutput;

public class Main {
	public static void main(String[] args) {
		System.out.println("Made by Kozyriev Oleksandr, IP-71");
		
		FactoryList fl = new FactoryList();
		fl.fillList();
		
		FactoryOutput fo = new FactoryOutput();
		fo.showFactoryList(fl.fl);
		fo.showFactoryList(fl.searchByFirmName());
		fo.showFactoryList(fl.searchByName());
	}
}
