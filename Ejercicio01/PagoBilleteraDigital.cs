using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class PagoBilleteraDigital : Pago, IValidacionPago
	{
		public string CorreoBilletera { get; set; }
		public string CodigoVerificacion { get; set; }
		public string CodigoPago { get; set; }
		public TipoBilleteraDigital TipoBilletera { get; set; }

		public PagoBilleteraDigital(double monto, string correoBilletera, string codigoVerificacion, string codigoPago, TipoBilleteraDigital tipoBilletera) : base(monto)
		{
			CorreoBilletera = correoBilletera;
			CodigoVerificacion = codigoVerificacion;
			CodigoPago = codigoPago;
			TipoBilletera = tipoBilletera;
		}

		public override bool ProcesarPago(double monto)
		{
			if (!Validar())
			{
				return false;
			}

			Console.WriteLine($"Pago realizado con billetera {TipoBilletera.MostrarTipo()} por un monto de {Monto:C}. Correo: {CorreoBilletera}");
			return true;
		}

		public bool Validar()
		{
			if (Monto <= 0)
			{
				Console.WriteLine("El monto debe ser mayor a cero");
				return false;
			}

			if (string.IsNullOrEmpty(CorreoBilletera) || !CorreoBilletera.Contains("@"))
			{
				Console.WriteLine("Correo de billetera digital inválido");
				return false;
			}

			if (string.IsNullOrEmpty(CodigoVerificacion) || CodigoVerificacion.Length != 6)
			{
				Console.WriteLine("Código de verificación inválido");
				return false;
			}

			if (string.IsNullOrEmpty(CodigoPago) || CodigoPago.Length != 8)
			{
				Console.WriteLine("Código de pago inválido");
				return false;
			}

			return true;
		}
	}
}
