using Lab_Segundaparte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Segundaparte.Negocios
{
    class ClsPersona
    {
        public string calcularIMC(Persona persona1)
        {
            double pro;
            pro = (persona1.Peso / Math.Pow(persona1.Altura, 2));
            
            if (pro <= 20)
            {
                return "Peso ideal";
            }
            else
            {
                return "Tiene sobre peso";
            }
        }
        public String esMayorDeEdad(Persona persona1)
        {
            if (persona1.Edad >= 18)
            {
                return "Es mayor de Edad";
            }
            else
            {
                return "Es menor de edad";
            }

        }
    }   
        
}
