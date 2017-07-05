﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double cost()
        {
            return 2.00;
        }
    }
}
