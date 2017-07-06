using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 建造者模式
{
    /// <summary>
    /// 意图：将一个复杂对象的构建和它的表示分离，使得同样的构建过程可以创建不同的表示
    /// 适用性：当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时
    ///        当构造过程必须允许被构造的对象有不同的表示时 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //与车辆制造商建立商店
            Shop shop = new Shop();
            VehicleBuilder b1 = new ScooterBuilder();
            VehicleBuilder b2 = new CarBuilder();
            VehicleBuilder b3 = new MotorCycleBuilder();

            shop.Construct(b1);
            b1.Vehicle.Show();

            shop.Construct(b2);
            b2.Vehicle.Show();

            shop.Construct(b3);
            b3.Vehicle.Show();

            Console.Read();
        }
    }

    class Shop
    {
        /// <summary>
        /// 构建器使用复杂的一系列步骤
        /// </summary>
        /// <param name="vehicleBuilder"></param>
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }

    /// <summary>
    /// 车辆制造商
    /// </summary>
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
        }
        //创建框架
        public abstract void BuildFrame();
        //创建引擎
        public abstract void BuildEngine();
        //创建车轮
        public abstract void BuildWheels();
        //创建车门
        public abstract void BuildDoors();
    }

    /// <summary>
    /// 摩托车建造者
    /// </summary>
    class MotorCycleBuilder : VehicleBuilder
    {
        public override void BuildFrame()
        {
            vehicle = new Vehicle("MotorCycle");
            vehicle["frame"] = "MotorCycle Frame";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }

    /// <summary>
    /// 汽车制造商
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public override void BuildFrame()
        {
            vehicle = new Vehicle("Car");
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }

    /// <summary>
    /// 滑板车制造商
    /// </summary>
    class ScooterBuilder : VehicleBuilder
    {
        public override void BuildFrame()
        {
            vehicle = new Vehicle("Scooter");
            vehicle["frame"] = "Scooter Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }

    /// <summary>
    /// 车辆
    /// </summary>
    class Vehicle
    {
        private string type;
        private Hashtable parts = new Hashtable();

        public Vehicle(string type)
        {
            this.type = type;
        }

        public object this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", type);
            Console.WriteLine(" Frame : {0}", parts["frame"]);
            Console.WriteLine(" Engine : {0}", parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", parts["doors"]);
        }
    }
}
