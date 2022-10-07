using DesperateDevs.HelloWorld;

namespace Tests;

public class MyObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(420, new MyObject().MyInt);
    }
}
