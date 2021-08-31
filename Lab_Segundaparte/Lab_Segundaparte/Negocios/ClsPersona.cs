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
        public string calcularIMC(ClsPersona persona)
        {
            double pro;
            pro = (persona.Peso / Math.Pow(persona.Altura, 2));
            
            if (pro <= 20)
            {
                return "Peso ideal";
            }
            else
            {
                return "Tiene sobre peso";
            }
        }
        public String esMayorDeEdad(ClsPersona persona)
        {
            if (persona.Edad >= 18)
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
