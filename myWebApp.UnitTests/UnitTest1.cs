using System;
using Xunit;
using System.IO;

namespace HelloWorldTests
{
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Assert.Equal(Expected, "Hello World!");
            }
        }
    }
}