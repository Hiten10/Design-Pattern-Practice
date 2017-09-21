﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class VehicleFactory
    {
        public abstract IFactory CreateVehicle<T>() where T : IFactory, new();
    }
}