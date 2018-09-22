using MyXunitProject;
using Xunit;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyFirstUnitTests
{
    public class Class1:IClassFixture<ConfigurationBuilder>
    {
        private readonly IConfiguration configuration;
        public Class1(ConfigurationBuilder configuration)
        {
#if Debug
configuration.AddJsonFile("appsettings.json");
#endif

            this.configuration = configuration.AddEnvironmentVariables().Build();
        }    

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}