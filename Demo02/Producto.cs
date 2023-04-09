using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string FechaVecimiento { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public void CalcularEstado()
        {
            if (Estado == "SI")
            {
                Console.WriteLine("Vencido");
            }
            else
            {
                Console.WriteLine("No esta Vencido");
            }
        }
        
        public void CalcularPrecioVenta()
        {
            double IGV = Precio * 0.18;
            double PrecioVenta = Precio + IGV;
            Console.WriteLine("Precio de Venta es " + " " +PrecioVenta);
            Console.WriteLine("El IGV es de " + " " + IGV);
        }
    }
}
