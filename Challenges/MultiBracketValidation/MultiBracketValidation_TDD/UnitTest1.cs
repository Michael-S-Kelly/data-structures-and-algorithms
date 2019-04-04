using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidation_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyCase1()
        {
            //Arrange
            string input = "()";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.True(test);
        }

        [Fact]
        public void TestHappyCase2()
        {
            //Arrange
            string input = "{}[]()";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.True(test);
        }

        [Fact]
        public void TestHappyCase3()
        {
            //Arrange
            string input = "(I am happy that this is working)";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.True(test);
        }

        [Fact]
        public void TestFailCase()
        {
            //Arrange
            string input = "]({)[}";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.False(test);
        }

        [Fact]
        public void TestEdgeCase1()
        {
            //Arrange
            string input = "({[]})";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.True(test);
        }

        [Fact]
        public void TestEdgeCase2()
        {
            //Arrange
            string input = " ";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.True(test);
        }
    }
}
