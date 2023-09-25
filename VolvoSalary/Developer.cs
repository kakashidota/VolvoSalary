using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Developer : Employee
    {
        public enum DeveloperRole
        {
            Junior,
            Medior,
            Senior
        }


        //Fields for the develoer
        private List<string> _techStack = new List<string>();
        private DeveloperRole _role;
        private int _completedProject;

        public Developer(string name, string position, string socialSecurity, int yearsEmployed, DeveloperRole role, List<string> technologies)
        {
            Name = name;
            Position = position;
            SocialSecurity = socialSecurity;
            YearsEmployed = yearsEmployed;
            _role = role;
            _techStack = technologies;
            _completedProject = 0;
        }

        //Properties for fields
        public List<string> TechStack
        {
            get { return _techStack; }
            set { _techStack = value; }
        }

        public DeveloperRole Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public int CompletedProject
        {
            get { return _completedProject; }
            set { _completedProject = value; }
        }



        public void FinishProject()
        {
            _completedProject++;
        }


        public override int CalculateSalary()
        {
            int baseSalary = 0;
            int bonusPerProject = 1000;

            switch (_role)
            {
                case DeveloperRole.Junior:
                    baseSalary = 32000;
                    break;
                case DeveloperRole.Medior:
                    baseSalary = 40000;
                    break;
                case DeveloperRole.Senior:
                    baseSalary = 55000;
                    break;
            }

            int total = baseSalary + (_completedProject * bonusPerProject);


            return total;
        }
    }
}
