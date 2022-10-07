using DotnetGitHubActions;

namespace Tests;

public class MyObjectTests
{
    [Fact]
    public void HasMyInt()
    {
        Assert.Equal(420, new MyObject().MyInt);
    }
}
