package businessLayer;

public class PrintStatusTaskCommand extends Command{

	@Override
	InputData preperData() {
		InputUtils inputUtils=new InputUtils();
		System.out.print("enter status");
		StatusEnum statusEnum=inputUtils.getEnum();
		InputData data =new InputData(statusEnum);
		return data;
	}

	@Override
	void Execute(InputData data) {
		TaskListManager taskListManager=TaskListManager.getInstance();
		for (Task task : taskListManager.getTaskList().get(data.status)) {
			System.out.println(task.subject);
		}
		
		taskListManager.getTaskList().get(data.status);
		
	}

}
