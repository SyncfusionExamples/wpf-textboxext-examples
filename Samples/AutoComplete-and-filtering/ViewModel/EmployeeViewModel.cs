using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoComplete_and_filtering
{

    public class EmployeeViewModel
    {
        private List<Employee> employees;
        public List<Employee> Employees
        {
            get { return employees; }

            set { employees = value; }
        }

        public EmployeeViewModel()
        {
            Employees = new List<Employee>();
            Employees.Add(new Employee() { Name = "Eric", Email = "Eric@syncfusion.com" });
            Employees.Add(new Employee() { Name = "James", Email = "James@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Jacob", Email = "Jacob@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Jackson", Email = "Jackson@syncfusion.com" });            
            Employees.Add(new Employee() { Name = "Lucas", Email = "Lucas@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Mark", Email = "Mark@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Aldan", Email = "Aldan@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Aldrin", Email = "Aldrin@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Alan", Email = "Alan@syncfusion.com" });
            Employees.Add(new Employee() { Name = "Aaron", Email = "Aaron@syncfusion.com" });
        }
    }
}
