using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_51Interfaces_Ejemplo
{
    class CAvisoTrafico : IAviso
    {
        private string fecha;
        private string remitente;
        private string mensaje;
        public CAvisoTrafico(string pFecha, string pRemitente, string pMensaje)
        {
            fecha = pFecha;
            remitente = pRemitente;
            mensaje = pMensaje;
        }
        public CAvisoTrafico()
        {
            fecha = "";
            remitente = "SAT";
            mensaje = "Aviso de revisar su buzon tributario";
        }

        public string GetFecha()
        {
            return "La fecha del aviso es:"+fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Fecha:{0} \n" +
                            " Remitente:{1} \n" +
                            " Mensaje:{2} \n ",fecha,remitente,mensaje);
        }
    }
}
