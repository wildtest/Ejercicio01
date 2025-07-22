using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IInventario inventario = new Inventario();
			CarritoCompras carrito = new CarritoCompras();

			var libro = new ProductoLibro(1, "C# para Principiantes", 29.99m, 50, "Juan Pérez", "Editorial 1", "978-84-978", 256);
			var cuaderno = new ProductoPapeleria(2, "Cuaderno A4", 5.50m, 100, "Espiral", "Verde", "A4");
			var lapicero = new ProductoPapeleria(3, "Lapicero Azul", 1.50m, 200, "Tinta Líquida", "Azul", "Grandes");
			inventario.InsertarProducto(libro);
			inventario.InsertarProducto(cuaderno);
			inventario.InsertarProducto(lapicero);

			bool ejecutando = true;
			while (ejecutando)
			{
				Console.WriteLine("\n=== MENÚ ===");
				Console.WriteLine("1. Crear Producto");
				Console.WriteLine("2. Insertar Producto al Inventario");
				Console.WriteLine("3. Mostrar Información de Producto");
				Console.WriteLine("4. Mostrar Productos Disponibles");
				Console.WriteLine("5. Modificar Producto");
				Console.WriteLine("6. Comprar Productos");
				Console.WriteLine("7. Salir");
				Console.Write("Selecciona una opción: ");
				string opcion = Console.ReadLine();

				switch (opcion)
				{
					case "1":
						Console.Write("Ingrese el nombre del producto: ");
						string nombre = Console.ReadLine();
						Console.Write("Ingrese el precio del producto: ");
						decimal precio = decimal.Parse(Console.ReadLine());
						Console.Write("Ingrese el stock del producto: ");
						int stock = int.Parse(Console.ReadLine());

						Console.WriteLine("Seleccione el tipo de producto:");
						Console.WriteLine("1. Libro");
						Console.WriteLine("2. Papelería");
						Console.WriteLine("3. Mochila");
						Console.WriteLine("4. Electrónico");
						string tipoProducto = Console.ReadLine();

						Producto nuevoProducto = null;
						switch (tipoProducto)
						{
							case "1":
								Console.Write("Ingrese el autor del libro: ");
								string autor = Console.ReadLine();
								Console.Write("Ingrese la editorial del libro: ");
								string editorial = Console.ReadLine();
								Console.Write("Ingrese el ISBN del libro: ");
								string isbn = Console.ReadLine();
								Console.Write("Ingrese número de páginas del libro: ");
								int numeropaginas = int.Parse(Console.ReadLine());
								nuevoProducto = new ProductoLibro(0, nombre, precio, stock, autor, editorial, isbn, numeropaginas);
								break;
							case "2":
								Console.Write("Ingrese el Tipo de del Producto Papelería: ");
								string tipo = Console.ReadLine();
								Console.Write("Ingrese el el Color del Producto Papelería: ");
								string color = Console.ReadLine();
								Console.Write("Ingrese el Tamaño del Producto Papelería: ");
								string tamanio = Console.ReadLine();
								nuevoProducto = new ProductoPapeleria(0, nombre, precio, stock, tipo, color, tamanio);
								break;
							case "3":
								Console.Write("Ingrese el material de la mochila: ");
								string material = Console.ReadLine();
								Console.Write("Ingrese dimensiones de la mochila: ");
								string dimensiones = Console.ReadLine();
								Console.Write("Ingrese compartimentos de la mochila: ");
								int compartimentos = int.Parse(Console.ReadLine());
								nuevoProducto = new ProductoMochila(0, nombre, precio, stock, material, compartimentos, dimensiones);
								break;
							case "4":
								Console.Write("Ingrese el tipo de producto electrónico: ");
								string tipoProductoElectronico = Console.ReadLine();
								Console.Write("Ingrese fuente de nergía de producto electrónico: ");
								string fuenteEnergia = Console.ReadLine();
								nuevoProducto = new ProductoElectronico(0, nombre, precio, stock, tipoProductoElectronico, fuenteEnergia);
								break;
							default:
								Console.WriteLine("Opción inválida.");
								break;
						}

						if (nuevoProducto != null)
						{
							inventario.InsertarProducto(nuevoProducto);
						}
						break;

					case "2":
						Console.Write("Ingrese el ID del producto: ");
						int idInsertar = int.Parse(Console.ReadLine());
						Producto productoInsertar = inventario.ObtenerProductoPorId(idInsertar);
						if (productoInsertar != null)
						{
							inventario.InsertarProducto(productoInsertar);
						}
						else
						{
							Console.WriteLine("Producto no encontrado.");
						}
						break;

					case "3":
						Console.Write("Ingrese el ID del producto para ver detalles: ");
						int idDetalles = int.Parse(Console.ReadLine());
						Producto productoDetalles = inventario.ObtenerProductoPorId(idDetalles);
						if (productoDetalles != null)
						{
							productoDetalles.MostrarInformacion();
							productoDetalles.MostrarDetalles();
						}
						else
						{
							Console.WriteLine("Producto no encontrado.");
						}
						break;

					case "4":
						inventario.MostrarProductos();
						break;

					case "5":
						Console.Write("Ingrese el ID del producto a modificar: ");
						int idModificar = int.Parse(Console.ReadLine());
						Producto productoModificar = inventario.ObtenerProductoPorId(idModificar);
						if (productoModificar != null)
						{
							Console.Write("Ingrese el nuevo nombre del producto: ");
							productoModificar.Nombre = Console.ReadLine();
							Console.Write("Ingrese el nuevo precio del producto: ");
							productoModificar.Precio = decimal.Parse(Console.ReadLine());
							Console.Write("Ingrese el nuevo stock del producto: ");
							productoModificar.Stock = int.Parse(Console.ReadLine());
							inventario.ModificarProducto(productoModificar);
						}
						else
						{
							Console.WriteLine("Producto no encontrado.");
						}
						break;

					case "6":
						Console.WriteLine("\nSelecciona productos disponibles para agregar al carrito:");
						inventario.MostrarProductosDisponibles();

						Console.Write("Ingresa el ID del producto que deseas agregar al carrito (0 para terminar): ");
						int idProducto = int.Parse(Console.ReadLine());

						while (idProducto != 0)
						{
							var producto = inventario.ObtenerProductoPorId(idProducto);
							if (producto != null && producto.Stock > 0)
							{
								carrito.AgregarProducto(producto);
							}
							else
							{
								Console.WriteLine("Producto no válido o fuera de stock.");
							}

							Console.Write("Ingresa el ID de otro producto o 0 para terminar: ");
							idProducto = int.Parse(Console.ReadLine());
						}
						carrito.MostrarCarrito();
						Console.Write("Seleccione el método de pago (Yape, Efectivo, TarjetaCredito, TarjetaDebito): ");
						string metodo = Console.ReadLine();
						//MetodoPago metodoPago = Enum.Parse<MetodoPago>(metodo, true);
						if (Enum.TryParse(metodo, true, out MetodoPago metodoPago))
						{
							decimal total = carrito.TotalCompra();
							Pagos.RealizarPago(metodoPago, total);
						}
						else
						{
							Console.WriteLine("Método de pago no válido.");
						}
						break;

					case "7":
						ejecutando = false;
						break;

					default:
						Console.WriteLine("Opción inválida.");
						break;
				}
			}
		}
	}
}
