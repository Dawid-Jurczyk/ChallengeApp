

using NUnit.Framework.Internal;

namespace ChallengeApp.TESTS
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticCalled_ShouldReturnCorrectMax()
        {
            //Arrange
            Employee testEmployee= new Employee("Jan", "Kowalski");
            testEmployee.AddGrade(9);
            testEmployee.AddGrade(8);
            testEmployee.AddGrade(6);

            //Act
            var statistics = testEmployee.GetStatistics();

            //Asset
            Assert.AreEqual(9, statistics.Max);


        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            //Arrange
            Employee testEmployee = new Employee("Jan", "Kowalski");
            testEmployee.AddGrade(9);
            testEmployee.AddGrade(8);
            testEmployee.AddGrade(6);
            //Act
            var statistics = testEmployee.GetStatistics();

            //Assert
            Assert.AreEqual(6, statistics.Min);



        }
        
        
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage() 
        {
            // Arrange
            Employee testEmployee = new Employee("Jan", "Kowalski");
            testEmployee.AddGrade(9);
            testEmployee.AddGrade(8);
            testEmployee.AddGrade(6);
            // Act
            var statistics = testEmployee.GetStatistics();

            // Assert
            Assert.AreEqual(Math.Round(7.66666666,2),Math.Round(statistics.Average,2));
           
        }


        [Test]
        public void WhenInputGradeAsLetterShouldReturnCorrectStatistics()
        {
            Employee testEmployee = new Employee();
            testEmployee.AddGrade("a");
            testEmployee.AddGrade("A");
            testEmployee.AddGrade("a");
          
            var statistics = testEmployee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(100, statistics.Min);
            Assert.AreEqual(100, statistics.Average);
            Assert.IsTrue(statistics.AverageLetter == 'A');
        }

        [Test]
        public void WhenInputGradesAsLettersAndAsNumbersShouldReturnCorrectStatistics()
        {
            Employee testEmployee = new Employee();
            testEmployee.AddGrade("b");
            testEmployee.AddGrade("B");
            testEmployee.AddGrade(80);
            testEmployee.AddGrade(80);

            var statistics = testEmployee.GetStatistics();

            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(80, statistics.Min);
            Assert.AreEqual(80, statistics.Average);
            Assert.IsTrue(statistics.AverageLetter == 'A');


        }


    }           












    }










