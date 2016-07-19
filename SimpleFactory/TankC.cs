using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    // 火炮
    class TankC : TankBase
    {
        public TankC()
        {
            Console.WriteLine("Tank C 构造");
        }

        public override void Init()
        {
            Console.WriteLine("Tank C Init");
        }

        public override void Fire()
        {
            Console.WriteLine("Tank C Fire");
        }

        public void FireAt()
        {
            Console.WriteLine("Tank C FireAt");
        }
    }
}
