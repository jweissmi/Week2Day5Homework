using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Homework
{
    class Department
    {
        private string empDepartment;

        private Department()
        {
        }
        public Department(string empDepartment)
        {
            EmpDepartment = empDepartment;
        }
        public string EmpDepartment
        {
            get
            {
                return empDepartment;
            }
            set  //add error handling
            {
                empDepartment = value;
            }
        }

    }
}
