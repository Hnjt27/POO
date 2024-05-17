using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Interfaces
{
    internal interface ISalaryCalculator
    {
        decimal CalculateSalary(int hoursWorked, decimal hourlyRate);
    }
}
