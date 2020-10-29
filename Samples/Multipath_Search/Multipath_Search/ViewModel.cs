using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipath_Search
{
    public class ViewModel
    {
        private ObservableCollection<Model> employeeCollection;
        public ObservableCollection<Model> EmployeeCollection
        {
            get { return employeeCollection; }
            set { employeeCollection = value; }
        }
        public ViewModel()
        {
            employeeCollection = new ObservableCollection<Model>();
            employeeCollection.Add(new Model() { ID = 1, Name = "Eric" });
            employeeCollection.Add(new Model() { ID = 2, Name = "James" });
            employeeCollection.Add(new Model() { ID = 3, Name = "Jacob" });
            employeeCollection.Add(new Model() { ID = 4, Name = "Lucas" });
            employeeCollection.Add(new Model() { ID = 5, Name = "Mark" });
            employeeCollection.Add(new Model() { ID = 6, Name = "Aldan" });
            employeeCollection.Add(new Model() { ID = 7, Name = "Aldrin" });
            employeeCollection.Add(new Model() { ID = 8, Name = "Alan" });
            employeeCollection.Add(new Model() { ID = 9, Name = "Aaron" });
        }
    }
}
