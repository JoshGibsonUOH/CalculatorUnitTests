namespace Calculator_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            double result = Calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            double result = Calculator.Subtract(2, 1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            double result = Calculator.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestDivision()
        {
            double result = Calculator.Divide(6, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(6, 0));
        }

        [Fact]
        public void TestInvalidOperator()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculator.Calculate(2, 3, '%'));
            Assert.Equal("Invalid operator!", ex.Message);
        }

        [Fact]
        public void TestAdditionWithNegativeNumbers()
        {
            double result = Calculator.Add(-1, -2);
            Assert.Equal(-3, result);
        }

        [Fact]
        public void TestSubtractionWithNegativeNumbers()
        {
            double result = Calculator.Subtract(-2, -1);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestMultiplicationWithNegativeNumbers()
        {
            double result = Calculator.Multiply(-2, 3);
            Assert.Equal(-6, result);
        }

        [Fact]
        public void TestDivisionWithNegativeNumbers()
        {
            double result = Calculator.Divide(-6, 2);
            Assert.Equal(-3, result);
        }
    }
}