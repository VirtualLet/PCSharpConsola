using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_13Herencia
{
    class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;
        public string Puesto { get => puesto; set=> puesto = value; }
        public double Salario { get => salario; set => salario = value; }
        public void PonerDatos(string pNombre, int pEdad,string pPuesto, double pSalario)
        {
            Nombre = pNombre;
            Edad = pEdad;
            puesto = pPuesto;
            salario = pSalario;
        }

        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Puesto:{0} Salario:{1}", puesto, salario);
        }
    }
}
