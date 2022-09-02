using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_17Composicion
{
    class CEdificio
    {
        private string direccion;
        private int cantidadDepartamentos;
        private int departamentosRentados;

        public CEdificio(string pDireccion, int pCantidadDepartamentos, int pDepartamentosRentados)
        {
            direccion = pDireccion;
            cantidadDepartamentos = pCantidadDepartamentos;
            departamentosRentados = pDepartamentosRentados;
        }

        public void Muestra()
        {
            Console.WriteLine("Direccion:{0} CantidadDepartamentos:{1} DepartamentosRentados:{2}", direccion, cantidadDepartamentos, departamentosRentados);
        }
    }
}
