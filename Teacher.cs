using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment;

public class Teacher : Person
{
    public required TeacherCode TeacherCode { get; init; }
    public required List<string>? Teachercourses { get; init; }
    public static Course CreateCourse(string description) => new(description);
    public override string ToString()=>
        base.ToString() + $" , tc : {TeacherCode} ";
}
