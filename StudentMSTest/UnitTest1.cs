using System.Runtime.CompilerServices;
using ClassRoomNet60.Model;

namespace StudentMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Student studentlist = new Student();
        [TestMethod]
        public void StudentTest()
        {
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(12)]
        public void Student_Born_In_Winter(int value)
        {
            // Arrange
            Student student = new Student("Test", value, 4);
            // Act
            string year = student.Seasons(value);
            // Assert
            Assert.AreEqual("Winter", year);
        }
        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void Student_Born_In_Spring(int value)
        {
            // Arrange
            Student student = new Student("Test", value, 4);
            // Act
            string year = student.Seasons(value);
            // Assert
            Assert.AreEqual("Spring", year);
        }
        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void Student_Born_In_Summer(int value)
        {
            // Arrange
            Student student = new Student("Test", value, 4);
            // Act
            string year = student.Seasons(value);
            // Assert
            Assert.AreEqual("Summer", year);
        }
        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void Student_Born_In_Autumn(int value)
        {
            // Arrange
            Student student = new Student("Test", value, 4);
            // Act
            string year = student.Seasons(value);
            // Assert
            Assert.AreEqual("Autumn", year);
        }
        [DataTestMethod]
        [DataRow(13)]
        [DataRow(0)]
        [DataRow(-2)]
        [ExpectedException(typeof(ArgumentException))]
        public void Student_Born_In_InCorrentMonths(int value)
        {
            // Arrange
            Student student = new Student("Test", value, 4);
            // Act
            string year = student.Seasons(value);
            // Assert
            Assert.AreEqual("Incorrect Birthmonth2", year);
            
        }

    }
}