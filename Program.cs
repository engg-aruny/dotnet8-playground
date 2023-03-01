using dotnet8_playground;
using System.Text.Json;

//Support for serializing properties from interface hierarchies.
IEmployee employeeObj = new Employee { MaxAge = 35, SalaryRevisionDate = DateTimeOffset.Now };
var jsonString = JsonSerializer.Serialize(employeeObj);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Support for serializing properties from interface hierarchies\n");
Console.WriteLine(jsonString + "\n");

//JsonNamingPolicy includes new naming policies for snake_case (with an underscore)
var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
var jsonSnakeString = JsonSerializer.Serialize(employeeObj, options);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("JsonNamingPolicy includes new naming policies for snake_case (with an underscore)\n");
Console.WriteLine(jsonSnakeString + "\n");


//Testing Randomness
Console.WriteLine("Testing Randomness\n");
RandomnessDemo.TestRandomness();

Console.ResetColor();
public interface IPerson
{
    public int MaxAge { get; set; }
}

public interface IEmployee : IPerson
{
    public DateTimeOffset SalaryRevisionDate { get; set; }
}

public class Employee : IEmployee
{
    public int MaxAge { get; set; }
    public DateTimeOffset SalaryRevisionDate { get; set; }
}