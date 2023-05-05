

namespace ChallengeApp.TESTS
{
    public class TypeTests
    {
        //tests for ints
        [Test]
        public void CheckIfTwoIntsWithDifferentValuAreNotEqual()
        {
            int number1 = 5;
            int number2 = 8;

            Assert.AreNotEqual(number1, number2);


        }

        [Test]
        public void CheckIfTwoIntsWithSameValueAreEqual()
        {
            int number1 = 9;
            int number2 = 9;

            Assert.AreEqual(number1, number2);
        
        }

        //tests for floats

        [Test]
        public void CheckIfTwoFloatsWithDifferentValuAreNotEqual()
        {
            float number1 = 5.94F;
            float number2 = 4.12F;

            Assert.AreNotEqual(number1, number2);


        }

        [Test]
        public void CheckIfTwoFloatsWithSameValueAreEqual()
        {
            float number1 = 7.45F;
            float number2 = 7.45F;

            Assert.AreEqual(number1, number2);

        }

        //test for string
        [Test]
        public void CheckIfTwoStringsWithDifferentValuAreNotEqual()
        {
            string name1 = "Mariusz";
            string name2 = "Bartek";



            Assert.AreNotEqual(name1, name2);

        }

        [Test]
        public void CheckIfTwoStringsWithSameValueAreEqual()
        {
            string name1 = "Mariusz";
            string name2 = "Mariusz";



          Assert.AreEqual(name1, name2);

        }

        //tests for objects - reference types

        [Test]
        public void CheckIfTwoObjectsWithDifferentValuAreNotEqual()
        {
            //arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Tomasz");

            Assert.AreNotEqual(employee1, employee2);

        }

        [Test]
        public void CheckIfTwoObjectsWithSameValuAreNotEqual()
        {
            //arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");

            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }



    }
}
