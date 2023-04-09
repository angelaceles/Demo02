using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Triangulo
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        private double CalcularSemiperimetro()
        {
            return (LadoA+LadoB+LadoC)/2;
        }

        public double CalcularArea()
        {
            double semi = CalcularSemiperimetro();
            double area = Math.Sqrt(semi * (semi-LadoA) * (semi - LadoB) * (semi - LadoC));
            
            return area;
        }
    }
    
}
