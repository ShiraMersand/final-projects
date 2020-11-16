package businessLayer;

import log.LogUtils;
import log.SeverityLevel;

public class CommandFactory {

	public static void func(int number) {

		LogUtils log = new LogUtils();

		switch (number) {
		case 1:
			AddTaskCommand addTaskCommand = new AddTaskCommand();
			addTaskCommand.Execute(addTaskCommand.preperData());
			log.log(SeverityLevel.INFO, "Add task command!!!");

			break;
		case 2:
			UpdateTaskCommand updateTaskCommand = new UpdateTaskCommand();
			updateTaskCommand.Execute(updateTaskCommand.preperData());
			log.log(SeverityLevel.INFO, "Update task command!!!");

			break;
		case 3:
			DeleteTaskCommand deleteTaskCommand = new DeleteTaskCommand();
			deleteTaskCommand.Execute(deleteTaskCommand.preperData());
			log.log(SeverityLevel.INFO, "Delete task command!!!");

			break;
		case 4:
			DeleteStatusTasksCommand deleteStatusTasksCommand = new DeleteStatusTasksCommand();
			deleteStatusTasksCommand.Execute(deleteStatusTasksCommand.preperData());
			log.log(SeverityLevel.INFO, "Delete status tasks command!!!");
			break;
		case 5:
			PrintTasksCommand printTasksCommand = new PrintTasksCommand();
			printTasksCommand.Execute(printTasksCommand.preperData());
			log.log(SeverityLevel.INFO, "Print tasks command!!!");
			break;
		case 6:
			PrintStatusTaskCommand printStatusTaskCommand = new PrintStatusTaskCommand();
			printStatusTaskCommand.Execute(printStatusTaskCommand.preperData());
			log.log(SeverityLevel.INFO, "Print status task command!!!");
			break;
		case 7:
			ExitTaskCommand exitTask = new ExitTaskCommand();
			exitTask.Execute(exitTask.preperData());
			log.log(SeverityLevel.INFO, "Exit task!!!");
			break;

		default:
			break;
		}

	}

}
