// Main program execution
using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects
        Employee employee1 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee() { Id = 1, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using the overloaded '==' operator
        bool areEqual = employee1 == employee2;

        // Output the result of the comparison
        Console.WriteLine($"Are employee1 and employee2 equal by Id? {areEqual}");

        // Pause the console to view output
        Console.ReadLine();
    }
}
