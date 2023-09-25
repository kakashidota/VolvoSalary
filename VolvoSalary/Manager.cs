using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Manager : Employee
    {

        //Fieds
        private List<Employee> _employeesManaged;
        private bool _isNightShift;


        public Manager(string name, string position, string socialSecurity, int yearsEmployed, bool nightshift)
        {
            Name = name;
            Position = position;
            SocialSecurity = socialSecurity;
            YearsEmployed = yearsEmployed;
            _isNightShift = nightshift;
            _employeesManaged = new List<Employee>();
        }


        //Properties for fields
        public List<Employee> EmployeesManaged
        {
            get { return _employeesManaged; }
            set { _employeesManaged = value; }
        }

        public bool IsNightShift
        {
            get { return _isNightShift; }
            set { _isNightShift = value; }
        }



        //Method for adding employee to a manager
        public void AddEmployee(Employee employee)
        {
            _employeesManaged.Add(employee);
        }




        public override int CalculateSalary()
        {
            int empoyeeCountBonus = 1000;

            int baseSalary = SalaryHelper.BaseSalary(YearsEmployed);
            int nightShiftBonus = SalaryHelper.NightShiftBonus(IsNightShift);
            int personalCount = empoyeeCountBonus * _employeesManaged.Count();

            int totalSalary = baseSalary + nightShiftBonus + personalCount;


            return totalSalary;
        }
    }
}
