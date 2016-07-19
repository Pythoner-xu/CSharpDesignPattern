using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    // 重坦克
    class TankB : TankBase
    {
        public TankB()
        {
            Console.WriteLine("Tank B 构造");
        }
        public override void Init()
        {
            Console.WriteLine("Tank B Init");
        }

        public override void Fire()
        {
            Console.WriteLine("Tank B Fire");
        }
    }
}
