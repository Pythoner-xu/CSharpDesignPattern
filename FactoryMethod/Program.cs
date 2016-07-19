using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 工厂方法的好处在于增加新产品的时候，不需要改动工厂类，只需要添加一个产品类和一个该产品的工厂类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########工厂方法########");
            //TankA a = new TankA();
            //a.Init();
            //a.Fire();

            FactoryBase Fac = new FactoryA();
            TankBase tank = Fac.Create();
            tank.Init();
            tank.Fire();

            Fac = new FactoryB();
            tank = Fac.Create();
            tank.Init();
            tank.Fire();

            Console.ReadLine();
        }
    }
}
