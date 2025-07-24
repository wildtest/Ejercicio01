using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase ProductoPapeleria que hereda de Producto.
	/// </summary>
	public class ProductoPapeleria: Producto
	{
		public string Tipo { get; set; }
		public string Color { get; set; }
		public string Tamanio { get; set; }

		public ProductoPapeleria(int id, string nombre, decimal precio, int stock, string tipo, string color, string tamanio)
			: base(id, nombre, precio, stock)
		{
			Tipo = tipo;
			Color = color;
			Tamanio = tamanio;
		}

		/// <summary>
		/// Método para mostrar información general del producto de papelería.
		/// </summary>
		public override void MostrarDetalles()
		{
			Console.WriteLine($"Tipo: {Tipo}, Color: {Color}, Tamanio: {Tamanio}");
		}
	}
}
