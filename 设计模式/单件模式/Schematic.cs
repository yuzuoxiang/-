using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单件模式
{
    class Schematic
    {
        static void Main(string[] args)
        {
            #region 示意性代码
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            if (s1 == s2)
            {
                Console.WriteLine("两个类相同");
            }
            #endregion

            Console.ReadLine();
        }
    }

    #region 示意性代码
    class Singleton
    {
        private static Singleton instance;

        //禁止被外部实例化
        protected Singleton() { }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
    #endregion
}
