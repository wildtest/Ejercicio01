using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase TipoBilleteraDigital que representa un tipo de billetera digital.
	/// </summary>
	public class TipoBilleteraDigital
	{
		public string Nombre { get; set; }
		public string Proveedor { get; set; }
		public TipoBilleteraDigital(string nombre, string proveedor)
		{
			Nombre = nombre;
			Proveedor = proveedor;
		}

		/// <summary>
		/// Método que muestra el tipo de billetera digital.
		/// </summary>
		/// <returns></returns>
		public string MostrarTipo()
		{
			return $"{Nombre} - {Proveedor}";
		}
	}
}
