using System;
using System.Collections.Generic;
using System.Linq;

// Base class
public abstract class Employee
{
    public abstract decimal GetPay();
}

// Subclasses
public class HourlyEmployee : Employee
{
    public decimal Rate { get; set; }
    public decimal Hours { get; set; }
    public override decimal GetPay() => Rate * Hours;
}

public class SalariedEmployee : Employee
{
    public decimal MonthlySalary { get; set; }
    public override decimal GetPay() => MonthlySalary;
}

public class CommissionEmployee : Employee
{
    public decimal BaseSalary { get; set; }
    public decimal Commission { get; set; }
    public override decimal GetPay() => BaseSalary + Commission;
}

public class PayrollSystem
{
    public decimal CalculateTotalPayroll(string[] employees)
    {
        decimal total = 0;

        foreach (var entry in employees)
        {
            var parts = entry.Split(' ');
            Employee emp = parts[0] switch
            {
                "H" => new HourlyEmployee { Rate = decimal.Parse(parts[1]), Hours = decimal.Parse(parts[2]) },
                "S" => new SalariedEmployee { MonthlySalary = decimal.Parse(parts[1]) },
                "C" => new CommissionEmployee { Commission = decimal.Parse(parts[1]), BaseSalary = decimal.Parse(parts[2]) },
                _ => null
            };

            if (emp != null)
            {
                total += emp.GetPay();
            }
        }

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }
}
