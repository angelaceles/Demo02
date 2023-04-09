using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Cuadrado
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }

        public double CalcularPerimetro()
        {
            return (LadoA + LadoB) * 2;
        }

        public double CalcularArea()
        {
            double area = (LadoA*LadoB);
            return area;
        }
    }
}
