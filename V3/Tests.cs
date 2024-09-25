using Xunit;

public class Tests
{
    static AsyncLocal<object> asyncLocal = new();

    public Tests() =>
        asyncLocal.Value = new();

    [Fact]
    public void Test() =>
        Assert.NotNull(asyncLocal.Value);
}