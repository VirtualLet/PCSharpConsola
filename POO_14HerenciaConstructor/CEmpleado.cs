using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_14HerenciaConstructor
{
    class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;

        public CEmpleado(string pNombre, int pEdad,string pPuesto, double pSalario)
            : base(pNombre,pEdad)
        {
            puesto= pPuesto;
            salario = pSalario;
        }
        public void MostrarEmpleado()
        {
            Mostrar();
            Console.WriteLine("Puesto:{0} Salario:{1}", puesto, salario);
        }
    }
}
