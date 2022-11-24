namespace TimeAgo.Tests;
using TimeAgo;

public class UnitTest1 {
    [Fact]
    public void Test1() {

        var date = new DateTime(2022, 11, 20);
        var str = date.AsTimeAgo();

        Console.WriteLine(str);
    }
}