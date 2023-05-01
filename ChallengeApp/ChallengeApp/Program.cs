namespace ChallengeApp
{
    internal class Program
    {


        static void Main(string[] args)
        {

            User user1 = new User("Adam", "12312fsdfsd");
            User user2 = new User("Dawid", "12312fsdfsd");
            User user3 = new User("Pati", "12312fsdfsd");
            User user4 = new User("Natala", "12312fsdfsd");



            user1.AddScore(5);
            user1.AddScore(2);
            var result = user1.Result;
            Console.WriteLine(result);
            var name = User.GameName;
            



        }


      

    }















}
