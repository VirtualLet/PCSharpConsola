﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_22Polimorfismo
{
    class CPez:CAnimal
    {
        //string nombre;
        //public string Nombre { get => nombre; set => nombre = value; }
        public override string Moverse()
        {
            return string.Format("El pez {0} nada ", nombre);
        }
    }
}
