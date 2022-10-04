using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_25MetodosDeExtension
{
    class CPersona:IBienvenida
    {
        private string nombre;
        private int edad;

        public CPersona (string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }
        public string Nombre
        {
            get => nombre;            
        }
        public int Edad
        {
            get => edad;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola desde clase Persona");
        }

        public override string ToString()
        {
            return string.Format("Nombre:{0} Edad:{1}", nombre, edad);
        }
    }
}
