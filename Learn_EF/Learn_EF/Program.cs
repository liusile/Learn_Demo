using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyContext();
            //添加数据
            //db.Province.Add(new Province
            //{
            //    Cities = new List<City>
            //    {
            //        new City {Name="广州" },
            //        new City {Name="佛山" }
            //    },
            //    Governor = new Governor
            //    {
            //        Name = "广东"
            //    },
            //    Name = "中国"
            //});
            //db.SaveChanges();
            //var list = db.Province;
            //              foreach (var province in list)
            //                  {
            //    var dfd = province.Governor.Name;
            //         Print(province);
            //                  }
            //EagerLoading(db);
            ExplicitLoading(db);
            Console.ReadKey();
        }
        private static void EagerLoading(MyContext db)
        {
            //发送一条查询到数据库库，查询所有的province并关联city和governor
            var list = db.Province.Include(t => t.Cities).Include(t => t.Governor);
            foreach (var province in list)
            {
                //不管ctx.Configuration.LazyLoadingEnabled为false，还是没有标注导航属性virtual，都不会抛出异常
                Print(province);
            }
        }
        private static void ExplicitLoading(MyContext ctx)
             {
                 //发送一条查询到数据库，查询所有的province
                var list = ctx.Province.ToList();
                foreach (var province in list)
                 {
                     var p = ctx.Entry(province);
                     //发送一条查询，查询所有当前province的city
                     p.Collection(t => t.Cities).Load();
                    //发送一条查询，查询当前province的governor
                    p.Reference(t => t.Governor).Load();
                   //不管ctx.Configuration.LazyLoadingEnabled为false，还是没有标注导航属性virtual，都不会抛出异常
                   Print(province);
                }
            }
private static void Print(Province province)
            {
                Console.WriteLine("省：【{0}】,市：【{1}】，省长：【{2}】", province.Name, string.Join(",", province.Cities.Select(t => t.Name)), province.Governor.Name);
            }
}
}
