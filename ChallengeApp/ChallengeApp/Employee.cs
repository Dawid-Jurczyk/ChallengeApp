

namespace ChallengeApp
{
   public class Employee
    {
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public  string FirstName { get; private set; }
        public  string LastName { get; private set; }
        public  int Age { get; private set; }

        private List<int> grade = new List<int>();


        public void AddGrade(int grade)
        {
            this.grade.Add(grade);
        }

     public void AddNegativeGrade(int negativeGrade)
        {
            negativeGrade = -negativeGrade;
            this.grade.Add(negativeGrade);
        }

        public int Result
        {
            get
            {
                return this.grade.Sum();
            }

        }

    }


}






















