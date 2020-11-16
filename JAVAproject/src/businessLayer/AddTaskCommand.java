package businessLayer;

import java.util.Collection;
import java.util.List;

import javax.swing.DebugGraphics;

import log.LogUtils;
import log.SeverityLevel;

public class AddTaskCommand extends Command {

	@Override
	InputData preperData() {
		InputUtils inputUtils = new InputUtils();
		System.out.print("enter description");
		String description = inputUtils.getString();
		System.out.print("enter subject");
		String subject = inputUtils.getString();
		InputData data = new InputData(subject, description, StatusEnum.PROCESSING);
		return data;
	}

	@Override
	void Execute(InputData data) {
		TaskListManager taskListManager = TaskListManager.getInstance();
		Collection<List<Task>> collection = taskListManager.getTaskList().values();

		try {
			check(collection, data);

			Task task = new Task(data.subject, data.description, data.status);

			taskListManager.getTaskList().get(data.status).add(task);

		} catch (TaskExistsException e) {
			// TODO Auto-generated catch block

			LogUtils log = new LogUtils();
			log.log(SeverityLevel.ERROR, "Task exists exception!!!");
			e.printStackTrace();
		}

	}

	void check(Collection<List<Task>> collection, InputData data) throws TaskExistsException {
		for (List<Task> list : collection) {
			for (Task task : list) {
				if (task.subject.equals(data.subject)||task.description.equals(data.description) ) {
					TaskExistsException exception = new TaskExistsException();
					throw exception;
				}
			}
		}
	}

}
