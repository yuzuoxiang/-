using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    /// <summary>
    /// 因为要让CondimentDecorator能够取代Beverage，所以要继承Beverage
    /// </summary>
    public abstract class CondimentDecorator:Beverage
    {
        public abstract string getDescription();
    }
}
