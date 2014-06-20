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

            var people = new List<Person>
            {
            new Person{FirstName = "John", LastName ="Doe", Age=25},
            new Person{FirstName = "John", LastName ="Cool", Age=25},
            new Person{FirstName = "Malcom", LastName ="LAfricain", Age=25},
            new Person{FirstName = "Aly", LastName ="Cool", Age=25},
            new Person{FirstName = "Samanta", LastName ="Papi", Age=25},
            new Person{FirstName = "John", LastName ="Doe", Age=24},
            };

            //var result = from p in people
            //             where p.LastName == "Doe"
            //             select p;

            //with a anymous type
            var result = from p in people
                         where p.LastName =="Doe"
                         select new  {FName =p.FirstName, LName= p.LastName};

            foreach (var p in result)
            {
                Console.WriteLine(p.FName + " " + p.LName);
               // Object obj = (Object) p;
               
            }
                
                           

        }



        public class Person
        {
            public string  FirstName { get; set; }
            public string  LastName { get; set; }
            public int Age { get; set; }
            public int MyProperty1 { get; set; }
            public int MyProperty2 { get; set; }
            public int MyProperty3 { get; set; }

        }
         

    }
     
    
}
