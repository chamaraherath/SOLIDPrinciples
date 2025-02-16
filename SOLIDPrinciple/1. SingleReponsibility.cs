using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.SingleReponsibility
{
    public class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void ToString() => Console.WriteLine($"Employee name : {Name}. Salary : {Salary}");
        
    }

    public class SalaryCalculator
    {
        Employee _employee;
        public SalaryCalculator(Employee employee)
        {
            _employee = employee;
        }
        public void Calc() => Console.WriteLine($"Calculating salary for {_employee.Name}");
    }

    public class PaySlipPrinter(Employee employee)
    {
        Employee _employee = employee;
        public void PrintPaySlip() => Console.WriteLine($"Printing payslip for employee : {_employee.Name}");
    }
}

/*
Employee class only holds employee data (one responsibility).
SalaryCalculator class only calculates salary.
PaySlipPrinter class only prints pay slips.
If we change how salary is calculated or how pay slips are printed, we don’t need to modify the Employee class.
This makes the code cleaner, modular, and easier to maintain!
*/