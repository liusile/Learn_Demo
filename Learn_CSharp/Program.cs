using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.屏蔽基类的成员(使用new 关键字)设计时这种方式不推荐，最好用virtual override来覆盖基类成员
            Console.WriteLine("屏蔽基类的成员--------------");
            var stu = new Student();
            Console.WriteLine("student Name:" + stu.Name);//访问的是Stuent下的Name
            Console.WriteLine("student GetName:" + stu.GetName());//访问的是Stuent下的GetName
            Console.WriteLine("People GetName:" + stu.BaseGetName());//访问的是Stuent下的BaseGetName,BaseGetName在访问基类的GetName
            //2.使用基类引用访问基类
            Console.WriteLine("屏使用基类引用访问基类--------------");
            var stu1 = new Student();
            var people = (People)stu1;
            Console.WriteLine("People Name:" + people.Name);//派生类转化为基类后，访问的是基类的成员
            //3.使用virtual override 访问
            Console.WriteLine("使用virtual override 访问--------------");
            var stu2 = new Student();
            Console.WriteLine("student Name:" + stu2.VirtualGetName());
            var people2 = (People)stu2;
            Console.WriteLine("student Name:" + people2.VirtualGetName());//注意：虽然转化为基类了，但调用的是子类的方法（override作用效果）
            //4.linq 匿名方法与lambda
            var arr = new List<People>
            {
                new People {Name = "a"},
                new People {Name = "a"},
                new People {Name = "a"}
            };
            string name = arr.Where(p => p.Name == "a").FirstOrDefault().Name;
            string name2 = arr.Where(
                delegate (People p)
                {
                    return p.Name == "a";
                }).FirstOrDefault().Name;
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.ReadKey();
        }
    }
}
