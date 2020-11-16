package businessLayer;

import java.util.ArrayList;
import java.util.List;

public class DeleteStatusTasksCommand extends Command{

	@Override
	InputData preperData() {
		System.out.println("enter status");
		InputUtils inputUtils=new InputUtils();
		StatusEnum statusEnum=inputUtils.getEnum();
		InputData inputData=new InputData(null,null,statusEnum);
		return inputData;
	}

	@Override
	void Execute(InputData data) {
		TaskListManager listManager=TaskListManager.getInstance();
		List<Task> list = new ArrayList<Task>();
		listManager.setList(list, data.status);

	}

}
