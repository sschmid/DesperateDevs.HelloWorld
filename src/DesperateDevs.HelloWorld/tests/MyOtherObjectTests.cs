namespace DesperateDevs.HelloWorld.Tests;

public class MyOtherObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(42, new MyOtherObject().MyInt);
    }
}
