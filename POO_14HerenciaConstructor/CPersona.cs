using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_14HerenciaConstructor
{
    class CPersona
    {
        private string nombre;
        private int edad;
        public CPersona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}  Edad: {1}",nombre,edad);
        }
    }
}
