using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidation_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyCase()
        {
            //Arrange
            string input = "(){}[]";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.True(test);
        }

        [Fact]
        public void TestFailCase()
        {
            //Arrange
            string input = "[({)]}";
            //Act
            bool test = BracketValidation(input);
            //Assert
            Assert.False(test);
        }
    }
}
