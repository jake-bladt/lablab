using System;
using Xunit;

using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        private Command TestCommand;

        public CommandTests()
        {
            TestCommand = new Command 
            {
                HowTo = "Build application",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }


        [Fact]
        public void CanChangeHowTo()
        {
            var correctDescription = "Run unit tests";
            TestCommand.HowTo = correctDescription;
            Assert.Equal(correctDescription, TestCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            var correctPlatform = "dotnet CLI";
            TestCommand.Platform = correctPlatform;
            Assert.Equal(correctPlatform, TestCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            var correctCommand = "dotnet build";
            TestCommand.CommandLine = correctCommand;
            Assert.Equal(correctCommand, TestCommand.CommandLine);
        }

        public void Dispose()
        {
            TestCommand = null;
        }
    }
}
