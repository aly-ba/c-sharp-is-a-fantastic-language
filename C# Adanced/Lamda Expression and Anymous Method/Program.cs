using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    delegate void Operation(int num);
    //delegate int  Operation(int num);

    class Program
    {
        static void Main(string [] args )
        {

            //action delegate for lamba dexpression don't return type
            Action<int> op = num => { Console.WriteLine("{0}x2 = {1}", num, num * 2); };
            op(2);

            Func<int, int> Double = x => { return x * 2; };


            Console.WriteLine(Double(2));

            //Operation op = num => { Console.WriteLine("{0}x2 = {1}", num, num * 2); };
            //op(2);


            // dans une méthode anonyme DELEGATE AND ANYMOUS METHODE

            //Operation op = delegate(int num) {
            //    Console.WriteLine("{0} *2 {1} ", num, num * 2);
            //    Console.WriteLine("{0} *3 {1} ", num, num * 3);
            //    Console.WriteLine("{0} *4 {1} ", num, num * 4);
            //    Console.WriteLine("{0} *5 {1} ", num, num * 5);
            //};

            ////Operation op = Double;
            //op(2);

            //Operation op = delegate(int num)
            //{
            //    return  num * 2;
            //};

            //int value  = op(2);

            //Console.WriteLine(value);


            //in other wise
            

        }

        static void Double(int num)
        {
            Console.WriteLine("{0} *2 {1} ", num, num * 2);
        }
    }
}
