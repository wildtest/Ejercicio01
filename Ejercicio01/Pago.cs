using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public abstract class Pago: IPago
	{
		public double Monto { get; set; }
		public DateTime FechaPago { get; set; }

		protected Pago(double monto)
		{
			Monto = monto;
			FechaPago = DateTime.Now;
		}

		public abstract bool ProcesarPago(double monto);
	}
}
