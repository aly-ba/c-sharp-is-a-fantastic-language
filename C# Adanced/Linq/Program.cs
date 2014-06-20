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

            var result2 = from p in people
                          orderby p.LastName descending
                          // where p.Age <25 && p.LastName =="Doe"
                          //where p.Age < 25
                          // where p.Age >25
                          group  p by p.LastName;

                          //select p;

            foreach (var item in result2)
            {
                Console.WriteLine(item.Key +" -" +item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0} -{1} ", p.FirstName, p.LastName);
                }

            }
                
        





            //var sample = "I enjoy writing uber-software in C#";

            //group something by something other lol  work like dictionnary 
            //// many manipulation function
            //var result = from c in sample.ToLower()
            //             where c == 'a' || c == 'i' || c == 'o' || c == 'u' || c == 'e'
            //             group c by c; //en prender garde
                         //select c;  et surtout pas de select avec IGrouping 

            //var result = from c in sample.ToLower()
            //             where c == 'a' || c == 'i' || c == 'o' || c == 'u' || c == 'e'
            //             orderby c descending
            //             select c;


            //var result = from c in sample.ToLower()
            //             where c=='a' || c =='i' || c =='o' || c =='u'  |- c =='e'
            //             select c;


            //var result = from c in sample.ToLower()
            //             select c;

            //foreach (var item in result)
            //{
            //    //grouping by key
            //    Console.WriteLine("{0} -{1}" ,item.Key , item.Count());
            //}


        }



        public class Person
        {
            public string  FirstName { get; set; }
            public string  LastName { get; set; }
            public int Age { get; set; }

        }
         

    }
     
    
}
