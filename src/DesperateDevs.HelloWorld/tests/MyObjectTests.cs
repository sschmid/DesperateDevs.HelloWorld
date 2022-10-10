namespace DesperateDevs.HelloWorld.Tests;

public class MyObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(42, new MyObject().MyInt);
    }

    [Fact]
    public void IsMyInt()
    {
        Assert.True(new MyObject().IsMyInt(42));
    }
}
