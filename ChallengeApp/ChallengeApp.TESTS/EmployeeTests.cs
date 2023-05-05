

using NUnit.Framework.Internal;

namespace ChallengeApp.TESTS
{
    public class Tests
    {
       

        [Test]
        public void WhenOnlyPositiveGradesAreAddedThenCheckIfGradesSumIsCorrect()
        {
            //arrange
            Employee testEmployee1 = new Employee("Jan", "Kowalski", 37);
            testEmployee1.AddGrade(7);
            testEmployee1.AddGrade(3);
            testEmployee1.AddGrade(5);
            //act
            var result = testEmployee1.Result;
            //assert
            Assert.AreEqual(15, result);

        }

        [Test]
        public void WhenPositiveAndNegativeGradesAreAddedThenCheckIfGradesSumIsCorrect()
        {
            //arrange
            Employee testEmployee2 = new Employee("Marek", "B¹k", 67);
            testEmployee2.AddGrade(7);
            testEmployee2.AddGrade(3);
            testEmployee2.AddNegativeGrade(5);
            //act
            var result = testEmployee2.Result;
            //assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void WhenOnlyNegativeGradesAreAddedThenChecksIfGradesSumIsCorrect()
        {
            //arrange
            Employee testEmployee3 = new Employee("Monika", "Bia³a", 25);
            testEmployee3.AddNegativeGrade(4);
            testEmployee3.AddNegativeGrade(6);
            testEmployee3.AddNegativeGrade(5);
            //act
            var result = testEmployee3.Result;
            //assert
            Assert.AreEqual(-15,result);
        }
    }
}