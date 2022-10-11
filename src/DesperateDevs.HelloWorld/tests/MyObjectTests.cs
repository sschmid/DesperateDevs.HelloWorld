namespace DesperateDevs.HelloWorld.Tests;

public class MyObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(42, new MyObject().MyInt);
    }

    [Fact]
    public void HasMyString()
    {
        Assert.Equal("42", new MyObject().MyString);
    }

    [Fact]
    public void IsMyInt()
    {
        Assert.True(new MyObject().IsMyInt(42));
    }

    [Fact]
    public void IsNotMyInt()
    {
        Assert.False(new MyObject().IsMyInt(0));
    }

    // [Fact]
    // public void SaysHi()
    // {
    //     Assert.Equal("hi", new MyObject().Say("hi"));
    // }
    //
    // [Fact]
    // public void Greets()
    // {
    //     Assert.Equal("hi", new MyObject().Greet("hi"));
    // }
}
