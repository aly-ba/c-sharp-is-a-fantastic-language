using System;
using System.Collections.Generic;

namespace CollectIt
{
    //IEqualityComparer utile pour HashSet
    //ICompare utile pour SortedSet
    public class EmployeeComparer : IEqualityComparer<Employee>, 
                                    IComparer<Employee>
    {

        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.Name, y.Name) ;
        }

        public int GetHashCode(Employee obj)
        {
            return  obj.Name.GetHashCode();
        }

        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }

    /// <summary>
    /// factoriser l'instanciation avec un pattern d'instanciation
    /// </summary>
    public class DepartmentCollection : 
           SortedDictionary<string, SortedSet<Employee>>
    {
        //facotoriser l'ajout d'élément avec une méthode factory method pattern
        public DepartmentCollection Add(string deparmentName, Employee employee)
        {
            if (!ContainsKey(deparmentName))
            {
                Add(deparmentName, new SortedSet<Employee>(new EmployeeComparer())); 
            }
            this[deparmentName].Add(employee);

            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var departements = new DepartmentCollection();
            //var departements = new SortedDictionary<string, SortedSet<Employee>>();
             //var departements = new SortedDictionary<string, HashSet<Employee>>();
            //var departements = new SortedDictionary<string, List<Employee>>();
            //var departements = new Dictionary<string, List<Employee>>();


            //departements.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));
            //departements["Sales"].Add(new Employee { Name = "Aly" });
            departements.Add("Sales",new Employee { Name = "Aly" })
                         .Add("Sales",new Employee { Name = "Aly" })
                         .Add("Sales",new Employee { Name = "Dani" });




            //departements.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));
            departements.Add("Engineering", new Employee { Name = "Aly" })
                         .Add("Engineering", new Employee { Name = "Aly" })
                         .Add("Engineering", new Employee { Name = "Dani" });



            



             foreach (var departement in departements)
             {
                 Console.WriteLine(departement.Key);
                 foreach(var employee in departement.Value)
                 {
                     Console.WriteLine("\t" + employee.Name);
                 }
             }
        }
    }
}
