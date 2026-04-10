using HelloWorldSection2;
using HelloWorld;

namespace HelloWorld.Test
{
    public class HelloWorldTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("World! ", HelloWorldSection2.HelloWorld.helloWorlder(1));
            Assert.Equal(0.55555, 0.55553, 3);
        }

        [Theory]
        [InlineData(1, "World! ")]
        [InlineData(2, "World! ")]
        public void Theory1(int numWorld,string helloWorldSequence)
        {
            Assert.Equal(helloWorldSequence, HelloWorldSection2.HelloWorld.helloWorlder(numWorld));

        }
    }
}