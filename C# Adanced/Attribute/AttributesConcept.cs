using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    class AttributesConcept {


        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;
            foreach( var t in types)
            {
                Console.WriteLine(t.Name);

                foreach(var p in t.GetProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }

    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute : Attribute
    {
        public  string  Name {get; set;}
        public int Version { get; set;  }



    }

    [Sample(Name="Jhon", Version =1)]
    public class Test
    {
        //[Sample]
        public int Intvalue { get; set; }
        // [Sample]
        public void Method(){  }
    }

    public class NoAttribute
    {

    }
}
