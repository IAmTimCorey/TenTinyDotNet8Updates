
// #3 - Alias any type
using System.Net;
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

// #9 - IPNetwork Parse
IPNetwork network = IPNetwork.Parse("192.168.1.1/32");
WriteLine(network.BaseAddress);

bool isInRange = IPNetwork.TryParse("192.168.1.321/32", out network);
WriteLine(isInRange);
if (isInRange)
{
    WriteLine(network.BaseAddress);
}

ReadLine();