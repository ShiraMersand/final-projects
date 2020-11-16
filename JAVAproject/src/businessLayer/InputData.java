package businessLayer;
public class InputData {
	

String description;
String subject;
StatusEnum status;

public InputData(StatusEnum status) {
	super();
	this.status = status;
}



	
public InputData(String subject,String description, StatusEnum status) {
		this.description = description;
		this.status = status;
		this.subject=subject;
	}


//public InputData(String subject, StatusEnum status) {
//	this.subject = subject;
//	this.status = status;
//}


}
