﻿namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname)
        : base(name, surname)
        {
        }

        private List<float> grades = new List<float>();
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100) //<------ to jest przykład walidacji danych, bo tylko odpowiednie dane mogą zostać użyte w danej metodzie
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");

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
