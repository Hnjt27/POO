using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Interfaces
{
    internal interface IEmployee
    {
        string Name { get; }
        string Position { get; }

        decimal Calculator(ISalaryCalculator calculator);
    }
}
