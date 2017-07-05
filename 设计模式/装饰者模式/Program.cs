using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    class Program
    {
        /// <summary>
        /// 装饰者模式：动态的将责任附加到对象上。若要扩展功能，装饰者提供了比继承更有弹性的替代方案
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //订一杯Espresso，不需要调料，打印出它的描述与价格。
            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.getDescription() + "$" + beverage.cost());

            //再订一杯DarkRoast，加两倍Mocha，再加Whip
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + "$" + beverage2.cost());

            Console.ReadLine();
        }
    }
}
