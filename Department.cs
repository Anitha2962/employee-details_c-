using employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departments
{
    internal class Department
    {
        public void process(Employee emp)
        {
         if (emp != null)
            {
               if (emp.experience >1 && emp.isconformed)
                {
                    Console.WriteLine("hi" + emp.emp_name);
                }


            }
        }
    }
}
