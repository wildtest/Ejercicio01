using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	public interface IInventario
	{
		void InsertarProducto(Producto producto);
		Producto ObtenerProductoPorId(int id);
		void MostrarProductos();
		void MostrarProductosDisponibles();
		void ModificarProducto(Producto producto);
	}
}
