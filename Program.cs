using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company fancyCompany = new Company("Fancy Company", DateTime.Now);

            // Create three employees
            Employee bobBaker = new Employee("Robert", "Baker", "Manager", DateTime.Now);
            Employee chad = new Employee("Chaddwick", "Marshall", "Desk Clerk", DateTime.Now);
            Employee tanner = new Employee("Tanner", "The Tan Man", "Not The Man", DateTime.Now);

            // Assign the employees to the company
            fancyCompany.Employees.Add(bobBaker);
            fancyCompany.Employees.Add(chad);
            fancyCompany.Employees.Add(tanner);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            fancyCompany.ListEmployees();
        }
    }
}