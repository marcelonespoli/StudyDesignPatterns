using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySolution2
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
           reports
               .Where(r => r.Level == DeveloperLevel.Senior)
               .Select(r => r.CalculateSalary() * 1.2)
               .Sum();
    }
}
