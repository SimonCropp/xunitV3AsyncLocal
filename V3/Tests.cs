using Xunit;

public class Tests
{
    private AsyncLocal<object> asyncLocal = new();

    public Tests()
    {
        asyncLocal.Value = new();
    }

    [Fact]
    public void Test()
    {
        Assert.NotNull(asyncLocal.Value);
    }
}