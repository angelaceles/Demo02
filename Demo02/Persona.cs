using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Persona
    {
        //Propiedad=Campo=Atributo
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public void DevolverNombresCompletos()
        {
            Console.WriteLine(Nombres + " " + Apellidos);
        }

        public int MultiplicarEdad(int factor)
        {
            return Edad * factor;
        }
    }
}
