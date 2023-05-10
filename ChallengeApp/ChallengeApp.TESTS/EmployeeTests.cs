

using NUnit.Framework.Internal;

namespace ChallengeApp.TESTS
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticsIsCalledForOneGrade()
        {
            //Arrange
            Employee testEmployee= new Employee("Jan", "Kowalski");
            testEmployee.AddGrade(5.5f);

            //Act
            Statistics result = testEmployee.GetStatistics();

            //Asset
            Assert.AreEqual(5.5f, result.Average);
            Assert.AreEqual(5.5f, result.Min);
            Assert.AreEqual(5.5f, result.Max);


        }

        [Test]
        public void WhenGetStatisticsIsCalledForMultipleGrades()
        {
            //Arrange
            Employee testEmployee = new Employee("Jan", "Kowalski");
            testEmployee.AddGrade(8.0f);
            testEmployee.AddGrade(2.0f);
            testEmployee.AddGrade(5.0f);

            //Act
            var statistics = testEmployee.GetStatistics();

            //Assert
            Assert.AreEqual(5.0f, statistics.Average);
            Assert.AreEqual(2.0f, statistics.Max);
            Assert.AreEqual(8.0f, statistics.Min);



        }
        
        
        [Test]
        public void WhenGetStatisticsIsCalledForZeroGrades() {
            // Arrange
            Employee testEmployee = new Employee("Jan", "Kowalski");
            // Act
            Statistics result = testEmployee.GetStatistics();

            // Assert
            Assert.AreEqual(0f, result.Average);
            Assert.AreEqual(float.MaxValue, result.Min);
            Assert.AreEqual(float.MinValue, result.Max);
        }

        }












    }










