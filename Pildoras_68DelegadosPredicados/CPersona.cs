using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_68DelegadosPredicados
{
    class CPersona
    {
        private string nombre;
        private int edad;
        private string nombreABusqueda;
        public string NombreABuscar
        {
            get => nombreABusqueda;
            set => nombreABusqueda = value;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
