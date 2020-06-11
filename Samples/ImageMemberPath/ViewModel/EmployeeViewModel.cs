using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMemberPath
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
            Employees.Add(new Employee { Name = "Lucas", Email = "lucas@syncfusion.com", Image = "a0.png" });
            Employees.Add(new Employee { Name = "James", Email = "james@syncfusion.com", Image = "a1.png" });
            Employees.Add(new Employee { Name = "Jacob", Email = "jacob@syncfusion.com", Image = "a2.png" });
        }
    }
}
