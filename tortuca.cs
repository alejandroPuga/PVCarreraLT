﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreaLT
{
    class tortuca : carrera

    {
        public tortuca(int a) : base(a)
        {
            this._posicion = 0;
        }

        new public int correr()
        {
            int avance = base.avanzar();
            return avance;
        }



    }
}
