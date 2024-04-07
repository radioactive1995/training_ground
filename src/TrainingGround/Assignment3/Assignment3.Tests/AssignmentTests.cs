namespace Assignment3.Tests;

public class AssignmentTests
{
    [Fact]
    public void Assignment_3_1_Test1()
    {
        //Arrange
        string inputNumbers = "5\n12\n7\n3\n1\n8\n4\n2\n9\n6";
        using var input = new StringReader(inputNumbers);
        using var output = new StringWriter();
        Console.SetIn(input);
        Console.SetOut(output);

        var service = new AssignmentService();

        //Act
        service.Assignment_3_1();

        //Assert
        var resultLines = output.ToString().Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

        Assert.Contains(resultLines, line => line.StartsWith("Minimum:") && line.EndsWith("1"));
        Assert.Contains(resultLines, line => line.StartsWith("Maximum:") && line.EndsWith("12"));
        Assert.Contains(resultLines, line => line.StartsWith("Sum:") && line.EndsWith("57"));
        Assert.Contains(resultLines, line => line.Contains("Average:") && line.EndsWith("5.7"));
        Assert.Contains(resultLines, line => line.StartsWith("Sorted:") && line.EndsWith("1 2 3 4 5 6 7 8 9 12"));
        Assert.Contains(resultLines, line => line.StartsWith("Median:") && line.EndsWith("5.5"));
    }

    [Fact]
    public void Assignment_3_1_Test2()
    {
        //Arrange
        string inputNumbers = "5\n12\n7\nt\n3\n1\n0\n8\n4\n2\n9";
        using var input = new StringReader(inputNumbers);
        using var output = new StringWriter();
        Console.SetIn(input);
        Console.SetOut(output);

        var service = new AssignmentService();

        //Act
        service.Assignment_3_1();

        // Assert
        var resultLines = output.ToString().Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

        Assert.Contains(resultLines, line => line.StartsWith("Minimum:") && line.EndsWith("0"));
        Assert.Contains(resultLines, line => line.StartsWith("Maximum:") && line.EndsWith("12"));
        Assert.Contains(resultLines, line => line.StartsWith("Sum:") && line.EndsWith("51"));
        Assert.Contains(resultLines, line => line.Contains("Average:") && line.EndsWith("5.1"));
        Assert.Contains(resultLines, line => line.StartsWith("Sorted:") && line.EndsWith("0 1 2 3 4 5 7 8 9 12"));
        Assert.Contains(resultLines, line => line.StartsWith("Median:") && line.EndsWith("4.5"));
    }


}