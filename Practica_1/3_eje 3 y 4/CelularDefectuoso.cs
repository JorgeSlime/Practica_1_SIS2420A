using System;
namespace Resolucion
{
    public class CelularDefectuoso : Celular
    {
        public DateTime FechaIngreso { get; set; }
        public string Motivo { get; set; }

        public CelularDefectuoso(string marca, string modelo, string so, int ram, int almacenamiento, DateTime fechaIngreso, string motivo)
            : base(marca, modelo, so, ram, almacenamiento)
        {
            FechaIngreso = fechaIngreso;
            Motivo = motivo;
        }

        public override void mostrarCelular()
        {
            Console.WriteLine("Información del Celular Defectuoso:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Sistema Operativo: {SO}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Motivo del Defecto: {Motivo}");
        }
    }
}