using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 所有叫声行为类必须实现的接口
    /// </summary>
    public interface IQuackBehavior
    {
        /// <summary>
        /// 执行叫声动作
        /// </summary>
        void quack();
    }
}
