package lab_9;
import java.util.List;
//import java.util.ArrayList;

public class FactoryOutput {
	public void showFactoryList(List<Factory> f) {
		if (f.size() == 0) System.out.println("There aro no match for your query");
		String headers = String.format("%15s", "REG_ID") + 
						 String.format("%30s", "NAME") + 
						 String.format("%20s", "MODEL") +
						 String.format("%10S", "COUNT") +
						 String.format("%10s", "FIRM") +
						 String.format("%15S", "PRICE") +
						 String.format("%15s", "DATE");
		
		System.out.println(headers);
		System.out.println();
		for (int i = 0; i < f.size(); i++) {
			System.out.println(f.get(i).toString());
		}
	}
}
