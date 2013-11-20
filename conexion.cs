using MySql.Data.MySqlClient;
using System;

namespace practica7
{
	
	public class conexion
	{
		protected MySqlConnection myConnection;
		public conexion()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
				"Server=localhost;" +
				"Database=practica7;" +
				"User ID=root;" +
				"Password=303802035;" +
				"Pooling=false;";
			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close();
			this.myConnection = null;
			
		}
		
	}
}
