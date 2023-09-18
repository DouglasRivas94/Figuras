using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FiguraBi
    {
        // Atributos
        public double radio { get; set; }
        public double lado { get; set; }

        // Métodos públicos
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
        public double CalcularVolumen()
        {
            return (4 / 3) * Math.PI * radio * radio * radio;
        }
        public double CalcularAreaT()
        {
            return (Math.Sqrt(3) / 4) * lado * lado;
        }
        public double CalcularVolumenT()
        {
            return (Math.Sqrt(3) / 4) * lado * lado * lado;
        }
        public double CalcularAreaCD()
        {
            return lado * lado;
        }
        public double CalcularVolumenCD()
        {
            return lado * lado * lado;
        }
    }
}
