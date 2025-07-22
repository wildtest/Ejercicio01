using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class CarritoCompras: ICarritoCompras
	{
		private List<Producto> _productos;

		public CarritoCompras()
		{
			_productos = new List<Producto>();
		}

		public void AgregarProducto(Producto producto)
		{
			_productos.Add(producto);
			Console.WriteLine($"Producto {producto.Nombre} agregado al carrito.");
		}

		public void EliminarProducto(int id)
		{
			var producto = _productos.Find(p => p.Id == id);
			if (producto != null)
			{
				_productos.Remove(producto);
				Console.WriteLine($"Producto {producto.Nombre} eliminado del carrito.");
			}
			else
			{
				Console.WriteLine("Producto no encontrado en el carrito.");
			}
		}

		public void MostrarCarrito()
		{
			Console.WriteLine("\nProductos en el Carrito:");
			foreach (var producto in _productos)
			{
				producto.MostrarInformacion();
			}
		}

		public decimal TotalCompra()
		{
			decimal total = 0;
			foreach (var producto in _productos)
			{
				total += producto.Precio;
			}
			return total;
		}
	}
}
