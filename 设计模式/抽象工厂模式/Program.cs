using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class Program
    {
        /// <summary>
        /// 意图：提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
        /// 适用性：一个系统要独立于它的产品的创建、组合和表示时。
        ///        一个系统要由多个产品系列中的一个来配置时。
        ///        当你要强调一系列相关的产品对象的设计以便进行联合使用时。
        ///        当你提供一个产品类库，而只想显示它们的接口而不是实现时。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 实际应用
            //创建一个非洲的动物世界
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            //创建一个美国的动物世界
            ContinentFactory america = new AmericaFactory();
            AnimalWorld world2 = new AnimalWorld(america);
            world2.RunFoodChain();
            #endregion

            Console.Read();
        }

        #region 实际应用
        /// <summary>
        /// 大陆工厂
        /// </summary>
        abstract class ContinentFactory
        {
            //食草动物
            public abstract Herbivore CreateHerbivore();
            //食肉动物
            public abstract Carnivore CreateCarnivore();
        }

        /// <summary>
        /// 非洲工厂
        /// </summary>
        class AfricaFactory : ContinentFactory
        {
            public override Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Lion();
            }
        }

        /// <summary>
        /// 美国工厂
        /// </summary>
        class AmericaFactory : ContinentFactory
        {
            public override Herbivore CreateHerbivore()
            {
                return new Bison();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Wolf();
            }
        }

        /// <summary>
        /// 食草动物
        /// </summary>
        abstract class Herbivore
        {

        }
        /// <summary>
        /// 食肉动物
        /// </summary>
        abstract class Carnivore
        {
            public abstract void Eat(Herbivore h);
        }

        /// <summary>
        /// 角马
        /// </summary>
        class Wildebeest : Herbivore
        {
        }

        /// <summary>
        /// 狮子
        /// </summary>
        class Lion : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                Console.WriteLine(this.GetType().Name + " 吃 " + h.GetType().Name);
            }
        }

        /// <summary>
        /// 野牛
        /// </summary>
        class Bison : Herbivore
        {
        }

        /// <summary>
        /// 狼
        /// </summary>
        class Wolf : Carnivore
        {
            public override void Eat(Herbivore h)
            {
                Console.WriteLine(this.GetType().Name + " 吃 " + h.GetType().Name);
            }
        }

        /// <summary>
        /// 模式动物世界食物链
        /// </summary>
        class AnimalWorld
        {
            //食草动物
            private Herbivore herbivore;
            //肉食动物
            private Carnivore carnivore;

            public AnimalWorld(ContinentFactory factory)
            {
                carnivore = factory.CreateCarnivore();
                herbivore = factory.CreateHerbivore();
            }

            public void RunFoodChain()
            {
                carnivore.Eat(herbivore);
            }

        }
        #endregion
    }
}
