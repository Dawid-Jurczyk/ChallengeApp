

namespace ChallengeApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var employee1 = new Employee("Adam", "Kamizelich");

            employee1.AddGrade(2);
            employee1.AddGrade(2);
            employee1.AddGrade(6);
            
            
            var statistics = employee1.GetStatistics();

            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Max: {statistics.Max}");

         
            







        }









    }















}
