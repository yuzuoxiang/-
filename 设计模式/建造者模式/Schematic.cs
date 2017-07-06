using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 建造者模式
{
    /// <summary>
    /// 生成器模式 - 结构示例
    /// </summary>
    class Schematic
    {
        //static void Main(string[] args)
        //{
        //    Director director = new Director();
        //    Builder b1 = new ConcreteBuilder1();
        //    Builder b2 = new ConcreteBuilder2();

        //    director.Construct(b1);
        //    Product p1 = b1.GetResult();
        //    p1.Show();

        //    director.Construct(b2);
        //    Product p2 = b2.GetResult();
        //    p2.Show();

        //    Console.Read();
        //}
    }

    class Director
    {
        public void Construct(Builder buider)
        {
            buider.BuildPartA();
            buider.BuildPartB();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    /// <summary>
    /// 混凝土建筑1
    /// </summary>
    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("PartA");
        }

        public override void BuildPartB()
        {
            product.Add("PartB");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    /// <summary>
    /// 混凝土建筑2
    /// </summary>
    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("PartX");
        }

        public override void BuildPartB()
        {
            product.Add("PartY");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class Product
    {
        ArrayList parts = new ArrayList();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n产品配件 -------");
            foreach (var part in parts)
                Console.WriteLine(part);
        }
    }
}
