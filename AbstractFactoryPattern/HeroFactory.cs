using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class HeroFactory:IVehicleFactory
    {
        public IBike CreateBikes<T>() where T : IBike, new()
        {
            return new T();
        }

        public IScooter CreateScooters<T>() where T : IScooter, new()
        {
            return new T();
        }
    }
}
