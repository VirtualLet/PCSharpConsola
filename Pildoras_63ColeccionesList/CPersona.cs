﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_63ColeccionesList
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Edad
        {
            get => edad;
            set=>edad=value,
        }
    }
}
