package businessLayer;
public class ExitTaskCommand extends Command{

	@Override
	InputData preperData() {
		return null;
	}

	@Override
	void Execute(InputData data)  {
		TaskListManager listManager=TaskListManager.getInstance();
		listManager.stop();
		
	}

}
