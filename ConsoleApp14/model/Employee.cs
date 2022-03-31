using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.model
{
    class Employee : Person


    {

        public double _SalaryOfHour;

        public int WorkingHour;

        public void CalculateSalary(int MonthSalary, int dailyworkhour)
        { }
        public double SalaryOfHour
        {
            get { return _SalaryOfHour; }
            set
            {
                if (_SalaryOfHour > 0)
                {

                }
            }
        
        
        }
        public int Age {
            get 
            { return Age; }
            set
            {
                if (value>18)
                {
                    Age = value;
                }
                else
                {
                    Console.WriteLine("isleme huququ yoxdur");
                }
            }
        }

        public Employee(string name, string surname, int age, int workinghour, double salaryOfhour):base(name,surname,age)
        {
            
            WorkingHour = workinghour;
            SalaryOfHour = salaryOfhour;
        }
        
    } 
}
