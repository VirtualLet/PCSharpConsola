using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_22Polimorfismo
{
    class CPato:CAnimal
    {
    //    string nombre;
    //    public string Nombre { get => nombre; set => nombre = value; }
        public override string Moverse()
        {
            return string.Format("El pato {0} camina ", nombre);
        }
    }
}
