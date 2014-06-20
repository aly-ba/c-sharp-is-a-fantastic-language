using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    delegate  void Operation(int number);
    delegate void Mydelegate1();
    delegate void MyDelegate(string name);
    //class MyDeletegate{} behind the scene
    class Program
    {
        static void Main(string [] args)
        {

            // autre maniére d'appeler la fonction operation via un delegate
            Operation op = Double;
            //op = op + Triple;
            //op += Triple;
            //op -= Triple;
            ExecuteOperation(2, op);

            op = Triple;

            ExecuteOperation(2, op);

           // Double(2);
            
            //MyDelegate del = GiveMeMyDelegate();
            //Test(del);


             //other manner to invoke delegate
            // MyDelegate del = SayHello;
            // del();
            //Mydelegate del = new Mydelegate(SayHello);
           //  del.Invoke();
           // SayHello();
           //  Test(del);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hey there !");
        }

        static void Test(MyDelegate del)
        {
            del("Aly or Eyebe Dedicate To My Papi donc Yespapi");
        }

        static MyDelegate GiveMeMyDelegate()
        {
            return new MyDelegate(SayHello);
        }

        static void Double(int num)
        {
            Console.WriteLine("{0} x 2 = {1} ", num, num * 2);
        }

        static void Triple(int num)
        {
            Console.WriteLine("{0} x 3 = {1} ", num, num * 3);
        }

        //autre maniére d'exécuter une fonction via un delegate
        static void ExecuteOperation(int num, Operation operation)
        {
            operation(num);
        }
    }
}
