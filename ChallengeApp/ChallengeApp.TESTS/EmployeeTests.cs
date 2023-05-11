

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

        }












    }










