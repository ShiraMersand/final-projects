//package dataLayer;
//
//import java.sql.*;
//
//import businessLayer.Task;
//
//
//public class TaskDAO {
//	
//	public void insert(Task task) {
//		
//		String sql = "INSERT INTO Users (subject,description,status) VALUES (?, ?, ?)";
//		 
//		PreparedStatement statement = conn.prepareStatement(sql);
//		statement.setString(1, task.getSubject());
//		statement.setString(2, task.getDescription());
//		statement.setString(3, "Bill Gates");
//
//		 
//		int rowsInserted = statement.executeUpdate();
//		if (rowsInserted > 0) {
//		    System.out.println("A new user was inserted successfully!");
//		}
//		
//	}
//	
//	public void select() {
//		
//		String sql = "SELECT * FROM Tasks";
//		 
//		Statement statement = conn.createStatement();
//		ResultSet result = statement.executeQuery(sql);
//		 
//		int count = 0;
//		 
//		while (result.next()){
//		    String subject = result.getString(2);
//		    String description = result.getString(3);
//		    String statuse = result.getString("fullname");
//		 
//		    String output = "Task #%d: %s - %s - %s - %s";
//		    System.out.println(String.format(output, ++count, subject,description,statuse));
//		}
//
//		
//	}
//	
//	public void update() {
//		
//		String sql = "UPDATE Users SET password=?, fullname=?, email=? WHERE username=?";
//		 
//		PreparedStatement statement = conn.prepareStatement(sql);
//		statement.setString(1, "123456789");
//		statement.setString(2, "William Henry Bill Gates");
//		statement.setString(3, "bill.gates@microsoft.com");
//		statement.setString(4, "bill");
//		 
//		int rowsUpdated = statement.executeUpdate();
//		if (rowsUpdated > 0) {
//		    System.out.println("An existing user was updated successfully!");
//		}
//		
//	}
//	
//	public void delete() {
//		
//		String sql = "DELETE FROM Users WHERE username=?";
//		 
//		PreparedStatement statement = conn.prepareStatement(sql);
//		statement.setString(1, "bill");
//		 
//		int rowsDeleted = statement.executeUpdate();
//		if (rowsDeleted > 0) {
//		    System.out.println("A user was deleted successfully!");
//		}
//		
//	}
//	
//	
//}
