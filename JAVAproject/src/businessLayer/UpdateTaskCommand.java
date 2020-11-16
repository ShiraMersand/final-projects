package businessLayer;
import java.util.HashMap;
import java.util.List;
import java.util.Scanner;

import org.omg.CORBA.portable.ApplicationException;

import log.LogUtils;
import log.SeverityLevel;

public class UpdateTaskCommand extends Command{

	@Override
	InputData preperData() {
		InputUtils inputUtils=new InputUtils();
		System.out.println("enter subject");
		String subject=inputUtils.getString();
		System.out.println("enter current status");
		StatusEnum statusEnum=inputUtils.getEnum();
		InputData data=new InputData(subject,null, statusEnum);
		return data;
	}

	@Override
	void Execute(InputData data)  {
		TaskListManager listManager=TaskListManager.getInstance();
		
		LogUtils log = new LogUtils();
		
		Task taskToUpdate=null;
		try {
			taskToUpdate = listManager.choosTask(data);
		} catch (TaskNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		listManager.getTaskList().get(data.status).remove(taskToUpdate);
		System.out.println(taskToUpdate.statusEnum);
		taskToUpdate.setStatusEnum(data.status==StatusEnum.DONE?StatusEnum.PROCESSING:StatusEnum.DONE);
		System.out.println(taskToUpdate.statusEnum);
		
		listManager.getTaskList().get(taskToUpdate.getStatusEnum()).add(taskToUpdate);

	}
	
}