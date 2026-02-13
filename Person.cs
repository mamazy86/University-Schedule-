using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment;

public abstract class Person
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public required NationalCode nationalCode { get; init; }
    public override string ToString() =>
        $"\vfull name : {FirstName} {LastName} , nt : {nationalCode}";
}

