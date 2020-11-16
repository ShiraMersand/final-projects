package businessLayer;

import java.util.List;

import log.LogUtils;
import log.SeverityLevel;

public class DeleteTaskCommand extends Command{

	@Override
	InputData preperData() {
		InputUtils inputUtils=new InputUtils();
		System.out.println("enter subject");
		String subject=inputUtils.getString();
		InputData inputData=new InputData(subject,null,null);
		return inputData;
	}

	@Override
	void Execute(InputData data)  {
		
		LogUtils log = new LogUtils(); 
		
		TaskListManager listManager=TaskListManager.getInstance();
	
		Task taskToDelete=null;
		try {
			taskToDelete = listManager.choosTask(data);
			List<Task> tmp=listManager.getTaskList().get(taskToDelete.getStatusEnum());
			tmp.remove(taskToDelete);
			listManager.setList(tmp, taskToDelete.getStatusEnum());

		} catch (TaskNotFoundException e) {
			// TODO Auto-generated catch block
			log.log(SeverityLevel.ERROR, "Task not found exception");
			e.printStackTrace();
		}
		
		
	}

}