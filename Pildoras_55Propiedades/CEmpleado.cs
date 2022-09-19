using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_55Propiedades
{
    class CEmpleado
    {
        string nombre;
        double salario;
        public CEmpleado(string pNombre)
        {
            nombre = pNombre;
        }

        private double EvaluarSalario(double pSalario)
        {
            if (pSalario < 0) return 0;
            else return pSalario;
        }

        //public double Salario
        //{
        //    get { return salario; }
        //    set { salario = EvaluarSalario(value); }
        //}

        public double Salario
        {
            get => salario;
            set => salario = EvaluarSalario(value);
        }

        public void MuestraSalario()
        {
            Console.WriteLine("El salario de {0} es de {1} pesos",nombre,salario);
        }
    }
}
