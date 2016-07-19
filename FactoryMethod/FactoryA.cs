using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FactoryA : FactoryBase
    {
        public override TankBase Create()
        {
            return new TankA();
        }
    }
}
