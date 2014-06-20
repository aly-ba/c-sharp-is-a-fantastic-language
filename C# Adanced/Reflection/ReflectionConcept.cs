using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    class ReflectionConcept
    {
        static void Main(string [] args)
        {


            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes().Where(t =>t.GetCustomAttributes<MyClassAttribute>().Count() > 0);


            foreach (var type in types)
            {
                Console.WriteLine(type.Name);

                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);

                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
            }


            //var assembly = Assembly.GetExecutingAssembly();

            //Console.WriteLine(assembly.FullName);

            //var types = assembly.GetTypes();

            //foreach (var type in types)
            //{

            //    Console.WriteLine("Type :" + type.Name + "Type: " + type.BaseType) ;

            //    var props = type.GetProperties();

            //    foreach(var prop in props)
            //    {
            //        Console.WriteLine("\t Propetery : "  +prop.Name  +" PropertyType :" +prop.PropertyType);
            //    }

            //    var fields = type.GetMethods();
            //    foreach (var method in fields)
            //    {
            //        Console.WriteLine("\tField: " + method.Name);
            //    }

            //}
           
            //var sample = new Sample  {Name ="Jhon", Age =22 };
            //var sampleType = sample.GetType();

            ////var sampleType = typeof(Sample);
            //var nameProperty = sampleType.GetProperty("Name");
            //Console.WriteLine("Property :" + nameProperty.GetValue(sample));

            //var myMethod = sampleType.GetMethod("myMethod");

            //myMethod.Invoke(sample, null);

         }
    }

    [MyClass]
    public class Sample
    {
        public string Name {get; set;}
        public int Age;

        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine(" Hello from MyMethod!");
        }

        public void methodNotAttribute() { //code here}
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute {}


}
