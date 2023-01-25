namespace TimeAgo.Tests;
using TimeAgo;

public class UnitTest1 {
    [Fact]
    public void Test1() {

        var date = new DateTime(2022, 11, 20);
        var str = date.AsTimeAgo();

        Console.WriteLine(str);
    }

    [Fact]
    public void Test2() {
        var date2 = new DateTime(2022, 9, 10, 5, 3, 3);
        var date1 = new DateTime(2022, 9, 8, 0, 0, 0);
        var diff = date2.AsDateDiff(date1, Language.Thai);
        Console.WriteLine(diff);
    }
}