using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySolution2
{
    public class JuniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Junior)
                .Select(r => r.CalculateSalary())
                .Sum();
    }
}
