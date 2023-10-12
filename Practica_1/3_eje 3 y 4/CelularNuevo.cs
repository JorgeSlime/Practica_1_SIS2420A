using System;
namespace Resolucion
{
    public class CelularNuevo : Celular
    {
        public DateTime FechaIngreso { get; set; }
        public decimal Precio { get; set; }

        public CelularNuevo(string marca, string modelo, string so, int ram, int almacenamiento, DateTime fechaIngreso, decimal precio)
            : base(marca, modelo, so, ram, almacenamiento)
        {
            FechaIngreso = fechaIngreso;
            Precio = precio;
        }

        public override void mostrarCelular()
        {
            Console.WriteLine("Información del Celular Nuevo:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Sistema Operativo: {SO}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Precio: ${Precio:F2}");
        }
    }
}