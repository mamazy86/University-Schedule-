using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment;

public class Course
{
    public List<string>? Descriptions = new List<string>()
    {
        "Mathematics","Chemistry","Physics","Biology","Programming"
    };
    public string? Value { get; }
    public Course(string description)
    {
        if (Descriptions.Contains(description))
        {
            Value=description;
        }
        else
        {
            throw new ArgumentException("only availabe descriptions are allowed : " +
                $"{string.Join(", ", Descriptions)}");
        }
    }
    public override string? ToString() => Value;
}
