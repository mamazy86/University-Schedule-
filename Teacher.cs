using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment;

public class Teacher : Person
{
    public required TeacherCode TeacherCode { get; init; }
    public required List<string>? Teachercourses { get; init; }
    public override string ToString()=>
       base.ToString();
}


