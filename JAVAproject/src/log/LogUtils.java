package log;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.Date;

public class LogUtils  {
	
	String filePath = "C:/Users/This_User/Desktop/log/file." + "txt";
	
	public void log(SeverityLevel  severityLevel ,String msg) {
		// Write to file
			msg= prepareMessageForText(severityLevel,msg);

		String filePath = "C:/Users/This_User/Desktop/log/file." + "txt";
		Path path = Paths.get(filePath);
		try {
			msg = msg + System.lineSeparator();
			byte[] bs = msg.getBytes();
			Files.write(path, bs, StandardOpenOption.APPEND, StandardOpenOption.CREATE);
		} catch (Exception e) {
			e.printStackTrace();
		}


	}
	
	public String prepareMessageForText(SeverityLevel  severityLevel,String s) {
		return (new Date()) + ": " + severityLevel+s;
	}
	
	public String prepareMessageForJson(SeverityLevel  severityLevel,String s) {
		return String.format("{\"text\" :\"%s\", \"date\": \"%s\",\"level\": \"%s\"}", s, new Date(),severityLevel);
	}


}
