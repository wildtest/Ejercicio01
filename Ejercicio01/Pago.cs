using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	///Clase abstracta Pago que implementa la interfaz IPago.
	/// </summary>
	public abstract class Pago: IPago
	{
		public double Monto { get; set; }
		public DateTime FechaPago { get; set; }

		protected Pago(double monto)
		{
			Monto = monto;
			FechaPago = DateTime.Now;
		}

		/// <summary>
		/// Método abstracto para procesar un pago.
		/// </summary>
		/// <param name="monto"></param>
		/// <returns></returns>
		public abstract bool ProcesarPago(double monto);
	}
}
