namespace VolvoSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operator Oliver = new Operator("Oliver Brage", "Operator", "940815-9111", 10, 0, true, true);

            Operator Benjamin = new Operator("Benjamin Kjellgren", "Operator", "920805-1121", 0, 0, false, true);

            Operator Alexander = new Operator("Alexander Brasjö", "Operator", "910528-4321", 5, 20, false, true);



            Manager Vincent = new Manager("Vincent Kaveh", "Manager", "900608-1020", 3, true);
            Vincent.AddEmployee(Oliver);


            Manager Ali = new Manager("Ali Kathem", "Manager", "900407-7777", 7, false);
            Ali.AddEmployee(Benjamin);


            List<string> technologies = new List<string> { "c#", "react", ".net", "sql", "python for russians" };
            Developer Angela = new Developer("Angela Emanuelsson", "Developer", "770813-1337", 2, Developer.DeveloperRole.Junior, technologies);
            Angela.FinishProject();
            Angela.FinishProject();
       


            Developer Robin = new Developer("Robin Kamo", "Developer", "910604-1337", 0, Developer.DeveloperRole.Senior, technologies);
            Robin.FinishProject();


            Manager Robert = new Manager("Robert Jakobsen", "Manager", "841127-8181", 17, false);
            Robert.AddEmployee(Robin);
            Robert.AddEmployee(Angela);


            Console.WriteLine("-----Salary breakdown-----");
            Console.WriteLine();

            Console.WriteLine($"Name: {Oliver.Name}");
            Console.WriteLine($"Position: {Oliver.Position}");
            Console.WriteLine($"Salary: {Oliver.CalculateSalary()}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"Name: {Benjamin.Name}");
            Console.WriteLine($"Position: {Benjamin.Position}");
            Console.WriteLine($"Salary: {Benjamin.CalculateSalary()}");
            Console.WriteLine("--------------------------");


            Console.WriteLine($"Name: {Alexander.Name}");
            Console.WriteLine($"Position: {Alexander.Position}");
            Console.WriteLine($"Salary: {Alexander.CalculateSalary()}");
            Console.WriteLine("--------------------------");


        }
    }
}