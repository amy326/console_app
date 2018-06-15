using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Goods
    {
        protected string code { get; set; } //属性
        public string Name { get; set; }
    }

    class Jinhuo : Goods //继承自Goods这个父类
    {
        public string JHID { get; set; }
        public void ShowInfo()//在子类中创建方法，继承并调用父类中的属性。
        {
            Name = "phone"; //给对象属性赋值
            code = "0000";
            JHID = "jh0000";
            Console.WriteLine("进货编号：{0}, 商品编号：{1}， 商品名称：{2}", JHID, code, Name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Jinhuo info = new Jinhuo();//创建子类的对象
            info.ShowInfo(); //子类对象调用方法

            Console.ReadLine();
        }
    } 
}
