using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Information info = new JHInfo();
            info.Code = "000";
            info.Name = "JH";
            info.ShowInfo();

        }
    }

    //定义两个接口（即规范）
    interface Information
    {
        string Code { get; set; } //大写的Code和Name可以理解为标题行的字段名
        string Name { get; set; }
        void ShowInfo();

    }

    interface Information2
    {
        string Code { get; set; }
        string Name { get; set; }
        void ShowInfo();
    }

    public class JHInfo:Information, Information2
    {
        string code = ""; //定义两个变量 code、name
        string name = "";
        
        public string Code 
        {
            get {  return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public void ShowInfo()
        {
            Console.WriteLine("进货信息：" + Code +"  " +  Name);
            Console.ReadLine();
        }
        

    }

}
