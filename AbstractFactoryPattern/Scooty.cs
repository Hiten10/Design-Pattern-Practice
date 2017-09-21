using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Scooty:IScooter
    {
        public string Name()
        {
            return "Scooty";
        }
    }
}
