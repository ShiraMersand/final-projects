package businessLayer;
public class Task implements Comparable<Task> {
	
	String subject;
	String description;
	StatusEnum statusEnum;
	

	public Task() {
		super();
	}

//	public Task(String subject, String description) {
//		super();
//		this.subject = subject;
//		this.description = description;
//	}

	public Task(String subject, String description, StatusEnum statusEnum) {
		super();
		this.subject = subject;
		this.description = description;
		this.statusEnum = statusEnum;
	}
	
	public String getSubject() {
		return subject;
	}
	public void setSubject(String subject) {
		this.subject = subject;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public StatusEnum getStatusEnum() {
		return statusEnum;
	}
	public void setStatusEnum(StatusEnum statusEnum) {
		this.statusEnum = statusEnum;
	}

	@Override
	public int compareTo(Task other) {
		// TODO Auto-generated method stub
		return (this.subject.compareTo(other.subject));
	}
	



}
