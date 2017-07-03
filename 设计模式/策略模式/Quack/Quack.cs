using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Quack:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("嘎嘎嘎！");
        }
    }
}
