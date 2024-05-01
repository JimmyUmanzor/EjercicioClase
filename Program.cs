using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class Program
    {
        static void Main(string[] args)
        {
            SuperHeroe superHeroe1 = new SuperHeroe("Superman", "Clark Kent", "Metrópolis", true, new SuperPoder("Super fuerza", "Capacidad de levantar objetos muy pesados", 10));
            SuperHeroe superHeroe2 = new SuperHeroe("Aquaman", "Arthur Curry", "Atlantis", false, new SuperPoder("Control de los mares", "Poder de omunicarse y controlar a los animales del mar", 9));
            SuperHeroe superHeroe3 = new SuperHeroe("Flash", "Barry Allen", "Central City", false, new SuperPoder("Velocidad sobrehumana", "Capacidad de moverse a velocidades extremadamente altas", 6));

            Console.WriteLine(superHeroe1);
            Console.WriteLine(superHeroe2);
            Console.WriteLine(superHeroe3);
            Console.ReadLine();
        }
    }

    class SuperHeroe
    {
        public string nombre;
        public string identidadSecreta;
        public string ciudad;
        public bool puedeVolar;
        public SuperPoder superPoder;

        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
        {
            this.nombre = nombre;
            this.identidadSecreta = identidadSecreta;
            this.ciudad = ciudad;
            this.puedeVolar = puedeVolar;
            this.superPoder = superPoder;
        }

        public override string ToString()
        {
            return
                $"Nombre: {nombre}\n" +
                $"Identidad Secreta: {identidadSecreta}\n" +
                $"Ciudad: {ciudad}\n" +
                $"Puede Volar: {(puedeVolar ? "Sí" : "No")}\n" +
                $"Super Poder: {superPoder}";
        }
    }

    class SuperPoder
    {
        public string nombre;
        public string descripcion;
        public int nivel;

        public SuperPoder(string nombre, string descripcion, int nivel)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.nivel = nivel;
        }

        public override string ToString()
        {
            return $"{nombre}\n" +
                    $"Descripción: {descripcion}\n" +
                    $"Nivel: {nivel}\n" +
                     "-----------------------------------";
        }
    }
}