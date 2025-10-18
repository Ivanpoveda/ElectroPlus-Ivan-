// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    public override string ToString()
    {
        return $"{Codigo}|{Nombre}|{Precio}|{Cantidad}";
    }
}

class InventarioElectroPlus
{
    static List<Producto> productos = new List<Producto>();

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Menú Inventario ElectroPlus ---");
            Console.WriteLine("a. Agregar producto");
            Console.WriteLine("b. Listar productos");
            Console.WriteLine("c. Buscar producto por Código");
            Console.WriteLine("d. Mostrar productos con Cantidad = 0");
            Console.WriteLine("e. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()?.ToLower();

            switch (opcion)
            {
                case "a":
                    AgregarProducto();
                    break;
                case "b":
                    ListarProductos();
                    break;
                case "c":
                    BuscarProductoPorCodigo();
                    break;
                case "d":
                    MostrarSinStock();
                    break;
                case "e":
                    continuar = false;
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }
