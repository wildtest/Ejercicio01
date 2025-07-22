using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class TipoTarjeta
	{
		public string Nombre { get; set; }
		public bool EsCredito { get; set; }
		public TipoTarjeta(string nombre, bool esCredito)
		{
			Nombre = nombre;
			EsCredito = esCredito;
		}

		public string MostrarTipo()
		{
			return EsCredito ? "Tarjeta de Crédito" : "Tarjeta de Débito";
		}
	}
}
