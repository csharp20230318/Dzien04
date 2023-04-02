using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCollection
{

    class Employee
    {
        public string Name { get; set; }
        public bool? IsManager { get; set; }
        public double? Salary { get; set; }             
    }

    internal class EmployeeList : ObservableCollection<Employee>
    {
        public EmployeeList() {
            Add(new Employee() { Name = "Jan Kowalski", IsManager = false, Salary = 12345.67 });
            Add(new Employee() { Name = "Janina Kowalska", IsManager = true, Salary = 21345.67 });
            Add(new Employee() { Name = "Marek Nowak" });
            Add(new Employee() { Name = "Marian Nowak" });

        }
    }
}
