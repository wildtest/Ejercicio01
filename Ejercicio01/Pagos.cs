using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class Pagos
	{

		/// <summary>
		/// Método que realiza un pago utilizando el método de pago especificado.
		/// </summary>
		/// <param name="metodoPago"></param>
		/// <param name="total"></param>
		public static void RealizarPago(MetodoPago metodoPago, decimal total)
		{
			switch (metodoPago)
			{
				case MetodoPago.Yape:
					Console.WriteLine($"Pago realizado con Yape por un total de {total:C}.");
					break;
				case MetodoPago.Efectivo:
					Console.WriteLine($"Pago realizado en efectivo por un total de {total:C}.");
					break;
				case MetodoPago.TarjetaCredito:
					Console.WriteLine($"Pago realizado con tarjeta de crédito por un total de {total:C}.");
					break;
				case MetodoPago.TarjetaDebito:
					Console.WriteLine($"Pago realizado con tarjeta de débito por un total de {total:C}.");
					break;
				default:
					Console.WriteLine("Método de pago no soportado.");
					break;
			}
		}
	}
}
