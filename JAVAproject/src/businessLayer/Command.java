package businessLayer;
abstract class Command {  
	  abstract InputData preperData(); 
	  abstract void Execute(InputData data); 
	}  