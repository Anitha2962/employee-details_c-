using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using departments;
using System.Threading.Tasks;

namespace employees
{
    internal class Employee
    {
       public string emp_name;
        string emp_place;
     public int experience;
        public bool isconformed=true;
        public void process()
        {
            Employee emp = new Employee();
            emp.emp_name = "anu";
            emp.emp_place = "kerala";
            emp.experience = 2;
           // emp = null;
            Department department = new Department();
            department.process(emp);
        }

   
    }
}
