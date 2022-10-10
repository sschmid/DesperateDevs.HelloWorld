namespace DesperateDevs.HelloOtherWorld.Tests;

public class MyObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(24, new MyObject().MyInt);
    }
}
