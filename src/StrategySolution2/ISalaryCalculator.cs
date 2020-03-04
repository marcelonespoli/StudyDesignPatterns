using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySolution2
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
