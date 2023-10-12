using System;
namespace Resolucion
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SO { get; set; }
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }

        public Celular(string marca, string modelo, string so, int ram, int almacenamiento)
        {
            Marca = marca;
            Modelo = modelo;
            SO = so;
            RAM = ram;
            Almacenamiento = almacenamiento;
        }

        public abstract void mostrarCelular();
    }
}