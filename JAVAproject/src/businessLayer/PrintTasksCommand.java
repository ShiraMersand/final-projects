package businessLayer;

import java.util.Collections;


public class PrintTasksCommand extends Command{

	@Override
	InputData preperData() {
		return null;
	}

	@Override
	void Execute(InputData data) {
		TaskListManager listManager=TaskListManager.getInstance();
		Collections.sort(listManager.getTaskList().get(StatusEnum.DONE));
		Collections.sort(listManager.getTaskList().get(StatusEnum.PROCESSING));

		
		for (Task task : listManager.getTaskList().get(StatusEnum.DONE)) {
			System.out.println(task.subject);
		}
		
		for (Task task : listManager.getTaskList().get(StatusEnum.PROCESSING)) {
			System.out.println(task.subject);
		}

	}




}
