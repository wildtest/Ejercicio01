using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class PagoTarjeta : Pago, IValidacionPago
	{
		public string NumeroTarjeta { get; set; }
		public string NombreTitular { get; set; }
		public DateTime FechaExpiracion { get; set; }
		public string CodigoCVV { get; set; }
		public TipoTarjeta Tipo { get; set; }
		public PagoTarjeta(double monto, string numeroTarjeta, string nombreTitular, DateTime fechaExpiracion, string codigoCVV, TipoTarjeta tipo) : base(monto)
		{
			NumeroTarjeta = numeroTarjeta;
			NombreTitular = nombreTitular;
			FechaExpiracion = fechaExpiracion;
			CodigoCVV = codigoCVV;
			Tipo = tipo;
		}

		public override bool ProcesarPago(double monto)
		{
			if (!Validar())
			{
				return false;
			}

			Console.WriteLine($"Pago realizado con {Tipo.MostrarTipo()} por un monto de {monto:C}. Número de tarjeta: {NumeroTarjeta.Substring(0, 4)}****");
			return true;
		}

		public bool Validar()
		{
			if (Monto <= 0)
			{
				Console.WriteLine("El monto debe ser mayor a cero");
				return false;
			}

			if (FechaExpiracion < DateTime.Now)
			{
				Console.WriteLine("La tarjeta ha expirado");
				return false;
			}

			if (string.IsNullOrEmpty(NumeroTarjeta) || NumeroTarjeta.Length != 16)
			{
				Console.WriteLine("Número de tarjeta inválido. Debe tener 16 dígitos");
				return false;
			}

			if (string.IsNullOrEmpty(CodigoCVV) || CodigoCVV.Length != 3)
			{
				Console.WriteLine("Código CVV inválido");
				return false;
			}

			return true;
		}
	}
}
