using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Person
    {
        string name, actionStr, shoutStr;//定义三个字符串变量

        //使用构造函数对上述三个变量进行初始化
        public Person(string name, string actionStr, string shoutStr)
        {
            this.name = name; //人
            this.actionStr = actionStr;//做的动作
            this.shoutStr = shoutStr;//喊一下
        }

        //创建方法。以下方法中，分别将上述定义的三个变量进行组合，得出不同的方法。
        public void action()//也就是，执行了这个action动作以后，
        {
            Console.WriteLine(name + actionStr);//谁来执行拦截动作（人+动作）
        }

        public void shout()
        {
            Console.WriteLine(name + shoutStr);//谁来喊（人+喊)
        }

        public void escape()
        {
            Console.WriteLine(name + "落荒而逃");
        }


    }


    public class Program
    {

        static void Main(string[] args)
        {
            //在该例子中，每一个对象的三个参数（name，actionStr，shoutStr）都是固定的。
            Person caocao = new Person("曹操", "落荒而逃", "哈哈大笑");   //在Main方法里面创建有参对象，参数与Person中的参数个数一致，意思一致，类型一致
            Person zhaoyun = new Person("赵云:", "拦住去路", "我是赵子龙，你哪里跑！");
            Person zhangfei = new Person("张飞:", "拦住去路", "我是张飞，你哪里跑！");
            Person zhanghe = new Person("张颌:", "上前救主", "我是张颌，莫动我主公！");
            Person zhangliao = new Person("张辽:", "上前救主", "我是张辽，莫动我主公！");
            Person guanyu = new Person("关羽:", "拦住去路", "长叹一声");

            Console.WriteLine("曹操赤壁失利，败走华容道");
            caocao.shout(); //调用方法，则自动会根据上述方法定义中的不同变量进行组合及操作

            Console.WriteLine();

            zhaoyun.action(); //括号不能漏写，否则会提示错误
            zhaoyun.shout();
            zhanghe.action();
            zhanghe.shout();
            caocao.action();

            Console.WriteLine();

            caocao.shout();
            zhangfei.action();
            zhangfei.shout();
            zhangliao.action();
            zhangliao.shout();
            caocao.action();

            Console.WriteLine();

            caocao.shout();
            guanyu.action();
            guanyu.shout();
            caocao.action();

            Console.ReadLine();



        }
    }
}
