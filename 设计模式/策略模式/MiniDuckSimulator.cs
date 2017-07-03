using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class MiniDuckSimulator
    {
        /// <summary>
        /// 策略模式：定义了算法族，分别封装起来，让它们之间可以互相替换，此模式让算法的变化独立于使用算法的客户
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();
            //修改叫声行为
            mallard.setQuackBehavior(new Squeak());
            mallard.performQuack();
            Console.Read();
        }
    }
}
