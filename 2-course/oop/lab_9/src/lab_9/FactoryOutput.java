package lab_9;
import java.util.List;
//import java.util.ArrayList;

public class FactoryOutput {
	public void showFactoryList(List<Factory> f) {
		if (f.size() == 0) System.out.println("There aro no match for your query");
		String headers = String.format(
			"%15s%30s%20s%10s%10s%15s%15s", 
			"REG_ID", "NAME", "MODEL", "COUNT", "FIRM", "PRICE", "DATE"
		);
		System.out.println(headers);
		System.out.println();
		for (int i = 0; i < f.size(); i++) {
			System.out.println(f.get(i).toString());
		}
	}
}
