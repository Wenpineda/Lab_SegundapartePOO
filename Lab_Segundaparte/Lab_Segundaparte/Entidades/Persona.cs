using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Segundaparte.Entidades
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public Persona(string nombre, int edad, string sexo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;           
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Altura = altura;
        }

        public Persona(double peso, int altura)
        {
            this.Peso = peso;
            this.Altura = altura;
        }

        public Persona()
        {

        }

        public override string ToString()
        {
            return nombre + " " + edad + " " + sexo + " " + peso + " " + altura;
        }
    }
}
