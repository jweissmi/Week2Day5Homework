using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to peopleNet");
            bool morePeople = true;
            bool empAdded = false;

            List<Employee> employeeList = new List<Employee>();

            while (morePeople)
            {
                MenuMaker();
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        AddEmployee(ref empAdded, employeeList);
                        break;

                    case 2:
                        Console.WriteLine("Enter Department Name");
                        string empDepartment = (Console.ReadLine());

                        Console.WriteLine(empDepartment);
                        break;

                    case 3:
                        //AssignRating();
                        break;

                    case 4:

                        break;

                    case 5:
                        for (int e = 0; e < employeeList.Count; e++)
                        {
                            foreach (Employee emp in employeeList)
                            {
                                Console.WriteLine(emp.FirstName);
                                Console.WriteLine(emp.LastName);
                                Console.WriteLine(emp.Email);
                                Console.WriteLine(emp.Salary);
                                Console.WriteLine(emp.PerfSatisfactory);
                                Console.WriteLine(emp.PerfReview);
                            }
                        }

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                WorkContinue(ref morePeople);

                Console.WriteLine();
            }
        }
        public static void AddEmployee(ref bool empAdded, List<Employee> EmployeeList)
        {
            Employee newEmp = new Employee();
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            newEmp.FirstName = firstName;

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            newEmp.LastName = lastName;

            Console.WriteLine("Enter email address: ");
            string email = Console.ReadLine();
            newEmp.Email = email;

            Console.WriteLine("Enter starting salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            newEmp.Salary = salary;

            Console.WriteLine("Is this employees work satisfactory? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                perfSatisfactory = true;
            }
            else
            {
                perfSatisfactory = false;
            }

            EmployeeList.Add(newEmp);
            empAdded = true;
        }

        public static int menuChoice;
        //private static bool perfSatisfactory;

        public static void MenuMaker()
        {
            Console.WriteLine("Select from the following choices: \n1. to Create Employee\n2. to Create Department\n3. to Assign Employee Rating\n4. to Write Employee Review\n5. for List of Employees\n6. for List of Department\n7. Give Raise\n8. Exit");
        }

        public static bool WorkContinue(ref bool morePeople)
        {
            Console.WriteLine("Do you want to keep working? (y/n)");
            string answer = Console.ReadLine();
            if (answer != "y")
                return morePeople = false;
            else
            {
                return morePeople = true;
            }
        }
    }
}