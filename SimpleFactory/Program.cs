using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 场景：堡垒守卫战
    /// 玩法：玩家选择一种坦克（花钱购买）守卫最后防线，誓死阻挡大批外星蚁族的入侵
    /// 简单工厂：分离了责任模块（一个负责生产、一个负责消费），增加新产品的时候，需要增加一个产品类、并修改工厂类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########简单工厂########");
            // 可维护性差
            //TankA A = new TankA();
            //A.Init();
            //A.Fire();

            // 可维护性相比之下比较好
            Factory factory = new Factory();
            // 父类指向子类对象
            TankBase t1 = factory.Create(ProductType.A);
            t1.Init();
            t1.Fire();


            Console.ReadLine();
        }
    }
}
