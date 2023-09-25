using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Operator : Employee
    {
        //Fields for Operator
        private int _hoursWorked;
        private bool _nightShift;
        private bool _drivesTruck;

        public Operator(string name, string position, string socialSecurity, int yearsEmployed, int hoursWorked, bool nightshift, bool drivesTruck)
        {
            Name = name;
            Position = position;
            SocialSecurity = socialSecurity;
            YearsEmployed = yearsEmployed;
            _hoursWorked = hoursWorked;
            _nightShift = nightshift;
            _drivesTruck = drivesTruck;
        }

        //Properties for the fields above
        public int HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public bool NightShift
        {
            get { return _nightShift; }
            set { _nightShift = value; }
        }

        public bool DrivesTruck
        {
            get { return _drivesTruck; }
            set { _drivesTruck = value;}
        }


        public override int CalculateSalary()
        {
            int baseSalary = SalaryHelper.BaseSalary(YearsEmployed); //20 000
            int nightShiftBonus = SalaryHelper.NightShiftBonus(NightShift); //5 000
            int truckerDriverBonus = SalaryHelper.TruckDriverBonus(DrivesTruck); //3 000
            int earningFromHours = SalaryHelper.EarningFromHours(HoursWorked); //180*x

            int totalSalary = baseSalary + nightShiftBonus + truckerDriverBonus + earningFromHours;

            return totalSalary;
        }
    }
}
