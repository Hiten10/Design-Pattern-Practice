using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConcereteVehicleFactory:VehicleFactory
    {
        public override IFactory CreateVehicle<T>()
        {
            return new T();
        }
    }
}
