//package dataLayer;
//
//import java.sql.*;
//
//public class DbManager{
//	public static Connection getConnection() throws SQLException {
//		try {
//
//		String dbURL="jdbc:sqlserver://MBYSERVER2\\PUPILS;databaseName=JAVA;user=userName:319102448;password:6205;Integrated Security=True;";
//
//		Connection con=DriverManager.getConnection(dbURL);
//		return con;
//		}
//		catch (SQLException e) {
//		throw e;
//		}
//		}
//
//
//		public static void main(String[] args) throws SQLException {
//		Connection connection=getConnection();
//
//
//		}
//}