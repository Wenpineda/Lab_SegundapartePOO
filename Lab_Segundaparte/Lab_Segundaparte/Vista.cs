using Lab_Segundaparte.Entidades;
using Lab_Segundaparte.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Segundaparte
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            ClsPersona cls = new ClsPersona();

            Console.WriteLine("Escribe tu Nombre: ");
            string nombre = (Console.ReadLine());

            Console.WriteLine("Ingresa tu genero F o M: ");
            string sexo = (Console.ReadLine());

            Console.WriteLine("Ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu peso ");
            double peso =Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Ingresa tu altura: ");
            double altura = Convert.ToDouble (Console.ReadLine());

            Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);

            Console.WriteLine(cls.calcularIMC(persona1));

            Console.WriteLine(cls.esMayorDeEdad(persona1));

            Console.WriteLine(persona1.ToString());
            Console.ReadLine();
        }
    }
}
