

// #2 - Collection Expression
List<string> names = ["Tim", "Sue", "Bob"];
List<string> moreNames = ["Greg", "Mary", "Pam"];

// Including the spread operator (..)
string[] combo = [.. names, .. moreNames];

Console.ReadLine();