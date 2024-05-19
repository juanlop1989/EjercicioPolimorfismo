using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return 0.5 * Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            // Suponiendo que es un triángulo equilátero
            return 3 * Base;
        }
    }
}
