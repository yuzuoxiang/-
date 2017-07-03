using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 所有飞行行为类必须实现的接口
    /// </summary>
    public interface IFlyBehavior
    {
        /// <summary>
        /// 执行飞行动作
        /// </summary>
        void fly();
    }
}
