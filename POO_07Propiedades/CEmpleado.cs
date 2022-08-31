using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_07Propiedades
{
    class CEmpleado
    {
        private float sueldo;
        private float impuesto;
        private float resultado;

        public CEmpleado()
        {
            impuesto = 1.15f;
        }
        public float Sueldo
        {
            get => sueldo; 
            set
            {
                if (value > 10000)
                    sueldo = value;
                else
                    sueldo = 10000;                
            }
        }

        private float Impuesto { get => impuesto; }        
     
        public void CalcularImpuesto() => resultado = sueldo + impuesto;        

        public string Mostrar()
        {
            return string.Format("Sueldo: {0}, Impuesto:{1}, SueldoBruto:{2}", Sueldo, Impuesto, resultado);
        }
    }
}
