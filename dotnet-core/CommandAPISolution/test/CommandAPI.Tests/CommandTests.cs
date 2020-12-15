using System;
using Xunit;

using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests
    {
        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange
            var correctDescription = "Run unit tests";
            var testCommand = new Command 
            {
                HowTo = "Build application",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };

            testCommand.HowTo = correctDescription;
            Assert.Equal(correctDescription, testCommand.HowTo);
        }
    }
}
