﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight05
{
    interface IFlyweight
    {
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenerNombre();
    }
}
