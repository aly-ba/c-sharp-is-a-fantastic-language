using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.INTRO
{
    class Program
    {

        static void Main(string[] args) 
        {
            Console.WriteLine("Pleaser enter your name");

            string name = Console.ReadLine();

               Console.WriteLine("Hello World!" +name);

            Console.WriteLine("How muuch  sleep did you lhave last night ");

            int hoursOfSleep = int.Parse(Console.ReadLine());

            if( hoursOfSleep < 8) 
            {
                Console.Write("Yoy mus feel tired");
            }

            else {

                Console.WriteLine(" You seem well rested");
            }
        }
    }
}
