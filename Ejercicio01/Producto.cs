using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase base para representar un producto.
	/// </summary>
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

		/// <summary>
		/// Método para mostrar información general del producto.
		/// </summary>
		public virtual void MostrarInformacion()
		{
			Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio:C}, Stock: {Stock}");
		}

		/// <summary>
		/// Método abstracta para mostrar detalles específicos del producto.
		/// </summary>
		public abstract void MostrarDetalles();
	}
}
