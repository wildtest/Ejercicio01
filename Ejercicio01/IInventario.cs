using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Interfaz que define las operaciones básicas de un inventario.
	/// </summary>
	public interface IInventario
	{
		/// <summary>
		/// Método para insertar un producto en el inventario.
		/// </summary>
		/// <param name="producto"></param>
		void AgregarProducto(int idProducto);

		/// <summary>
		/// Método para eliminar un producto del inventario.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Producto ObtenerProductoPorId(int id);

		/// <summary>
		/// Método para mostrar todos los productos del inventario.
		/// </summary>
		void MostrarProductos();

		/// <summary>
		/// Método para mostrar los productos disponibles en el inventario.
		/// </summary>
		void MostrarProductosDisponibles();

		/// <summary>
		/// Método para modificar un producto en el inventario.
		/// </summary>
		/// <param name="producto"></param>
		void ActualizarProducto(int idproducto, string nombre, decimal precio, int stock);
	}
}
