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
    static void AgregarProducto()
    {
        Console.Write("Código: ");
        string codigo = Console.ReadLine();

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        decimal precio;
        while (true)
        {
            Console.Write("Precio: ");
            if (decimal.TryParse(Console.ReadLine(), out precio))
                break;
            Console.WriteLine("Precio inválido. Ingrese un número decimal.");
        }

        int cantidad;
        while (true)
        {
            Console.Write("Cantidad: ");
            if (int.TryParse(Console.ReadLine(), out cantidad))
                break;
            Console.WriteLine("Cantidad inválida. Ingrese un número entero.");
        }

        productos.Add(new Producto { Codigo = codigo, Nombre = nombre, Precio = precio, Cantidad = cantidad });
        Console.WriteLine("Producto agregado exitosamente.");
    }

    static void ListarProductos()
    {
        Console.WriteLine("\n--- Lista de Productos ---");
        foreach (var p in productos)
        {
            Console.WriteLine(p);
        }
    }

    static void BuscarProductoPorCodigo()
    {
