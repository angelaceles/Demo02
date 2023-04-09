using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Demo02
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola mundo");

            //Declarar variables
            int Edad = 0;
            string Nombre = "Hugo";

            //Declarar Objetos
            //Primera Forma
            Persona persona = new Persona();
            persona.Nombres = "Hugo";
            persona.Apellidos = "Torrico";
            persona.Edad = 34;

            //Segunda Forma
            Persona persona1 = new Persona
            {
                Nombres = "Reyna",
                Apellidos = "Marquez",
                Edad = 34
            };


            //persona.DevolverNombresCompletos();
            //int doble = persona.MultiplicarEdad(5);
            //Console.WriteLine(doble);

            Triangulo triangulo = new Triangulo
            {
                LadoA = 3,
                LadoB = 4,
                LadoC = 5
            };
            //double area = triangulo.CalcularArea();
            //Console.WriteLine(area)
            //
            //;

            Cuadrado cuadrado = new Cuadrado
            {
                LadoA = 5,
                LadoB = 4,
            };
            double perimetro = cuadrado.CalcularPerimetro();
            double area = cuadrado.CalcularArea();
            //Console.WriteLine("El perimetro es" + " " + perimetro);
            //Console.WriteLine("El area es" + " " + area);

            Producto producto = new Producto
            {
                Nombre = "Reyna",
                Precio = 14,
                FechaVecimiento = "12/23/212",
                Descripcion = "Vencido",
                Estado = "NO"
            };

            producto.CalcularPrecioVenta();
            producto.CalcularEstado();
            Console.Read();
        }
    } 
}
