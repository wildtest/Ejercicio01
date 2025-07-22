using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class TipoBilleteraDigital
	{
		public string Nombre { get; set; }
		public string Proveedor { get; set; }
		public TipoBilleteraDigital(string nombre, string proveedor)
		{
			Nombre = nombre;
			Proveedor = proveedor;
		}

		public string MostrarTipo()
		{
			return $"{Nombre} - {Proveedor}";
		}
	}
}
