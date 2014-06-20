using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    class Program
    {
         
        public static void Main(string [] args) 
        {


            //call service
            //isntancier un generic 
            var result = new Result <int> { Success = true, Data = 5 };
            var result2 = new Result<string> { Success = true, Data ="Aly" };

            var helper = new ResultPrinter();

            helper.Print(result);

            helper.Print(result2);



            //call service
            //isntancier un generic 
            //var result = new Result <int> { Success = true, Data = 5, Data2 = 10 };
            //var result2 = new Result<string> { Success = true, Data = "5", Data2 = "10" };

            //Console.WriteLine("==========================");
            //Console.WriteLine(result2.Success);
            //Console.WriteLine(result2.Data);
            //Console.WriteLine(result2.Data2);
            //Console.WriteLine("==========================");
           

            //call service
            //isntancier un generic 
            //var result = new Result<int, string> { Success = true, Data = 5, Data2="Hello" };
            //var result2 = new Result<string, bool> { Success = true, Data = "Aly", Data2=true };

            //Console.WriteLine("==========================");
            //Console.WriteLine(result2.Success);
            //Console.WriteLine(result2.Data);
            //Console.WriteLine(result2.Data2);
            //Console.WriteLine("==========================");
           







            //var result = new Result<int> { Success = true, Data = 5 };
            //var result2 = new Result<string> { Success = true, Data = "Aly" };
            //var result3 = new Result<bool> { Success = true, Data = true };


            //Console.WriteLine(result.Success);
            //Console.WriteLine(result.Data);
            //Console.WriteLine("==========================");
            //Console.WriteLine(result2.Success);
            //Console.WriteLine(result2.Data);
            //Console.WriteLine("==========================");
            //Console.WriteLine(result3.Success);
            //Console.WriteLine(result3.Data);
             
             
        }
       
    }

    //generoc solve the DRY in other wise , other wise
    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }


    public class ResultPrinter
    {
        //public void Print(Result<int> result)
        //trés important
        public void Print<T>(Result<T> result)
        {
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
        }
    }

    //generoc solve the DRY in other wise
    public class Result<T, U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
    }



    ////generoc solve the DRY
    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }



    public class ResultInt
    {
        public bool Success { get; set; }

        public int Data { get; set; }

    }

    public class ResultString
    {
        public bool Success { get; set; }

        public string Data { get; set; }

    }


    public class ResultBool
    {
        public bool Success { get; set; }

        public bool Data { get; set; }

    }
    
}
