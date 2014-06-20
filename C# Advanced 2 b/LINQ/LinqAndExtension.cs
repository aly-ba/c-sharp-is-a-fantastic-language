using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;
using System.Linq;

namespace LINQ
{


        public class Test
        {
            public static void Main(string[] args)
            {
                IEnumerable<string> cities = new[] { "Ghent", "Dakar", "Las Vegas", "Hyderabad", "London" };

                cities.Filter(StringThatStarWithL);


                IEnumerable<string> query =
                    cities.StringsThatStartWith("L");

                foreach (var city in query)
                {
                    Console.WriteLine(city);
                }

                static bool StringThatStarWithL(string s) 
                {
                    return s.StartsWith("L");
                }


            }
        }
}


namespace Extensions
{
    //extension method  with ienumerable 

    public static class FitlerExtensions
    {
        public static IEnumerable<T> StringsThatStartWith
            (this IEnumerable<T> input, FilterDelegate<T> predicate )
        {
            foreach (var item in input)
            {
                //if (s.StartsWith(start))
                if(predicate(item))
                {
                    yield return s;
                }
            }
        }
    }

    public delegate bool FilterDelegate<T>(T item);
}
 