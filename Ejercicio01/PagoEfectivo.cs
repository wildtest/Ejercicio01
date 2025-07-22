using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class PagoEfectivo: Pago, IValidacionPago
	{
		public string NombreCliente { get; set; }
		public string Moneda { get; set; }
		public double MontoPagado { get; set; }
		public double Vuelto { get; private set; }

		public PagoEfectivo(double monto, string nombreCliente, double montoPagado, string moneda = "MXN") : base(monto)
		{
			NombreCliente = nombreCliente;
			MontoPagado = montoPagado;
			Moneda = moneda;
			Vuelto = CalcularVuelto();
		}

		public override bool ProcesarPago(double monto)
		{
			if (!Validar())
			{
				return false;
			}
			Console.WriteLine($"{NombreCliente} ha realizado un pago en efectivo por un monto de {monto:C} {Moneda}");
			Console.WriteLine($"Monto pagado: {MontoPagado:C}. Vuelto: {Vuelto:C} ");
			return true;
		}

		public bool Validar()
		{
			if (Monto <= 0)
			{
				Console.WriteLine("El monto debe ser mayor a cero");
				return false;
			}

			if (MontoPagado < Monto)
			{
				Console.WriteLine("El monto pagado es insuficiente.");
				return false;
			}
			return true;
		}

		private double CalcularVuelto()
		{
			if (MontoPagado >= Monto)
			{
				return MontoPagado - Monto;
			}
			else
			{
				return 0;
			}
		}
	}
}
