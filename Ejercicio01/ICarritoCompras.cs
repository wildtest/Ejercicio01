using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Interfaz que define las operaciones básicas de un carrito de compras.
	/// </summary>
	public interface ICarritoCompras
	{
		/// <summary>
		/// Método para agregar un producto al carrito de compras.
		/// </summary>
		/// <param name="producto"></param>
		void AgregarProducto(Producto producto);

		/// <summary>
		/// Método para buscar un producto en el carrito de compras por su ID.
		/// </summary>
		/// <param name="id"></param>
		void EliminarProducto(int id);

		/// <summary>
		/// Método para calcular el total del carrito de compras.
		/// </summary>
		void MostrarCarrito();
	}
}
