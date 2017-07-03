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
        /// 
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
