using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class FigurasTri
    {
        //Atributos
        public double radio { get; set; }
        public double lado { get; set; }

        // Métodos públicos
        public double CalcularArea()
        {
            return 4 * Math.PI * radio * radio;
        }
        public double CalcularVolumen()
        {
            return (4 / 3) * Math.PI * radio * radio * radio;
        }
        public double CalcularAreaCB()
        {
            return 6 * lado * lado;
        }
        public double CalcularVolumenCB()
        {
            return lado * lado * lado;
        }
        public double CalcularAreaTE()
        {
            return Math.Sqrt(3) * lado * lado;
        }
        public double CalcularVolumenTE()
        {
            return (Math.Sqrt(2) / 12) * lado * lado * lado;
        }

    }
}
