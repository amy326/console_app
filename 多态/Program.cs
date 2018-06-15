using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{

    class  Vehicle //定义父类名叫Vehicl 
    {
        public string Name { get; set; }
        public virtual void Move() // 用virtual来表示虚方法
        {
            Console.WriteLine("{0}可以移动", Name);
        }
    }
     
    class Train:Vehicle //定义子类 火车
    {
        public override void Move() // 用override来重写虚方法
        {
            Console.WriteLine("{0}可以在铁轨上行驶", Name); 
        }
    }

    class  Car:Vehicle // 定义子类 汽车
    {
        public override void Move()
        {
           Console.WriteLine("{0}可以在道路上行驶", Name);
        }
    }


    class Program  
    {
        static void Main(string[] args)  // 在Main()中创建对象
        {
            Vehicle v = new Vehicle();//创建父类对象
            Train t = new Train();//创建子类对象
            Car c = new Car(); // 创建子类对象

            Vehicle[] vs = { v, t, c }; // 创建父类的对象数组并赋值，这个集合名叫vs
            v.Name = "交通工具";
            t.Name = "火车";
            c.Name = "汽车";

            vs[0].Move(); //由于上述创建了集合，所以可以直接调用集合中的元素。
            vs[1].Move();
            vs[2].Move();

            Console.Read();
        }
    }
}
