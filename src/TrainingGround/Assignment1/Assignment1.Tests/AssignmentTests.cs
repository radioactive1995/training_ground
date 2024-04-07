namespace Assignment1.Tests;

public class AssignmentTests
{
    [Fact]
    public void Assignment_1_1_Test()
    {
        var service = new AssignmentService();

        var result = service.Assignment_1_1();

        Assert.Equal("Hello World!", result);
    }

    [Fact]
    public void Assignment_1_2_Test()
    {
        //Arrange
        using var input = new StringReader("Hello World!");
        using var output = new StringWriter();
        Console.SetIn(input);
        Console.SetOut(output);

        var service = new AssignmentService();

        //Act
        service.Assignment_1_2();


        // Assertions

        var result = output.ToString().Trim(['\n', '\r']);

        Assert.Equal("Hello World!", result);
    }
}