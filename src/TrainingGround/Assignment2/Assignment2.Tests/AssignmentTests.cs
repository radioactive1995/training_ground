namespace Assignment2.Tests;

public class AssignmentTests
{
    [Fact]
    public void Assignment_2_1_Test()
    {
        using var input = new StringReader("t\n1\n1\n3\n1\n1\n2\n1\n0");
        using var output = new StringWriter();
        Console.SetIn(input);
        Console.SetOut(output);

        var service = new AssignmentService();
        service.Assignment_2_1();

        Console.SetIn(Console.In);
        Console.SetOut(Console.Out);

        var resultLines = output.ToString().Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

        // Assertions
        Assert.Contains(resultLines, line => line.StartsWith("Count:") && line.EndsWith("7"));
        Assert.Contains(resultLines, line => line.StartsWith("Sum:") && line.EndsWith("10"));
        Assert.Contains(resultLines, line => line.StartsWith("Average:") && line.EndsWith("1.43"));
    }
}