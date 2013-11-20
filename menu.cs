
using System;

namespace practica7
{
	
	public class menu
	{
		public menu(){
			
		}
		registro r=new registro();
		public void mostrarmenu(){
			
			//Console.Clear();
			string nombre,email,codigo,telefono,men,id;
			Console.WriteLine("Menu principal\n");
			Console.WriteLine("Opcion a: Mostrar tabla.\n" +
			                  "Opcion b: Agregar registro.\n" +
			                  "Opcion c: Editar tabla.\n" +
			                  "Opcion d: Eliminar un registro\n" +
			                  "Opcion e: Salir.");
			men=Console.ReadLine();
			switch(men){
					
				case "a":
					r.mostrarconexion();
					Console.WriteLine("\n");
					mostrarmenu();
					break;
				case "b":
					Console.Write("Nombre: ");
					nombre= Console.ReadLine();
					Console.Write("Codigo: ");
					codigo = Console.ReadLine();
					Console.Write("Telefono: ");
					telefono= Console.ReadLine();
					Console.Write("Email: ");
					email=Console.ReadLine();
					Console.WriteLine("\n");
					r.agregarregistro(nombre,codigo,telefono,email);
					r.mostrarconexion();
					Console.WriteLine("\n");
					mostrarmenu();
					break;
				case "c":
					Console.WriteLine("ID a editar");
					id=Console.ReadLine();
					Console.Write("Nombre: ");
					nombre= Console.ReadLine();
					Console.Write("Codigo: ");
					codigo = Console.ReadLine();
					Console.Write("Telefono: ");
					telefono= Console.ReadLine();
					Console.Write("Email: ");
					email=Console.ReadLine();
					Console.WriteLine("\n");
					r.editarRegistro(id,nombre,codigo,telefono,email);
					r.mostrarconexion();
					Console.WriteLine("\n");
					mostrarmenu();
					break;
				case "d":
					Console.WriteLine("ID del registro a eliminar:");
					id=Console.ReadLine();
				    r.eliminarRegistroPorId(id);
					r.mostrarconexion();
					Console.WriteLine("\n");
					mostrarmenu();
					break;
					case "e": System.Environment.Exit(-1);
					break;
			}
		}
	}
}
