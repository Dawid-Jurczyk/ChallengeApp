

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        //for float 

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 105) //<------ to jest przykład walidacji danych, bo tylko odpowiednie dane mogą zostać użyte w danej metodzie
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");

            }
        }

        //for string
        public void AddGrade(string grade)
        {
           switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;

                case "6+":
                case "+6":
                    this.AddGrade(105);
                    break;

                case "-6":
                case "6-":

                    this.AddGrade(95);
                    break;

                case "5":
                    this.AddGrade(80);
                    break;

                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;

                case "-5":
                case "5-":

                    this.AddGrade(75);
                    break;

                case "4":
                    this.AddGrade(60);
                    break;

                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;

                case "-4":
                case "4-":

                    this.AddGrade(55);
                    break;

                case "3":
                    this.AddGrade(40);
                    break;

                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;

                case "-3":
                case "3-":

                    this.AddGrade(35);
                    break;

                case "2":
                    this.AddGrade(20);
                    break;

                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;

                case "-2":
                case "2-":

                    this.AddGrade(15);
                    break;

                case "1":
                    this.AddGrade(0);
                    break;

                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;

                case "-1":
                case "1-":

                    this.AddGrade(0);
                    break;

                default:
                   
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                    }
                    else if (char.TryParse(grade, out char resultChar))
                    {
                        this.AddGrade(resultChar);
                    }
                    else
                    {
                        throw new Exception("Invalid grade value");
                    }
                    break;
            }

        }

        //for int
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        //for double

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        //for char - input grades as letters
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);

                    break;

                case 'B':
                case 'b':
                    this.AddGrade(80);

                    break;

                case 'C':
                case 'c':
                    this.AddGrade(60);

                    break;

                case 'D':
                case 'd':
                    this.AddGrade(40);

                    break;

                case 'E':
                case 'e':
                    this.AddGrade(20);

                    break;

                default:
                    throw new Exception("Wrong letter");
            }
        }

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

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;

                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;

                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;

                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;

                default:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;
        }


    }
}
