using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    // 轻坦克
    class TankA : TankBase
    {
        public TankA()
        {
            Console.WriteLine("Tank A 构造");
        }

        public override void Init()
        {
            Console.WriteLine("Tank A Init");
        }

        public override void Fire()
        {
            Console.WriteLine("Tank A Fire");
        }
    }
}
