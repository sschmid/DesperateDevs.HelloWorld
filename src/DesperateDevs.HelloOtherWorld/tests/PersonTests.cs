namespace DesperateDevs.HelloOtherWorld.Tests;

public class PersonTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(24, new Person().MyInt);
    }

    [Fact]
    public void SaysHi()
    {
        Assert.Equal("hi", new Person().Say("hi"));
    }
}
