using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_57Structs
{
   public struct Empleado
    {
       string nombre;
        double salario;
        double comision;
        
        public Empleado(string pNombre,double pSalarioBase, double pComision)
        {
            nombre = pNombre;
            salario = pSalarioBase;          
            comision = pComision;
        }

        private double EvaluarSalario(double pSalario)
        {
            if (pSalario < 0) return 0;
            else return pSalario;
        }


        public double Salario
        {
            get => salario;
            set => salario = EvaluarSalario(value);
        }

        public void CambiarSalario(double pIncremento)
        {
            Salario += pIncremento;
            comision += pIncremento;
        }

        //Al intentar enviarlo por referencia a la clase cuando se usa struct no se reflejará cambio
        public void CambiarSalario(Empleado pEmp, double pIncremento)
        {
            pEmp.salario += pIncremento;
            pEmp.comision += pIncremento;
        }

        public override string ToString()
        {
       
          return string.Format("El salario de {2},  es de {0} y la comisión es {1}", EvaluarSalario(salario),comision,nombre);

        }
    }
}
