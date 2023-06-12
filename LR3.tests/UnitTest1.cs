

using System.ComponentModel;

namespace LR3.tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestEqualsMeter()
        {
            // Arrange
            Meters obj1 = new Meters(1.5);
            Meters obj2 = new Meters(1.5);

            // Act
            var expected = obj1.Equals(obj2);
            var actual = obj1.Value == obj2.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEqualsInchs()
        {
            // Arrange
            Inches obj1 = new Inches(1.5);
            Inches obj2 = new Inches(1.5);

            // Act
            var expected = obj1.Equals(obj2);
            var actual = obj1.Value == obj2.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestToStringInches()
        {
            // Arrange
            Inches obj1 = new Inches(1.5);

            // Act
            var expected = obj1.ToString();
            var actual = "1,5 i";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestToStringMeters()
        {
            // Arrange
            Meters obj1 = new Meters(1.5);

            // Act
            var expected = obj1.ToString();
            var actual = "1,5 m";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetHashCodeInches()
        {
            // Arrange
            Inches obj1 = new Inches(21.5);

            // Act
            var expected = obj1.GetHashCode();
            var actual = 21;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetHashCodeMeters()
        {
            // Arrange
            Meters obj1 = new Meters(1.5);

            // Act
            var expected = obj1.GetHashCode();
            var actual = 1;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleToInches()
        {
            // Arrange
            Inches obj1 = new Inches(21.5);
            double obj2 = 21.5;

            // Act
            var expected = obj1;
            var actual = (Inches)obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleToMeters()
        {// Arrange
            Meters obj1 = new Meters(21.5);
            double obj2 = 21.5;

            // Act
            var expected = obj1;
            var actual = (Meters)obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMetersToInches()
        {
            // Arrange
            Inches obj1 = new Inches(39.37 * 21.5);
            Meters obj2 = new Meters(21.5);

            // Act
            var expected = obj1;
            var actual = (Inches)obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInchesToMeters()
        {// Arrange
            Meters obj1 = new Meters(0.025 * 21.5);
            Inches obj2 = new Inches(21.5);

            // Act
            var expected = obj1;
            var actual = (Meters)obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionInchesDouble()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            double obj2 = 2;

            // Act
            var expected = obj1 / obj2;
            var actual = new Inches(5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionMetersDouble()
        {
            // Arrange
            var obj1 = new Meters(10);
            double obj2 = 2;
            // Act
            var expected = new Meters(5);
            var actual = obj1 / obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 / obj2;
            var actual = new Inches(5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionMetersMeters()
        {
            // Arrange
            var obj1 = new Meters(10);
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(5);
            var actual = obj1 / obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionDoubleInches()
        {
            // Arrange
            double obj1 = 10;
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 / obj2;
            var actual = new Inches(5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionDoubleMeters()
        {
            // Arrange
            double obj1 = 10;
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(5);
            var actual = obj1 / obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionMetersInches()
        {
            // Arrange
            Meters obj1 = 10;
            Inches obj2 = new Inches(2 / 0.025);

            // Act
            var expected = obj1 / obj2;
            var actual = new Meters(5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionInchesMeters()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            var obj2 = new Meters(2 / 39.37);
            // Act
            var expected = new Inches(5);
            var actual = obj1 / obj2;
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TestMinusInchesDouble()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            double obj2 = 2;

            // Act
            var expected = obj1 - obj2;
            var actual = new Inches(8);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusMetersDouble()
        {
            // Arrange
            var obj1 = new Meters(10);
            double obj2 = 2;
            // Act
            var expected = new Meters(8);
            var actual = obj1 - obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 - obj2;
            var actual = new Inches(8);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusMetersMeters()
        {
            // Arrange
            var obj1 = new Meters(10);
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(8);
            var actual = obj1 - obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusDoubleInches()
        {
            // Arrange
            double obj1 = 10;
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 - obj2;
            var actual = new Inches(8);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusDoubleMeters()
        {
            // Arrange
            double obj1 = 10;
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(8);
            var actual = obj1 - obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusMetersInches()
        {
            // Arrange
            Meters obj1 = 10;
            Inches obj2 = new Inches(2 / 0.025);

            // Act
            var expected = obj1 - obj2;
            var actual = new Meters(8);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMinusInchesMeters()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            var obj2 = new Meters(2 / 39.37);
            // Act
            var expected = new Inches(8);
            var actual = obj1 - obj2;
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TestPlusInchesDouble()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            double obj2 = 2;

            // Act
            var expected = obj1 + obj2;
            var actual = new Inches(12);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusMetersDouble()
        {
            // Arrange
            var obj1 = new Meters(10);
            double obj2 = 2;
            // Act
            var expected = new Meters(12);
            var actual = obj1 + obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 + obj2;
            var actual = new Inches(12);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusMetersMeters()
        {
            // Arrange
            var obj1 = new Meters(10);
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(12);
            var actual = obj1 + obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusDoubleInches()
        {
            // Arrange
            double obj1 = 10;
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 + obj2;
            var actual = new Inches(12);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusDoubleMeters()
        {
            // Arrange
            double obj1 = 10;
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(12);
            var actual = obj1 + obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusMetersInches()
        {
            // Arrange
            Meters obj1 = 10;
            Inches obj2 = new Inches(2 / 0.025);

            // Act
            var expected = obj1 + obj2;
            var actual = new Meters(12);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPlusInchesMeters()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            var obj2 = new Meters(2 / 39.37);
            // Act
            var expected = new Inches(12);
            var actual = obj1 + obj2;
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TestMultiplyInchesDouble()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            double obj2 = 2;

            // Act
            var expected = obj1 * obj2;
            var actual = new Inches(20);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyMetersDouble()
        {
            // Arrange
            var obj1 = new Meters(10);
            double obj2 = 2;
            // Act
            var expected = new Meters(20);
            var actual = obj1 * obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 * obj2;
            var actual = new Inches(20);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyMetersMeters()
        {
            // Arrange
            var obj1 = new Meters(10);
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(20);
            var actual = obj1 * obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyDoubleInches()
        {
            // Arrange
            double obj1 = 10;
            Inches obj2 = new Inches(2);

            // Act
            var expected = obj1 * obj2;
            var actual = new Inches(20);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyDoubleMeters()
        {
            // Arrange
            double obj1 = 10;
            var obj2 = new Meters(2);
            // Act
            var expected = new Meters(20);
            var actual = obj1 * obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyMetersInches()
        {
            // Arrange
            Meters obj1 = 10;
            Inches obj2 = new Inches(2 / 0.025);

            // Act
            var expected = obj1 * obj2;
            var actual = new Meters(20);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyInchesMeters()
        {
            // Arrange
            Inches obj1 = new Inches(39.37);
            var obj2 = new Meters(1);
            // Act
            var expected = new Inches(39.37 * 39.37);
            var actual = obj1 * obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEqualInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(10);

            // Act
            var expected = obj1 == obj2;
            var actual = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestEqualMetersMeters()
        {
            // Arrange
            Meters obj1 = new Meters(10);
            Meters obj2 = new Meters(10);

            // Act
            var expected = obj1 == obj2;
            var actual = true;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNotEqualInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(1);

            // Act
            var expected = obj1 != obj2;
            var actual = true;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNotEqualMetersMeters()
        {
            // Arrange
            Meters obj1 = new Meters(10);
            Meters obj2 = new Meters(1);

            // Act
            var expected = obj1 != obj2;
            var actual = true;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLessInchesInches()
        {
            // Arrange
            Inches obj1 = new Inches(10);
            Inches obj2 = new Inches(100);

            // Act
            var expected = obj1 < obj2;
            var actual = true;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLessMetersMeters()
        {
            // Arrange
            Meters obj1 = new Meters(10);
            Meters obj2 = new Meters(100);

            // Act
            var expected = obj1 < obj2;
            var actual = true;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SplitCountDataInches))]
        public void TestLessOrEqualInchesInches(Inches obj1, Inches obj2)
        {
            // Arrange
            // Act
            var expected = obj1.Value <= obj2.Value;
            var actual = obj1 <= obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SplitCountDataMeters))]
        public void TestLessOrEqualMetersMeters(Meters obj1, Meters obj2)
        {
            // Arrange
            // Act
            var expected = obj1.Value <= obj2.Value;
            var actual = obj1 <= obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SplitCountDataInches))]
        public void TestGreaterOrEqualInchesInches(Inches obj1, Inches obj2)
        {
            // Arrange
            // Act
            var expected = obj1.Value >= obj2.Value;
            var actual = obj1 >= obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SplitCountDataMeters))]
        public void TestGreaterOrEqualMetersMeters(Meters obj1, Meters obj2)
        {
            // Arrange
            // Act
            var expected = obj1.Value >= obj2.Value;
            var actual = obj1 >= obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SplitCountDataInches))]
        public void TestGreaterInchesInches(Inches obj1, Inches obj2)
        {
            // Arrange
            // Act
            var expected = obj1.Value > obj2.Value;
            var actual = obj1 > obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SplitCountDataMeters))]
        public void TestGreaterMetersMeters(Meters obj1, Meters obj2)
        {
            // Arrange
            // Act
            var expected = obj1.Value > obj2.Value;
            var actual = obj1 > obj2;
            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> SplitCountDataInches
        {
            get
            {
                Inches inches11 = new Inches(1);
                Inches inches12 = new Inches(10);

                Inches inches21 = new Inches(10);
                Inches inches22 = new Inches(1);

                Inches inches31 = new Inches(10);
                Inches inches32 = new Inches(10);

                return new[]
                {
                new object[] { inches11, inches12 },
                new object[] { inches21, inches22 },
                new object[] { inches31, inches32 }
                };
            }
        }

        public static IEnumerable<object[]> SplitCountDataMeters
        {
            get
            {
                Meters obj11 = new Meters(1);
                Meters obj12 = new Meters(10);

                Meters obj21 = new Meters(10);
                Meters obj22 = new Meters(1);

                Meters obj31 = new Meters(10);
                Meters obj32 = new Meters(10);

                return new[]
                {
                new object[] { obj11, obj12 },
                new object[] { obj21, obj22 },
                new object[] { obj31, obj32 }
                };
            }
        }
    }
 
}