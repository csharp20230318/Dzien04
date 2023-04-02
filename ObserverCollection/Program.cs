using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeList emp = new EmployeeList();
            emp.CollectionChanged += Emp_CollectionChanged;
            emp.Add(new Employee() { Name = "Donald Tusk" });
            emp.Insert(0, new Employee() { Name = "Adam Nowak" });
            emp.RemoveAt(1);
            foreach (var item in emp)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Emp_CollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"Operacja: {e.Action}");
        }
    }
}
