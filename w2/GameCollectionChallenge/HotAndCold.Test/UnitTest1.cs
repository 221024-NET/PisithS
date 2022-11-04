using HotAndCold;

namespace HotAndCold.Test;

public class UnitTest1
{
    //! This attribute declares a test method that's run by the test runner. Basically when we
    //! run in our terminal dotnet test, it knows that this is the test unit we are using.
    [Fact]
    /*!
     * unitOfTest_TestConditon_CorrectBehavior
     * Test Driven Design is a way to run and test our program. In where unit testing involves
     * Arrange, Act, and Assert. What needs to be in place for your test to work properly?
     * What behavior are we checking? and What are your expected results? It is something that
     * will most of the time be required on large scale projects however this code here is an
     * example of a unit test on the program name HotAndCold.cs. Oddly enough Visual Studio has a 
     * built in XUnit file that can be created and once done it follows the syntax listed below:
     * 
       using System;
       using Xunit;

        namespace MyFirstUnitTests
        {
            public class UnitTest1
            {
                [Fact]
                public void Test1()
                {

                }
            }
        }
     *
     */
    public void PrintResult_CorrectGuess_Congratulate()
    {
        // a unit test needs to be precise! 
        //? Arrange - What needs to be in place for your test to work properly?
        Guessing tmp = new Guessing();
        int secret = 5;
        int user = 5;
        string expected = "Congatulations, you've guessed the secret number!";
        // We're creating a function and fake values that will passed through the function
        // in order for us to run our test case. We also have a string variable that will
        // be used to compare the result that we want it to be

        //? Act - What behavior are we checking?
        string result = tmp.PrintResult( secret, user);
        // Here we are running our function and setting the results into the variable for comparisons

        //? Assert - What are your expected results? Think both positive and negative.
        Assert.Equal( expected: expected, actual: result);
        // 
    }
    
    [Fact]
    public void PrintResult_TooHigh_StateTooHigh()
    {
        //? Arrange - What needs to be in place for your test to work properly?
        Guessing tmp = new Guessing();
        int secret = 5;
        int user = 6;
        string expected = "Oops, too high!";

        //? Act - What behavior are we checking?
        string result = tmp.PrintResult( secret, user);

        //? Assert - What are your expected results? Think both positive and negative.
        Assert.Equal( expected: expected, actual: result);
    }
}