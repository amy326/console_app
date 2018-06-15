using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1_视频教学  //自动创建一个与项目同名的命名空间
{
    class UI
    {
        static UI()
        {
            DateTime date = DateTime.Now;
            if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
        }


    }
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;  }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if(value <100 && value >0)
                {
                    age = value;
                }
                else
                {
                    age = 18;
                }
            }
        }

        private int gender;
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public Student() { }
        public static Student Create()
        {
            return new Student();
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public int Info()
        {
            Console.WriteLine("student's name:" + Name+ "student's age:" + Age);
            return 0;
        }
        
    }
    public enum Gender{Male,Female}
    
    class Program
    {
        //方法重载
        static int Sum(int a, int b)
        {
            return  a + b;
        }

        static double Sum (double a, double b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

       int Add(params int[] x) //Add是一个方法的名字，而不是一个数组的名字，所以括号内的x，才是数组的名字，真实写法应该是：一维数组int x[]，所以后续遍历数组时，写法应该是int x[i]
        {
            int result=0;
            for (int i = 0; i<x.Length; i++)
            {
                result += x[i];//这里不是result += i
            }
            return result;         
        }
        //如果要调用这个方法，则需在实际应用时创建一个对象，比如下面的pro：Program pro = new Program();并通过pro.add来调用方法： pro.add(20, 30);


        static void Main()
        {
            //UI ui = new UI();
            //Student st1 = new Student();
            //st1.Info();

            //int num1=68, num2 = 98;
            //Console.WriteLine("before change:{0},{1}", num1,num2);
            //Swap( ref num1, ref num2);
            //Console.WriteLine("after exchange: {0}, {1}", num1, num2);
            //Console.ReadLine();

            Program pro = new Program();
            
            int result = Sum(2, 3);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        //static void Swap(ref int num1, ref int num2) 
        //{
        //    int temp;
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //}
    }
}



