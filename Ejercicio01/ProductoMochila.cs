using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase ProductoMochila que hereda de Producto.
	/// </summary>
	public class ProductoMochila: Producto
	{
		public string Material { get; set; }
		public string Dimensiones { get; set; }
		public int Compartimentos { get; set; }

		public ProductoMochila(int id, string nombre, decimal precio, int stock, string material, int compartimentos, string dimensiones)
			: base(id, nombre, precio, stock)
		{
			Material = material;
			Compartimentos = compartimentos;
			Dimensiones = dimensiones;
		}

		/// <summary>
		/// Método para mostrar información general del producto mochila.
		/// </summary>
		public override void MostrarDetalles()
		{
			Console.WriteLine($"Material: {Material}, Compartimentos: {Compartimentos}, Dimensiones: {Dimensiones}");
		}
	}
}
