using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {


            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                }
                else
                {
                    throw new Exception("Invalid grade value");

                }

            }
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(string grade)
        {
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
        }

        public override void AddGrade(char grade)
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    var counter = 0;
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Average += number;
                        counter++;

                        line = reader.ReadLine();

                    }
                    statistics.Average /= counter;
                   
                }
            }
            return statistics;
        }

    }
}
