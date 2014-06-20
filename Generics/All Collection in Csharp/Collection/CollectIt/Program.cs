using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {


            var employeeByName = new SortedList
            <string, List<Employee>>();

            //var employeeByName = new SortedDictionary
            //<string, List<Employee>>();
            //var employeeByName = new Dictionary
            //<string, List<Employee>>();

            employeeByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            employeeByName.Add("Engineering", new List<Employee> {
                new Employee(), new Employee(), new Employee() });

            foreach(var item in employeeByName)
            {
                Console.WriteLine("The count of employees for {0} is  {1}",
                    item.Key, item.Value.Count
                    );
            }


            //DICO
            //    var employeeByDepartement = new Dictionary <string, List<Employee>>();

            //    employeeByDepartement.Add("Engineering",
            //        new List<Employee>() { new Employee { Name = "Scott" } });
            //    employeeByDepartement["Engineering"].Add(new Employee { Name = "Scott" });

            //    foreach (var item in employeeByDepartement)
            //    {
            //        foreach (var employee in item.Value )
            //        {
            //            Console.WriteLine(employee.Name);
            //        }
            //    }

            //    var employeesByName = new Dictionary<string, Employee>();

            //    employeesByName.Add("Scott", new Employee { Name = "Scott" });
            //    employeesByName.Add("Alex", new Employee { Name = "Scott " });
            //    employeesByName.Add("Joy", new Employee { Name = "Joy" });
            //    employeesByName.Add("Scott", new Employee { Name = "Scott" });

            //    var scott = employeesByName["Scott"];

            //    foreach (var item in employeeByName)
            //    {
            //        Console.WriteLine(item.Key);
            //        Console.WriteLine("Voici le contenu de votre Dictionnaire : {0}:{1}", item.Key, item.Value.Name);
            //    }


            //   //LINKEDLIST

            //    LinkedList<int> list = new LinkedList<int>();
            //    list.AddFirst(2);
            //    list.AddFirst(3);

            //    var first = list.First;

            //    list.AddAfter(first, 5);
            //    list.AddBefore(first, 10);

            //    var node = list.First;
            //    while (node != null)
            //    {
            //        Console.WriteLine(node.Value);
            //        node = node.Next;
            //    }

            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }


            //    //HashSet
            //    HashSet<Employee> set = new HashSet<Employee>();

            //    var employee = new Employee { Name = "Aly" };
            //    set.Add(employee);
            //    set.Add(employee);
            //    set.Add(employee);
            //    set.Add(new Employee { Name = "Aly" });
            //    set.Add(new Employee { Name = "Eyebe" });
            //    set.Add(new Employee { Name = "Eyebe" });


            //    foreach (var item in set)
            //    {

            //        Console.WriteLine(item.Name);
            //    }



            //    ////FIFO
            //    Queue<Employee> queue = new Queue<Employee>();
            //    queue.Enqueue(new Employee { Name = "Alex" });
            //    queue.Enqueue(new Employee { Name = "Dani" });
            //    queue.Enqueue(new Employee { Name = "Aly" });

            //    while (queue.Count > 0)
            //    {
            //        var employee = queue.Dequeue();
            //        Console.WriteLine(employee.Name);
            //    }


            //    Console.WriteLine("---------");


            //    ////LIFO
            //    Stack<Employee> stack = new Stack<Employee>();
            //    stack.Push(new Employee { Name = "Alex" });
            //    stack.Push(new Employee { Name = "Dani" });
            //    stack.Push(new Employee { Name = "Aly" });


            //    while (stack.Count > 0)
            //    {
            //        var employee = stack.Pop();
            //        Console.WriteLine(employee.Name);
            //    }


            //    var numbers = new List<int>(10);

            //    var capacity = -1;

            //    while (true)
            //    {
            //        if (numbers.Capacity != capacity)
            //        {
            //            capacity = numbers.Capacity;
            //            Console.WriteLine(capacity);
            //        }
            //        numbers.Add(1);
            //    }


            //    //LIST
            //    List<Employee> employees = new List<Employee> {
            //        new Employee {Name ="Aly"},
            //        new Employee {Name ="Alex"}
            //    };

            //    employees.Add(new Employee { Name = "Dani" });

            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine(employee.Name);
            //    }

            //    for (int i = 0; i < employees.Count; i++)
            //    {
            //        Console.WriteLine(employees[i].Name);
            //    }

            //}
        }
    }
}
