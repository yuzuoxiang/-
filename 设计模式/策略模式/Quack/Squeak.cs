using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Squeak:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("吱吱吱！");
        }
    }
}
