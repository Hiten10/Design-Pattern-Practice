using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class RegularBike:IBike
    {
        public string Name()
        {
            return "Regular Bike";
        }
    }
}
