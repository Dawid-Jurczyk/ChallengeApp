

namespace ChallengeApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Witamy with Programie Employees_Grades do oceny Pracowników");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine();

            var employee = new Employee();
            
            
            while(true)
            {
                Console.WriteLine("Podaj ocenę pracownika ");
                var input = Console.ReadLine();
                if(input == "q" || input == "Q")
                {
                    break;
                }
                employee.AddGrade(input);

            }
            
            var statistics = employee.GetStatistics();
            Console.WriteLine("Grades statistics are:");
            Console.WriteLine($"-> Average: {statistics.Average:N2}");
            Console.WriteLine($"-> Average grade as letter: {statistics.AverageLetter}");
            Console.WriteLine($"-> Highest grade: {statistics.Max}");
            Console.WriteLine($"-> Lowest grade: {statistics.Min}");
            








        }









    }















}
