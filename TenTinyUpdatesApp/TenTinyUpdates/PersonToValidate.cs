using System.ComponentModel.DataAnnotations;

namespace TenTinyUpdates;

public class PersonToValidate
{
    [Length(2, 10)]
    public required string FirstName { get; set; }

    [Range(0, 120, MinimumIsExclusive = false, MaximumIsExclusive = true)]
    public int Age { get; set; }
}
