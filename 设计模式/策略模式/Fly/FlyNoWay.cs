using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 这是飞行行为的实现，给不会飞的鸭子用
    /// </summary>
    class FlyNoWay:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("我不会飞！");
        }
    }
}
