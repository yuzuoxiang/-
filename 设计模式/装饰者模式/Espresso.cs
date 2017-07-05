using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public class Espresso:Beverage
    {
        public Espresso()
        {
            description = "浓咖啡";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
