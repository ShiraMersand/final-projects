package businessLayer;
public class ExitTask extends Command{

	@Override
	InputData preperData() {
		return null;
	}

	@Override
	void Execute(InputData data) throws TaskExistsException {
		TaskListManager listManager=TaskListManager.getInstance();
		listManager.stop();
		
	}

}
