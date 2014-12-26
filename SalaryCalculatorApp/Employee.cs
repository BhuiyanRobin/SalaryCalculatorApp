using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        public string name;
        public double amount;
        public double rent;
        public double allowance;


        public double GetFullSalary()
        {
            return amount + (amount*rent/100) + (amount*allowance/100);
        }
    }
}
