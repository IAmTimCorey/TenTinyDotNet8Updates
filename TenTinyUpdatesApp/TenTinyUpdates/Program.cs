
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

ReadLine();