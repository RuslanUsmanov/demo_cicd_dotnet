using ConsoleApp;
namespace Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.That(Algebra.Sum(1, 1), Is.EqualTo(2));
    }
}
