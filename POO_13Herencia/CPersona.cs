using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_13Herencia
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public string Nombre { get=>nombre; set=>nombre=value; }
        public int Edad
        {
            get => edad;
            set
            {
                if (value > 18) edad = value;
                else { edad = -1; Console.WriteLine("La edad no permitida, debe ser mayor a 18 años"); }
            }
        }

        public void ValidaRangoEdad()
        {
            if (edad == -1)
            {
                Console.WriteLine("La edad no permitida, debe ser mayor a 18 años");
            }
        }
        public void Muestra()
        {
            Console.WriteLine("Nombre {0}, Edad{1}",nombre,edad);
        }
    }
}
