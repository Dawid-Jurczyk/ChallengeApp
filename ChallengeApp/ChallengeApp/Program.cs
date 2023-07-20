

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

            var employee = new EmployeeInFile("Adam", "Kamizelich");
            employee.AddGrade(60);
            employee.AddGrade('c');
            employee.AddGrade("c");
            employee.AddGrade(60);

            var statistics = employee.GetStatistics();
            Console.WriteLine(statistics.Min);
            Console.WriteLine(statistics.Max);
            Console.WriteLine(statistics.Average);
            


        }
    }
}



    //        Console.WriteLine("Wybierz czy chcesz oceniań zwykłego pracownika czy kierownika ?");
    //        Console.WriteLine("Wciśnij \"J\" jeśli chcesz ocenić zwykłego pracownika lub \"K\" jeśli chcesz ocenić kierownika");
    //        Console.WriteLine("=============================================================");
    //        string option = Console.ReadLine();
       
    //        switch(option)
    //        {
    //            case "J":
    //            case "j":

    //                while (true)
    //                {
    //                    Console.WriteLine("Podaj ocenę pracownika ");
    //                    var input = Console.ReadLine();
    //                    if (input == "q" || input == "Q")
    //                    {
    //                        break;
    //                    }
    //                    try
    //                    {
    //                        employee.AddGrade(input); //<--- tutaj obsługujemy exceptiona bo w metodzie AddGrade mamy throwa

    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Console.WriteLine(e.Message);
    //                    }
    //                }
    //                break;

    //            case "K":
    //            case "k":

    //                while (true)
    //                {
    //                    Console.WriteLine("Podaj ocenę pracownika ");
    //                    var input = Console.ReadLine();
    //                    if (input == "q" || input == "Q")
    //                    {
    //                        break;
    //                    }
    //                    try
    //                    {
    //                        supervisor.AddGrade(input); //<--- tutaj obsługujemy exceptiona bo w metodzie AddGrade mamy throwa

    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Console.WriteLine(e.Message);
    //                    }
    //                }
    //                break;
    //        }

            
    //        if(option == "j" || option == "J")
    //        {
    //            var statistics = employee.GetStatistics();
    //            Console.WriteLine("Grades statistics are:");
    //            Console.WriteLine($"-> Average: {statistics.Average:N2}");
    //            Console.WriteLine($"-> Average grade as letter: {statistics.AverageLetter}");
    //            Console.WriteLine($"-> Highest grade: {statistics.Max}");
    //            Console.WriteLine($"-> Lowest grade: {statistics.Min}");
    //        }
    //        else
    //        {
    //            var statistics = supervisor.GetStatistics();
    //            Console.WriteLine("Grades statistics are:");
    //            Console.WriteLine($"-> Average: {statistics.Average:N2}");
    //            Console.WriteLine($"-> Average grade as letter: {statistics.AverageLetter}");
    //            Console.WriteLine($"-> Highest grade: {statistics.Max}");
    //            Console.WriteLine($"-> Lowest grade: {statistics.Min}");
    //        }
           
    //    }

    //}


    //while (true)
    //{



    //    Console.WriteLine("Podaj ocenę pracownika ");
    //    var input = Console.ReadLine();
    //    if(input == "q" || input == "Q")
    //    {
    //        break;
    //    }
    //   try
    //    {
    //        employee.AddGrade(input); //<--- tutaj obsługujemy exceptiona bo w metodzie AddGrade mamy throwa

    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //    }

    //}













        
