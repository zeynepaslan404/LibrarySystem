using System;

namespace LibrarySystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = "";
        public string Position { get; set; } = "";
        public DateTime HireDate { get; set; }
    }
}

