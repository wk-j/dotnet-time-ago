namespace TimeAgo.Tests;
using TimeAgo;

public class UnitTest1 {
    [Fact]
    public void Test1() {

        var date1 = DateTime.Now.AddMinutes(-1);
        var str1 = date1.AsTimeAgo();

        var date2 = DateTime.UtcNow.AddMinutes(-1);
        var str2 = date1.AsTimeAgo();

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }

    [Fact]
    public void Test2() {
        var date2 = new DateTime(2022, 9, 10, 5, 3, 3);
        var date1 = new DateTime(2022, 9, 8, 0, 0, 0);
        var diff = date2.AsDateDiff(date1, Language.Thai);
        Console.WriteLine(diff);
    }
}