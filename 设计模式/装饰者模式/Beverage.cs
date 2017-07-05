using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    /// <summary>
    /// 饮料抽象类
    /// </summary>
    public abstract class Beverage
    {
        public string description = "未知饮料";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
