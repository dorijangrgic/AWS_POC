namespace SimpleMinimalApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var first = "Hello";
        var second = "Hello";
        
        Assert.Equal(first, second);
    }
}