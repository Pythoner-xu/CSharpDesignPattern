using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    // 只需要维护扩展这个就可以
    // 产品类型
    enum ProductType
    {
        A,
        B,
        C
    }
    // 简单工厂类
    class Factory
    {
        public TankBase Create(ProductType _type)
        {
            switch (_type)
            {
                case ProductType.A:
                    return new TankA();
                case ProductType.B:
                    return new TankB();
                case ProductType.C:
                    return new TankC();
                default:
                    return null;
            }
        }
    }
}
