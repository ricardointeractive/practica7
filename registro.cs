using MySql.Data.MySqlClient;
using System;

namespace practica7
{
	
	public class registro : conexion
	{
		public registro()
		{
			
		}
		public void mostrarconexion(){
			this.abrirConexion();
			MySqlCommand myCommand = new MySqlCommand(this.querySelect(),
			                                          myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			while (myReader.Read()){
				string id = myReader["id"].ToString();
				string Nombre = myReader["Nombre"].ToString();
				string Codigo = myReader["Codigo"].ToString();
				string Telefono = myReader["Telefono"].ToString();
				string Email = myReader["Email"].ToString();
				Console.WriteLine("ID: " + id +
				                  " Nombre: " + Nombre +
				                  " Codigo: " + Codigo +
				                  " Telefono:" + Telefono +
				                  " Email:" + Email);
			}
			
			myReader.Close();
			myReader = null;
			myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}
		public void agregarregistro(string Nombre, string Codigo, string Telefono, string Email){
			this.abrirConexion();
			string sql="INSERT INTO `datos`(`Nombre`, `Codigo`, `Telefono`, `Email`) VALUES ('"+Nombre+"','"+Codigo+"','"+Telefono+"','"+Email+"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
			
		}
		public void editarRegistro(string id, string Nombre,string Codigo, string Telefono, string Email){
			this.abrirConexion();
			string sql = "UPDATE `datos` SET `Nombre`='" + Nombre + "',`Codigo`='" + Codigo + "',`Telefono`='" + Telefono + "',`Email`='" + Email + "'  WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void eliminarRegistroPorId(string id){
			this.abrirConexion();
			string sql = "DELETE FROM `datos` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		
		private string querySelect(){
			return "SELECT * " +
				"FROM  datos";
		}
	}
}
