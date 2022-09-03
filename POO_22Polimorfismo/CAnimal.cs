using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_22Polimorfismo
{
    class CAnimal
    {
       protected string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        public virtual string Moverse()
        {
            return string.Format("El animal {0} se mueve ", nombre);
        }
    }
}
