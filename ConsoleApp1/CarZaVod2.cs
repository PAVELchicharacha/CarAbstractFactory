﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarZaVod2 : CreateCar
    {
        public override Engine CreateMaschine()
        {
            return new FuelEngine();
        }

    }
}
