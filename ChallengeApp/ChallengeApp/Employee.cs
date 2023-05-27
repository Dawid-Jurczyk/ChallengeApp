

namespace ChallengeApp
{
    public class Employee : Person
    {

        private List<float> grades = new List<float>();



        public Employee(string name, string surname, string sex)
            : base(name, surname, sex) { }








        //for float - the primary method

        public void AddGrade(float grade)
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

        //for string
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if(char.TryParse(grade, out char resultChar))
            {

                this.AddGrade(resultChar);

                //char gradeAsChar = grade[0]; <- to jest "nie ładne" chociaż działa
                //AddGrade(gradeAsChar);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
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
        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A' :
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























