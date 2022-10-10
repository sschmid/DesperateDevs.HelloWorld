namespace DesperateDevs.HelloOtherWorld.Tests;

public class OtherPersonTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(24, new OtherPerson().MyInt);
    }
}
