﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private Engine engine;
        
        public Car(CreateCar createCar)
        {
            engine = createCar.CreateMaschine();
        }

        public void CreateCar2()
        {
            engine.EngineEst();
        }
    }
}
