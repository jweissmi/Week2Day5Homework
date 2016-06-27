using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Homework
{
    class Department
    {
        string department;

        public Department()
        {
        }
        public Department(string department)
        {
            EmpDepartment = department;
        }
        public string EmpDepartment
        {
            get
            {
                return department;
            }
            set  //add error handling
            {
                department = value;
            }
        }

    }
}
