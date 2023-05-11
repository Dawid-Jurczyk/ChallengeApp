

namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();


        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }



        public string Name { get; private set; }
        public string Surname { get; private set; }

        //for float

        public void AddGrade(float grade)
        {
            int valueInInt = (int)Math.Ceiling(grade);

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        //for string
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            { Console.WriteLine("String is not float"); }
        }

        //for int
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        //for decimal
        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }


        //for long

        //for double

        //for char




        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

    }


}






















