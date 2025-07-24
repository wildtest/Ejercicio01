using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase CarritoCompras que implementa la interfaz ICarritoCompras.
	/// </summary>
	public class CarritoCompras: ICarritoCompras
	{
		private List<Producto> _productos;

		public CarritoCompras()
		{
			_productos = new List<Producto>();
		}

		/// <summary>
		/// Método para agregar un producto al carrito.
		/// </summary>
		/// <param name="producto"></param>
		public void AgregarProducto(Producto producto)
		{
			_productos.Add(producto);
			Console.WriteLine($"Producto {producto.Nombre} agregado al carrito.");
		}

		/// <summary>
		/// Método para eliminar un producto del carrito por su ID.
		/// </summary>
		/// <param name="id"></param>
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

		/// <summary>
		/// Método para mostrar los productos en el carrito.
		/// </summary>
		public void MostrarCarrito()
		{
			Console.WriteLine("\nProductos en el Carrito:");
			foreach (var producto in _productos)
			{
				producto.MostrarInformacion();
			}
		}


		/// <summary>
		/// Método para calcular el total de la compra.
		/// </summary>
		/// <returns></returns>
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
