using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public abstract void display();

        /// <summary>
        /// 设置飞行行为
        /// </summary>
        /// <param name="fb"></param>
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void performFly()
        {
            flyBehavior.fly();
        }

        /// <summary>
        /// 设置叫声行为
        /// </summary>
        /// <param name="qb"></param>
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("所有鸭子都会漂浮，甚至游泳！");
        }
    }
}
