using HomeworkTwentyEight.Library.Models;
using System;

namespace HomeworkTwentyEight.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new EmployeeModel();
            employee1.PrintData();

            var employee2 = new EmployeeModel("Michael Sanchez");
            employee2.PrintData();

            var employee3 = new EmployeeModel("Samuel Jackson", "Technical Support");
            employee3.PrintData();

            var employee4 = new EmployeeModel("Jonathan Santos", "Technical Support", 54321);
            employee4.PrintData();

            Console.ReadLine();
        }
    }
}
