using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public abstract class Producto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public decimal Precio { get; set; }
		public int Stock { get; set; }

		public Producto(int id, string nombre, decimal precio, int stock)
		{
			Id = id;
			Nombre = nombre;
			Precio = precio;
			Stock = stock;
		}

		public virtual void MostrarInformacion()
		{
			Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio:C}, Stock: {Stock}");
		}

		public abstract void MostrarDetalles();
	}
}
