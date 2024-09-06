// Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the '==' operator to compare Employee objects by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both objects are null or reference the same memory location, they are equal
        if (ReferenceEquals(emp1, emp2))
        {
            return true;
        }

        // If either of the objects is null, they are not equal
        if (emp1 is null || emp2 is null)
        {
            return false;
        }

        // Compare the Id property of both Employee objects
        return emp1.Id == emp2.Id;
    }

    // Overloading the '!=' operator, must be done in pairs with '=='
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2); // Use the overloaded '==' operator for comparison
    }

    // Override Equals() and GetHashCode() for completeness when overloading '=='
    public override bool Equals(object obj)
    {
        if (obj is Employee)
        {
            var emp = (Employee)obj;
            return this.Id == emp.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
