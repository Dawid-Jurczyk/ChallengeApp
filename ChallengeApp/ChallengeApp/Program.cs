

namespace ChallengeApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Employee denis = new Employee("Denis", "Smith", 32);
            Employee john = new Employee("John", "West", 44);
            Employee rick = new Employee("Rick", "Willman", 56);

            denis.AddGrade(3);
            denis.AddGrade(7);
            denis.AddGrade(8);
            denis.AddGrade(10);
            denis.AddGrade(4);

            john.AddGrade(5);
            john.AddGrade(7);
            john.AddGrade(9);
            john.AddGrade(8);
            john.AddGrade(9);

            rick.AddGrade(10);
            rick.AddGrade(1);
            rick.AddGrade(8);
            rick.AddGrade(7);
            rick.AddGrade(9);

            List<Employee> employees = new List<Employee>()
            {  denis, john, rick, };

            int highestGrade = -1;

            Employee employeeWithHighestGrade = null;

            foreach (var i in employees)
            {
                if (i.Result > highestGrade)
                {
                    highestGrade = i.Result;
                    employeeWithHighestGrade = i;
                }
            }

            Console.WriteLine("Employee grades are:");
            Console.WriteLine($"Denis - {denis.Result}");
            Console.WriteLine($"John - {john.Result}");
            Console.WriteLine($"Rick - {rick.Result}");
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Employee with the highest grade is:");
            Console.WriteLine($"{employeeWithHighestGrade.FirstName} {employeeWithHighestGrade.LastName}");
            Console.WriteLine($"{employeeWithHighestGrade.Age} years old");
            Console.WriteLine($"grade: {employeeWithHighestGrade.Result}");










        }









    }















}
