using System;
using System.Collections.Generic;
using System.Linq;

namespace Resolucion
{
    internal class Program
    {
        static void Main()
        {
            // Crear una lista de objetos CelularNuevo.
            List<CelularNuevo> celularesNuevos = new List<CelularNuevo>();

            // Añadir 10 celulares nuevos a la lista.
            celularesNuevos.Add(new CelularNuevo("Samsung", "Galaxy S21", "Android", 8, 128, new DateTime(2023, 5, 15), 999.99M));
            celularesNuevos.Add(new CelularNuevo("Apple", "iPhone 13", "iOS", 6, 256, new DateTime(2023, 6, 10), 1199.99M));
            celularesNuevos.Add(new CelularNuevo("Google", "Pixel 6", "Android", 12, 512, new DateTime(2023, 4, 22), 1099.99M));
            celularesNuevos.Add(new CelularNuevo("OnePlus", "Nord 2", "Android", 12, 256, new DateTime(2023, 3, 5), 599.99M));
            celularesNuevos.Add(new CelularNuevo("Xiaomi", "Mi 11", "Android", 8, 128, new DateTime(2023, 7, 30), 799.99M));
            celularesNuevos.Add(new CelularNuevo("Samsung", "Galaxy A52", "Android", 6, 128, new DateTime(2023, 2, 8), 399.99M));
            celularesNuevos.Add(new CelularNuevo("Apple", "iPhone SE", "iOS", 4, 64, new DateTime(2023, 1, 20), 399.99M));
            celularesNuevos.Add(new CelularNuevo("Google", "Pixel 5a", "Android", 6, 128, new DateTime(2023, 8, 17), 449.99M));
            celularesNuevos.Add(new CelularNuevo("Xiaomi", "Redmi Note 10", "Android", 4, 64, new DateTime(2023, 9, 5), 299.99M));
            celularesNuevos.Add(new CelularNuevo("OnePlus", "9R", "Android", 8, 128, new DateTime(2023, 11, 12), 699.99M));

            // Mostrar los 10 celulares en la consola.
            Console.WriteLine("Listado de Celulares Nuevos:");
            foreach (var celular in celularesNuevos)
            {
                Console.WriteLine($"Marca: {celular.Marca}, Modelo: {celular.Modelo}, SO: {celular.SO}, RAM: {celular.RAM} GB, Almacenamiento: {celular.Almacenamiento} GB, Fecha de Ingreso: {celular.FechaIngreso.ToShortDateString()}, Precio: ${celular.Precio:F2}");
            }

            // Calcular el promedio de precios.
            double promedioPrecios = celularesNuevos.Average(c => (double)c.Precio);
            Console.WriteLine($"\nPromedio de Precios: ${promedioPrecios:F2}");

            // Buscar celulares de marca "Samsung".
            var Cel_MarcaS = celularesNuevos.Where(c => c.Marca == "Samsung").ToList();
            Console.WriteLine("\nCelulares de Marca Samsung:");
            foreach (var celular in Cel_MarcaS)
            {
                Console.WriteLine($"Modelo: {celular.Modelo}");
            }

            // Buscar celulares con RAM = 8GB, SO = Android y Almacenamiento de 128GB.
            var Celular_RSA = celularesNuevos.Where(c => c.RAM == 8 && c.SO == "Android" && c.Almacenamiento == 128).ToList();
            Console.WriteLine("\nCelulares con RAM = 8GB, SO = Android y Almacenamiento de 128GB:");
            foreach (var celular in Celular_RSA)
            {
                Console.WriteLine($"Marca: {celular.Marca}, Modelo: {celular.Modelo}");
            }

            // Buscar celulares que ingresaron en el año 2005.
            var Celular_Ingreso = celularesNuevos.Where(c => c.FechaIngreso.Year == 2005).ToList();
            Console.WriteLine("\nCelulares que ingresaron en el año 2005:");
            foreach (var celular in Celular_Ingreso)
            {
                Console.WriteLine($"Marca: {celular.Marca}, Modelo: {celular.Modelo}");
            }

            // Buscar y mostrar el modelo y precio de los celulares Apple.
            var CelularesApple = celularesNuevos.Where(c => c.Marca == "Apple").Select(c => new { Modelo = c.Modelo, Precio = c.Precio }).ToList();
            Console.WriteLine("\nModelo y Precio de los Celulares Apple:");
            foreach (var celular in CelularesApple)
            {
                Console.WriteLine($"Modelo: {celular.Modelo}, Precio: ${celular.Precio:F2}");
            }
        }
    }
}
