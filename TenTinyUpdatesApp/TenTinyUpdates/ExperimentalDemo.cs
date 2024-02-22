using System.Diagnostics.CodeAnalysis;

namespace TenTinyUpdates;

/*
    Diagnostic IDs should be unique
    Diagnostic IDs must be legal identifiers in C#
    Diagnostic IDs should be less than 15 characters long
    Diagnostic IDs should be of the form <PREFIX><number>
    The prefix is specific to your project
    The number represents the specific diagnostic
    Note: It's a source breaking change to change diagnostic IDs, as existing suppressions would be ignored if the ID changed.
 */


[Experimental("TENUPD000001")]
public class ExperimentalDemo
{
    public int Id { get; set; }
    public string? DemoName { get; set; }
}
