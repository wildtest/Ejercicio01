using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase que representa un producto electrónico, hereda de Producto.
	/// </summary>
	public class ProductoElectronico: Producto
	{
		public string Tipo { get; set; }
		public string FuenteEnergia { get; set; }

		public ProductoElectronico(int id, string nombre, decimal precio, int stock, string tipo, string fuenteEnergia)
			: base(id, nombre, precio, stock)
		{
			Tipo = tipo;
			FuenteEnergia = fuenteEnergia;
		}

		/// <summary>
		/// Método para mostrar información general del producto electrónico.
		/// </summary>
		public override void MostrarDetalles()
		{
			Console.WriteLine($"Tipo: {Tipo}, Fuente de Energía: {FuenteEnergia}");
		}
	}
}
