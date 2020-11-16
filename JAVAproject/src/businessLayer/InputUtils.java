package businessLayer;
import java.util.Scanner;

public class InputUtils {

	public int getInt() {
		
		Scanner scanner = new Scanner(System.in);
		int num = scanner.nextInt();
		return num;
		
	}

	public String getString() {
		Scanner scanner = new Scanner(System.in);
		String str = scanner.next();
		return str;

	}

	public StatusEnum getEnum() {
		Scanner scanner = new Scanner(System.in);
		///////////////////////////////////////////////////////////////////////////////////////
		while (true) {
			String str = scanner.next();
			if(StatusEnum.DONE.toString().equals(str)){
				return StatusEnum.DONE;
				} 
			
			if(StatusEnum.PROCESSING.toString().equals(str)){
				return StatusEnum.PROCESSING;
				} 
			}

	}

}
