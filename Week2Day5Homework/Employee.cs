using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Homework
{
    class Employee
    {
        string firstName;
        string lastName;
        string email;
        int phoneNum;
        double salary;
        bool perfSatisfactory;
        string perfReview;

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string email, int phoneNum, double salary, bool perfSatisfactory, string perfReview)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNum = phoneNum;
            this.Salary = salary;
            this.PerfReview = perfReview;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 30 characters.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 30 characters.");
                }
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of email address is 30 characters.");
                }
                email = value;
            }
        }

        public int PhoneNum
        {
            get
            {
                return phoneNum;
                //add error handling
            }
            set
            {
                phoneNum = value;
            }
        }
        public Double Salary
        {
            get
            {
                return salary;
                //add error handling
            }
            set
            {
                salary = value;
            }
        }
        public bool PerfSatisfactory
        {
            get
            {
                return perfSatisfactory;
            }
            private set
            {
                perfSatisfactory = value;
            }
        }
        public string PerfReview
        {
            get
            {
                return perfReview;
            }
            set
            {
                if (value.Length > 400)
                {
                    throw new ArgumentException(
                        "Maximum length of performance review is 400 characters.");
                }
                perfReview = value;
            }
        }

        public string GetDisplayText() => firstName + " " + lastName + ", " + email + ", " + salary;
    }
}
