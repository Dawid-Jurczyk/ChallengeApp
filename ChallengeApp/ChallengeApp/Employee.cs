

using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();


        public Employee() { } // empty constructor


        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }



        public string Name { get; private set; }
        public string Surname { get; private set; }

        //for float - the primary method

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100) //<------ to jest przykład walidacji danych, bo tylko odpowiednie dane mogą zostać użyte w danej metodzie
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
            { AddGradeAsLetter(grade); }
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

        //for double

        public void AddGrade(double grade)
        {

            this.AddGrade((float)grade);
        }


        //for long

        public void AddGrade(long grade)
        {

            this.AddGrade((float)grade);
        }

        //for byte
        public void AddGrade(byte grade)
        {

            this.AddGrade((float)grade);
        }

       //for char - input grades as letters
        public void AddGradeAsLetter(string grade)
        {
            switch(grade)
            {
                case "A" :
                case "a":
                    this.grades.Add(100);

                    break;

                case "B":
                case "b":
                    this.grades.Add(80);

                    break;

                case "C":
                case "c":
                    this.grades.Add(60);

                    break;

                case "D":
                case "d":
                    this.grades.Add(40);

                    break;

                case "E":
                case "e":
                    this.grades.Add(20);

                    break;

                default:
                    Console.WriteLine("Wrong Letter");
                    break;




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

            switch(statistics.Average)
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























