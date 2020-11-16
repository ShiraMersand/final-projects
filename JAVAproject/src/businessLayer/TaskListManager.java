package businessLayer;

import java.util.ArrayList;
import java.util.Collection;
import java.util.HashMap;
import java.util.List;

import log.LogUtils;
import log.SeverityLevel;


public class TaskListManager {

	private boolean running = true;

	private static TaskListManager single_instance = null;

	private TaskListManager() {
		Init();

	}

	// static method to create instance of Singleton class
	public static  TaskListManager getInstance() {
		if (single_instance == null)
			single_instance = new TaskListManager();
		return single_instance;
	}

	private HashMap<StatusEnum, List<Task>> taskList = new HashMap<StatusEnum, List<Task>>();

	public HashMap<StatusEnum, List<Task>> getTaskList() {
		return taskList;
	}

	public void setList(List<Task> list, StatusEnum enum1) {

		this.taskList.replace(enum1, list);
	}

	public void setTaskList(InputData data) {
		this.taskList.get(StatusEnum.PROCESSING).remove(data.description);
		this.taskList.get(StatusEnum.DONE).remove(data.description);
		Task task = new Task();
		task.description = data.description;
		this.taskList.get(data.status).add(task);
		///////////////////////////////////////////////////////////////////////////
	}

	void Init() {
		List<Task> list1 = new ArrayList<Task>();

		Task task1 = new Task("aaa", "aa",StatusEnum.PROCESSING);
		Task task2 = new Task("bbb", "bb",StatusEnum.PROCESSING);

		list1.add(task1);
		list1.add(task2);

		this.taskList.put(StatusEnum.PROCESSING, list1);

		List<Task> list2 = new ArrayList<Task>();

		Task task3 = new Task("ccc", "cc",StatusEnum.DONE);
		Task task4 = new Task("ddd", "dd",StatusEnum.DONE);

		list2.add(task3);
		list2.add(task4);

		this.taskList.put(StatusEnum.DONE, list2);


	}

	void start()  {
		CommandFactory commandFactory = new CommandFactory();
		InputUtils inputUtils = new InputUtils();
		while (this.running) {
			System.out.println("enter number");
			int num = inputUtils.getInt();
			commandFactory.func(num);
		}

	}

	void stop() {
		System.out.println("by by");
		this.running = false;

	}

	public Task choosTask(InputData data) throws TaskNotFoundException {
		
		Task task=null;
		
		Collection<List<Task>> collection = this.taskList.values();

		for (List<Task> list : collection) {
			for (Task t : list) {
				if (t.subject.equals(data.subject) ) {
					task=t;
				}
			}
		}
		
		if (task==null) {
			TaskNotFoundException exception = new TaskNotFoundException();
			throw exception;
		}
		
		
		return task;
	}

}
