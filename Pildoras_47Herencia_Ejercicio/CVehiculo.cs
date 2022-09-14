using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_47Herencia_Ejercicio
{
    class CVehiculo
    {
        public  void PonerEnMarchaMotor()
        {
            Console.WriteLine("Se inicia la puesta en marcha del motor");
        }

        public void DetenerMotor()
        {
            Console.WriteLine("Se inicia alto total del motor");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("El vehiculo conduce");
        }
    }
}
