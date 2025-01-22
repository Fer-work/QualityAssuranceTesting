namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTest
    {
        private GradeCalculator _gradeCalculator { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [Test]
        public void GetGradeByPercentage_input90_True()
        {
            // Arrange
            var percentage = 90;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("A"));
        }

        [Test]
        public void GetGradeByPercentage_input80_True()
        {
            // Arrange
            var percentage = 80;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("B"));
        }

        [Test]
        public void GetGradeByPercentage_input70_True()
        {
            // Arrange
            var percentage = 70;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("C"));
        }

        [Test]
        public void GetGradeByPercentage_input60_True()
        {
            // Arrange
            var percentage = 60;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("D"));
        }

        [Test]
        public void GetGradeByPercentage_input50_True()
        {
            // Arrange
            var percentage = 50;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("F"));
        }

        [Test]
        public void GetGradeByPercentage_input200_True()
        {
            // Arrange
            var percentage = 200;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.That(grade, Is.EqualTo("Invalid"));
        }
    }
}