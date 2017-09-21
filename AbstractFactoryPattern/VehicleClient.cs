using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class VehicleClient<T> where T: Interface1
    {
        IBike _bike;
        IScooter _scooter;

        public VehicleClient(IVehicleFactory vehicleFactory, Interface1 obj)
        {            
            _bike = vehicleFactory.CreateBikes<T>();
        }

        public string GetScooter()
        {
            return _bike.Name();
        }

        public string GetBike()
        {
            return _scooter.Name();
        }
    }
}
