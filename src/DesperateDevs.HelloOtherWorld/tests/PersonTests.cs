namespace DesperateDevs.HelloOtherWorld.Tests;

public class PersonTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(24, new Person().MyInt);
    }
}
