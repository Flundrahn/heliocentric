using FluentAssertions;

namespace Heliocentric.Tests
{
    public class SolverTests
    {
        [Fact]
        public void Case_1()
        {
            // Arrange
            var solver = new Solver();
            var initialEarth = 0;
            var initialMars = 0;

            // Act
            var time = solver.EarthMeetMars(initialEarth, initialMars);

            // Assert
            time.Should().Be(0);
        }

        [Fact]
        public void Case_2()
        {
            // Arrange
            var solver = new Solver();
            var initialEarth = 364;
            var initialMars = 686;

            // Act
            var time = solver.EarthMeetMars(initialEarth, initialMars);

            // Assert
            time.Should().Be(1);
        }

        [Fact]
        public void Case_3()
        {
            // Arrange
            var solver = new Solver();
            var initialEarth = 360;
            var initialMars = 682;

            // Act
            var time = solver.EarthMeetMars(initialEarth, initialMars);

            // Assert
            time.Should().Be(5);
        }

        [Fact]
        public void Case_4()
        {
            // Arrange
            var solver = new Solver();
            var initialEarth = 0;
            var initialMars = 1;

            // Act
            var time = solver.EarthMeetMars(initialEarth, initialMars);

            // Assert
            time.Should().Be(239075);
        }

        [Fact]
        public void Case_5()
        {
            // Arrange
            var solver = new Solver();
            var initialEarth = 1;
            var initialMars = 0;

            // Act
            var time = solver.EarthMeetMars(initialEarth, initialMars);

            // Assert
            time.Should().Be(11679);
        }
    }
}