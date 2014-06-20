using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
   

    class Program
    {
        static void Main(string [] args )
        {
            var p= new Person { Name = "John", Age = 33 };
            var p2 = new Person { Name = "Aly", Age = 5  };
            p.SayHello(p2);
            //p.SayHello();
        }
         

    }
     
    public static class Extensions
    {
        public static void SayHello(this Person person, Person person2)
        {
            Console.WriteLine("{0} says Hello", person.Name ,person2.Name);
        }

        //public static void SayHello(this Person person)
        //{
        //    Console.WriteLine("{0} says Hello", person.Name, person2.Name);
        //}
    }
   
}
