using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_69DelegadosExpresionesLambda
{
    class CPersona
    {
        string nombre;
        int edad;
        int logros;
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public int Logros
        {
            get => logros;
            set => logros = value;
        }
    }
}
