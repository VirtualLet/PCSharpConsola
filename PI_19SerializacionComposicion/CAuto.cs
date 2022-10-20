using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_19SerializacionComposicion
{
    [Serializable]
    //La clase debe ser publica
   public class CAuto
    {
        private double costo;
        private string modelo;
        private CMotor motor;
        public CAuto()//El constructor no debe tener parametros
        {
            Costo = 1000;
            Modelo = "Vocho";
            motor = new CMotor();
        }

        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public CMotor Motor { set => motor=value; }

        public void MuestraInformacion()
        {
            Console.WriteLine("Automovil {0} Costo {1}",Modelo,Costo);
            motor.MuestraMotor();
            Console.WriteLine("----");
        }
    }

    [Serializable]
    //La clase debe ser publica
    public class CAutoXML
    {
        private double costo;
        private string modelo;
        private CMotorXML motor;
        public CAutoXML()//El constructor no debe tener parametros
        {
            Costo = 1000;
            Modelo = "Vocho";
            motor = new CMotorXML();
        }
        public CAutoXML(string pModelo, double pCosto, int pCilindro, int pHP)
        {
            modelo = pModelo;
            costo = pCosto;
            motor = new CMotorXML(pCilindro, pHP);
        }
        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public CMotorXML Motor { set => motor = value; get => motor; }

        public void MuestraInformacion()
        {
            Console.WriteLine("Automovil {0} Costo {1}", Modelo, Costo);
            motor.MuestraMotor();
            Console.WriteLine("----");
        }
    }
}
