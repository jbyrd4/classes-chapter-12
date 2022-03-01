using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        public Employee(string empFirstName, string empLastName, string empTitle, DateTime empStartDate)
        {
            FirstName = empFirstName;
            LastName = empLastName;
            Title = empTitle;
            StartDate = empStartDate;
        }
    }
}