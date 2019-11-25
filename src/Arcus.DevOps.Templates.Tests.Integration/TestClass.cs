using System;
using Xunit;

namespace Arcus.DevOps.Templates.Tests.Integration
{
    [Trait("Category", "Integration")]
    public class TestClass
    {
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }
    }
}
