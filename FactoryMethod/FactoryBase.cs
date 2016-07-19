using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // 工厂基类（把创建产品的工作延迟到子类实现）
    abstract class FactoryBase
    {
        public abstract TankBase Create();
    }
}
