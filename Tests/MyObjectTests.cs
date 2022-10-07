using DesperateDevs.HelloWorld;

namespace Tests;

public class MyObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(42, new MyObject().MyInt);
    }
}
