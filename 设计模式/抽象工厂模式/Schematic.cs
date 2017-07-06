using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class Schematic
    {
        static void Main(string[] args)
        {
            #region 示意性代码
            //1号抽象工厂
            AbstractFactory factory1 = new ConcreteFactory1();
            Client c1 = new Client(factory1);
            c1.Run();

            //2号抽象工厂
            AbstractFactory factory2 = new ConcreteFactory2();
            Client c2 = new Client(factory2);
            c2.Run();
            #endregion

            Console.Read();
        }
    }

    #region 示意性代码
    abstract class AbstractFactory
    {
        public abstract AbstractProductA createProductA();
        public abstract AbstractProductB createProductB();
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA createProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB createProductB()
        {
            return new productB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA createProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB createProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ProductA1 : AbstractProductA
    {
    }

    class productB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {
    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.createProductB();
            abstractProductA = factory.createProductA();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }

    }
    #endregion
}
