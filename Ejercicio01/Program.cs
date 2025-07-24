using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
	/// <summary>
	/// Clase Program desde la cual se ejecuta el sistema
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Método Main desde la cual ejecuta el sistema e invoca a las demás funcionalidades
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			MenuPrincipal menuPrincipal = new MenuPrincipal();

			while (menuPrincipal.salir == false)
			{
				Console.Clear();
				Console.WriteLine("=== BIENVENIDO AL SISTEMA DE LIBRERIA ===");
				Console.WriteLine("Seleccione una opción del menú:");
				string opcionSeleccionada = menuPrincipal.MostrarOpcionesMenu();
				menuPrincipal.SeleccionarOpcionesMenu(opcionSeleccionada);
			}
		}
	}
}
