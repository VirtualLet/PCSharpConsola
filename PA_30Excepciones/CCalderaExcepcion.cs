using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_30Excepciones
{
    class CCalderaExcepcion:ApplicationException
    {
        private string mensaje = "";
        private DateTime momento;
        private string causa;
        public DateTime Momento
        {
            get => momento;
            set => momento = value;
        }
        public String Causa
        {
            get => causa;
            set => causa = value;
        }

        //public CCalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento)
        //{
        //    mensaje = pMensaje;
        //    causa = pCausa;
        //    momento = pMomento;
        //}
        //public override string Message
        //{
        //    get => string.Format("Mensaje de la excepción=>{0}", mensaje);
        //}

        //Aqui se eviata hacer el override de Mensaje y se utiliza la clase base
        public CCalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento) : base(pMensaje)
        {
            causa = pCausa;
            momento = pMomento;
        }

    }
}
