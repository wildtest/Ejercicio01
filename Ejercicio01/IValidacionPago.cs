using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Interfaz IValidacionPago que define el contrato para validar pagos.
	/// </summary>
	public interface IValidacionPago
	{
		/// <summary>
		/// Método para validar un pago.
		/// </summary>
		/// <returns></returns>
		bool Validar();
	}
}
