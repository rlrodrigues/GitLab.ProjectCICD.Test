using System;
using Xunit;

namespace GitLab.ProjectCICD.Test.XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 0;
            int b = 0;

            Assert.Equal(a, b);
        }
    }
}
