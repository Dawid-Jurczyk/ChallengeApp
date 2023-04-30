namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string name = "Miszel";
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
            */


            int number = 54422216;

            string numberToString = number.ToString();

            char[] numberAsCharsList = numberToString.ToCharArray();

            int counter0 = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;


            foreach (char i in numberAsCharsList)
            {
                if (i == '0')
                { counter0++; }
                else if (i == '1')
                { counter1++; }
                else if (i == '2')
                { counter2++; }
                else if (i == '3')
                { counter3++; }
                else if (i == '4')
                { counter4++; }
                else if (i == '5')
                { counter5++; }
                else if (i == '6')
                { counter6++; }
                else if (i == '7')
                { counter7++; }
                else if (i == '8')
                { counter8++; }
                else if (i == '9')
                { counter9++; }

            }

            Console.WriteLine($"0 => {counter0}");
            Console.WriteLine($"1 => {counter1}");
            Console.WriteLine($"2 => {counter2}");
            Console.WriteLine($"3 => {counter3}");
            Console.WriteLine($"4 => {counter4}");
            Console.WriteLine($"5 => {counter5}");
            Console.WriteLine($"6 => {counter6}");
            Console.WriteLine($"7 => {counter7}");
            Console.WriteLine($"8 => {counter8}");
            Console.WriteLine($"9 => {counter9}");




        }
    }
}
