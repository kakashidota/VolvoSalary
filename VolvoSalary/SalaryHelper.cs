using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal static class SalaryHelper
    {

        private static int BASE_SALARY = 20000;
        private static int YEARLY_INCREMENT = 400;
        private static int NIGHT_SHIFT_BONUS = 5000;
        private static int TRUCK_DRIVER_BONUS = 3000;
        private static int HOURLY_RATE = 180;


        //Method for calculating basesalary 
        public static int BaseSalary(int yearsEmployed)
        {
            return BASE_SALARY + (YEARLY_INCREMENT * yearsEmployed);
        }


        //Method for calculating if someone is working nightshift
        public static int NightShiftBonus(bool nightShift)
        {
            if(nightShift)
            {
                return NIGHT_SHIFT_BONUS;
            } else
            {
                return 0;
            }
        }

        public static int TruckDriverBonus(bool drivesTruck)
        {
            if(drivesTruck)
            {
                return TRUCK_DRIVER_BONUS;
            } else
            {
                return 0;
            }
        }

        public static int EarningFromHours(int hoursWorked)
        {
            return HOURLY_RATE * hoursWorked;
        }

    }
}
