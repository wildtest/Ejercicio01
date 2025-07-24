using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase Inventario que implementa la interfaz IInventario y gestiona un inventario de productos.
	/// </summary>
	public class Inventario: IInventario
	{
		private List<Producto> productos = new List<Producto>();

		/// <summary>
		/// Constructor de la clase Inventario que inicializa algunos productos de ejemplo.
		/// </summary>
		public Inventario()
		{
			var libro = new ProductoLibro(1, "C# para Principiantes", 29.99m, 50, "Juan Pérez", "Editorial 1", "978-84-978", 256);
			var cuaderno = new ProductoPapeleria(2, "Cuaderno A4", 5.50m, 100, "Espiral", "Verde", "A4");
			var lapicero = new ProductoPapeleria(3, "Lapicero Azul", 1.50m, 200, "Tinta Líquida", "Azul", "Grandes");
			productos.Add(libro);
			productos.Add(cuaderno);
			productos.Add(lapicero);
		}

		/// <summary>
		/// Método para insertar un producto en el inventario.
		/// </summary>
		/// <param name="producto"></param>
		public void AgregarProducto(int idProducto)
		{
			Producto producto = ObtenerProductoPorId(idProducto);
			if (producto != null)
			{
				productos.Add(producto);
				Console.WriteLine($"Producto {producto.Nombre} insertado al inventario.");
			}
			else {
				Console.WriteLine("Producto no encontrado.");
			}
			
		}


		/// <summary>
		/// Método para registrar un nuevo producto en el inventario.
		/// </summary>
		/// <param name="producto"></param>
		public void RegistrarProducto(Producto producto)
		{
			if (producto != null && !productos.Any(p => p.Id == producto.Id))
			{
				productos.Add(producto);
				Console.WriteLine($"Producto {producto.Nombre} registrado.");
			}
			else
			{
				Console.WriteLine("Producto ya existe o es inválido.");
			}
		}


		/// <summary>
		/// Método para obtener un producto por su ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Producto ObtenerProductoPorId(int id)
		{
			return productos.Find(p => p.Id == id);
		}


		/// <summary>
		/// Método para mostrar todos los productos del inventario.
		/// </summary>
		public void MostrarProductos()
		{
			foreach (var producto in productos)
			{
				producto.MostrarInformacion();
			}
		}

		/// <summary>
		/// Método para obtener la cantidad de productos en el inventario.
		/// </summary>
		/// <returns></returns>
		public int ObtenerCantidadProductos()
		{
			return productos.Count;
		}


		/// <summary>
		/// Método para mostrar los productos disponibles en el inventario.
		/// </summary>
		public void MostrarProductosDisponibles()
		{
			foreach (var producto in productos)
			{
				if (producto.Stock > 0)
				{
					producto.MostrarInformacion();
				}
			}
		}


		/// <summary>
		/// Método para modificar un producto en el inventario.
		/// </summary>
		/// <param name="producto"></param>
		public void ActualizarProducto(int idproducto, string nombre, decimal precio, int stock)
		{
			Producto producto = ObtenerProductoPorId(idproducto);
			if (producto != null)
			{
				producto.Nombre = nombre;
				producto.Precio = precio;
				producto.Stock = stock;
				Console.WriteLine($"Producto {producto.Nombre} modificado.");
			}
			else
			{
				Console.WriteLine("Producto no encontrado.");
			}
		}
	}
}
