using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees {get; set;}

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string compName, DateTime compCreatedOn, List<Employee> compEmployees)
        {
            Name = compName;
            CreatedOn = compCreatedOn;
            Employees = compEmployees;
        }

        public void ListEmployees(Company company)
        {
            foreach (Employee employee in company.Employees)
            Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company.Name} as a {employee.Title} since {employee.StartDate}");
        }
    }
}