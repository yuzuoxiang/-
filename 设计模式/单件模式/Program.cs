using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace 单件模式
{
    /// <summary>
    /// 意图：保证一个类仅有一个实例，并提供一个访问它的全局访问点、
    /// 适用性：当类只能有一个实例而且客户可以从一个众所周知的访问点访问它时，
    /// 当这个唯一实例应该是通过子类化可扩展的，并且客户应该无需更改代码就能使用一个扩展的实例时。    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 示意性代码
            //Singleton s1 = Singleton.Instance();
            //Singleton s2 = Singleton.Instance();
            //if (s1 == s2)
            //{
            //    Console.WriteLine("两个类相同");
            //}
            #endregion

            #region 实际应用
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("所有类相同");
            }

            //所有都是相同的实例 - 任意使用b1负载平衡15个服务器请求
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(b1.Server);
            }

            #endregion

            Console.ReadLine();
        }
    }

    #region 实际应用
    class LoadBalancer
    {
        private static LoadBalancer instance;
        private ArrayList servers = new ArrayList();

        private Random random = new Random();

        //锁定同步对象
        private static object syncLock = new object();

        //构造函数
        protected LoadBalancer()
        {
            //可用服务器列表
            servers.Add("Server1");
            servers.Add("Server2");
            servers.Add("Server3");
            servers.Add("Server4");
            servers.Add("Server5");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            //支持多线程应用程序“双重锁定”模式（一次实例存在）避免锁定每个调用该方法的时间
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }

            return instance;
        }

        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }

    }
    #endregion

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
