using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Interfaz IPago que define el contrato para procesar pagos.
	/// </summary>
	public interface IPago
	{
		/// <summary>
		/// Método para procesar un pago.
		/// </summary>
		/// <param name="monto"></param>
		/// <returns></returns>
		bool ProcesarPago(double monto);
		
	}
}
