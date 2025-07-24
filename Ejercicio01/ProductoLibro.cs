using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase ProductoLibro que hereda de Producto.
	/// </summary>
	public class ProductoLibro: Producto
	{
		public string Autor { get; set; }
		public string Editorial { get; set; }
		public string ISBN { get; set; }
		public int NumeroPaginas { get; set; }

		public ProductoLibro(int id, string nombre, decimal precio, int stock, string autor, string editorial, string isbn, int numeroPaginas)
			: base(id, nombre, precio, stock)
		{
			Autor = autor;
			Editorial = editorial;
			ISBN = isbn;
			NumeroPaginas = numeroPaginas;
		}

		/// <summary>
		/// Método para mostrar información general del libro.
		/// </summary>
		public override void MostrarDetalles()
		{
			Console.WriteLine($"Autor: {Autor}, Editorial: {Editorial}, ISBN: {Editorial}, Páginas: {NumeroPaginas}");
		}
	}
}
