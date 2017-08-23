using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Learn_JsonSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Age = 10,
                Name = "liusile",
                RegTime = DateTime.Now
            };
            var serializer = new JavaScriptSerializer();
            var strPerson = serializer.Serialize(person);
            strPerson = Regex.Replace(strPerson, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                dt = dt.ToLocalTime();
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            });
            Console.WriteLine("JavaScriptSerializer:" + strPerson);

            var strPerson2 = JsonConvert.SerializeObject(person, Formatting.Indented,
                new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" }
                );
            Console.WriteLine("JsonConvert:" + strPerson);
            Debug.Write(strPerson);

            //{"Name":"liusile","Age":10,"TokenId":"00000000-0000-0000-0000-000000000000","RegTime":"2017-05-10 17:58:12"}
            string str = "{\"Name\":\"liusile\",\"Age\":10,\"TokenId\":\"00000000-0000-0000-0000-000000000000\",\"RegTime\":\"2017 - 05 - 10 17:58:12\"}";
            var dd = JsonConvert.DeserializeObject<Person>(str);

            Console.ReadKey();
        }
    }
}
