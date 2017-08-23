using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单集合
            int[] arr1 = { 1, 1, 3, 4, 5 };
            int[] arr2 = { 5, 6, 7, 8, 9 };

            //复杂集合
            List<Student> List1 = new List<Student>
            {
                new Student {ID=1,Name="LiSi",Remark="LiSi la" },
                new Student {ID=1,Name="ZhangShan",Remark="ZhangShan la" },
                new Student {ID=1,Name="LaoWang",Remark="LaoWang la" },
            };
            List<Student> List2 = new List<Student>
            {
                new Student {ID=1,Name="LiSi2",Remark="LiSi la" },
                new Student {ID=1,Name="ZhangShan",Remark="ZhangShan ladd" },
                new Student {ID=1,Name="LaoWang2",Remark="LaoWang la" },
            };

            //var arr3 = arr1.Concat<int>(arr2);//1, 1, 3, 4, 5, 5, 6, 7, 8, 9--合集
            //var arr3 = arr1.Except<int>(arr2);//1, 3, 4--差集
            //var arr3 = arr1.Distinct();//1,3,4,5--排除相同
            //var arr3 = arr1.Intersect<int>(arr2);//5--交集
            //var arr3 = arr1.Union<int>(arr2);//1,3,4,5,6,7,8,9--并集
            //var arr3 = arr1.Skip(2).Take(1);//3
            // var arr3 = arr1.SkipWhile<int>(o=>o<=3);//4,5
            // var arr3 = arr1.TakeWhile<int>(o => o <= 3);//1,1,3
            // Console.WriteLine(string.Join("\n", arr3.Select(o => o)));

            var List3 = List1.Except<Student>(List2,new SampleCompare());
            Console.WriteLine(string.Join("\n", List3.Select(o=>o.ID+","+o.Name+","+o.Remark)));
            Console.ReadKey();
        } 
    }
    class SampleCompare : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.ID == y.ID && x.Name == y.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetHashCode(Student obj)
        {
            if(obj == null)  
                       return 0;  
                else  
                       return obj.ToString().GetHashCode();
        }
    }
}
