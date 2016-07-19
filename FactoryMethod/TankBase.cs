using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Tank 基类
    abstract class TankBase
    {
        #region Field(域定义)
        private int id = 0;

        private int hp = 0;
        private int maxHp = 0;

        private int bulletNum = 0;
        private int maxBulletNum = 0;
        #endregion

        #region Property(属性定义)
        protected int Id
        {
            get { return id; }
            set { id = value; }
        }
        protected int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        protected int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        protected int BulletNum
        {
            get { return bulletNum; }
            set { bulletNum = value; }
        }
        protected int MaxBulletNum
        {
            get { return maxBulletNum; }
            set { maxBulletNum = value; }
        }
        #endregion

        #region 构造方法定义
        public TankBase()
        {
            Console.WriteLine("Tank Base...");
        }
        #endregion

        #region 成员方法定义
        public abstract void Init();
        public abstract void Fire();
        #endregion
    }
}
