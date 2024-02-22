namespace TenTinyUpdates;

public class PrimaryConstructors(string firstName, string lastName)
{
    // You can still make them readonly or change their names
    private readonly string _firstName = firstName;

    // You can force them to be readonly
    private readonly string lastName = lastName;

    // You can still use regular constructors
    public PrimaryConstructors() : this("Tim", "Corey")
    {

    }
}