﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Perro
    {
        //Perro nombre clor origen
        private string nombre;
        private string color;
        private string origen;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

    }
}
