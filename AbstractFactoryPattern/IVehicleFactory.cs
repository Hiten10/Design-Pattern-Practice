using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IVehicleFactory
    {
        IBike CreateBikes<T>() where T : IBike, new();
        IScooter CreateScooters<T>() where T : IScooter, new();
    }
}
