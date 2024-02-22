
// #3 - Alias any type
using TenTinyUpdates; // Normal
using static System.Console; // More recent, but not new
using Person = (string firstName, string lastName); // New

Person person = ("Tim", "Corey");
PrimaryConstructors p = new(person.firstName, person.lastName);
WriteLine(person);


// #2 - Collection Expression
List<string> names = ["Tim", "Sue", "Bob"];
List<string> moreNames = ["Greg", "Mary", "Pam"];

// Including the spread operator (..)
string[] combo = [.. names, .. moreNames];

// #4 - Experimental Attribute
#pragma warning disable TENUPD000001 
ExperimentalDemo demo = new()
{
    Id = 1,
    DemoName = "Primary Constructors"
};
#pragma warning restore TENUPD000001 

// #7 - Random Updates
string[] subset = Random.Shared.GetItems(combo, 2);
WriteLine("Subset: " + string.Join(", ", subset));

Random.Shared.Shuffle(combo);
WriteLine("Shuffled list: " + string.Join(", ", combo));


ReadLine();