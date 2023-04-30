namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string name = "Miszel";
            char sex = 'm'; //w for woman | m for man
            int age = 14;
            if (sex == 'w')  //woman
            {

                if (name == "") //woman give age only
                {
                    if (age >= 18 && age <= 30)
                    {
                        Console.WriteLine("Kobieta poniżej 30 lat");
                    }
                    else if (age > 30)
                    {
                        Console.WriteLine("Kobieta powyżej 30 lat");
                    }
                    else
                    {
                        Console.WriteLine("Niepełnoletnia kobieta");
                    }
                }
                else //woman give name and age
                {
                    Console.WriteLine($"{name}, lat {age}");
                }
            }
            else //man    
            {

                if (name == "") //man give age only
                {
                    if (age >= 18 && age <= 30)
                    {
                        Console.WriteLine("Mężczyzna poniżej 30 lat");
                    }
                    else if (age > 30)
                    {
                        Console.WriteLine("Mężczyzna powyżej 30 lat");
                    }
                    else
                    {
                        Console.WriteLine("Niepełnoletni mężczyzna");
                    }
                }
                else  //man give name and age
                {
                    Console.WriteLine($"{name}, lat {age}");
                }
            }
            

            
            int[] grades = new int[5];

            List<string> dayOfWeeks = new List<string>();

            dayOfWeeks.Add("Poniedziałek");
            dayOfWeeks.Add("Wtorek");
            dayOfWeeks.Add("Środa");
            dayOfWeeks.Add("Czwartek");
            dayOfWeeks.Add("Piątek");
            dayOfWeeks.Add("Sobota");
            dayOfWeeks.Add("Niedziela"); 
           

            for (int i = 0; i <= dayOfWeeks.Count; i++)
            {
                Console.WriteLine($"Dzisiaj jest {dayOfWeeks[i]}");
            }

            foreach(var day in dayOfWeeks)
            {
                Console.WriteLine(day);
            }
            


        

        }
    }
}
