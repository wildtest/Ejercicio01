using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public class Inventario: IInventario
	{
		private List<Producto> _productos;

		public Inventario()
		{
			_productos = new List<Producto>();
		}

		public void InsertarProducto(Producto producto)
		{
			_productos.Add(producto);
			Console.WriteLine($"Producto {producto.Nombre} insertado al inventario.");
		}

		public Producto ObtenerProductoPorId(int id)
		{
			return _productos.Find(p => p.Id == id);
		}

		public void MostrarProductos()
		{
			foreach (var producto in _productos)
			{
				producto.MostrarInformacion();
			}
		}

		public void MostrarProductosDisponibles()
		{
			foreach (var producto in _productos)
			{
				if (producto.Stock > 0)
				{
					producto.MostrarInformacion();
				}
			}
		}

		public void ModificarProducto(Producto producto)
		{
			var productoExistente = ObtenerProductoPorId(producto.Id);
			if (productoExistente != null)
			{
				productoExistente.Nombre = producto.Nombre;
				productoExistente.Precio = producto.Precio;
				productoExistente.Stock = producto.Stock;
				Console.WriteLine($"Producto {producto.Nombre} modificado.");
			}
			else
			{
				Console.WriteLine("Producto no encontrado.");
			}
		}
	}
}
