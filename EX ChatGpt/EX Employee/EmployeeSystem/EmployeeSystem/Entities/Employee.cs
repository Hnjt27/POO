using EmployeeSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Entities
{
    internal class Employee : IEmployee
    {
        public string Name { get; private set; }

        public string Position { get; private set; }

        public Employee(string name, string position)
        {
            Name = name;           
            Position = position;
        }

        public void Calculator
    }
}
