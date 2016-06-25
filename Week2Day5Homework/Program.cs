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
            //Introduction

            bool morePeople = true;
            while (morePeople)
            {
                Console.WriteLine("Welcome to peopleNet");

                MenuMaker();
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string firstName = (Console.ReadLine());
                        Console.WriteLine("Enter Last Name");
                        string lastName = (Console.ReadLine());
                        Console.WriteLine("Enter Last Email");
                        string email = (Console.ReadLine());
                        Console.WriteLine("Enter Salary");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(firstName + " " + lastName);
                        Console.WriteLine(email);
                        Console.WriteLine("Salary: " + salary);
                        break;

                }

                //Employee employee = new Employee();

                //if (!employee.PerfSatisfactory)
                //{
                //    Console.WriteLine("Is Satisfactory");
                //}
                //Create an Employee

                //Create a Department

                //Assign Employee Rating



                //Write Employee Review

                //List of Employees

                //List of Departments

                //Give Raise


                Console.WriteLine();


                Console.ReadLine();
            }
        }


        public static bool morePeople;
        public static int menuChoice;
        public static void MenuMaker()
        {
            Console.WriteLine("Select from the following choices: \n1. to Create Employee\n2. to Create Department\n3. to Assign Employee Rating\n4. to Write Employee Review\n5. for List of Employees\n6. for List of Department\n7. Give Raise");
        }
        public static void CalcContinue()
        {
            Console.WriteLine("Do you want to keep working? (y/n)");
            string answer = Console.ReadLine();
            if (answer != "y")
                morePeople = false;
        }
    }
}
