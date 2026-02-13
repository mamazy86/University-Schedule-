using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment;

public class UniversityClass
{
    public required DateOnly Time { get; init; }
    public required ClassCode? classCode { get; init; }
    public required List<Student> presentStudents { get; init; }
    public required Teacher presentTeacher { get; init; }
    public double ClassAverage { get; }
    public required Course? taughtCourse { get; init; }
    public static Course CreateCourse(string description) => new(description);
    public UniversityClass(List<double> grades)
    {
        double sum = 0;
        if (grades.Count() > 0)
        {
            for (int i = 0; i < grades.Count(); i++)
            {
                sum += grades[i];
            }
            ClassAverage=Math.Round(sum/grades.Count(),2);
        }
    }
    public override string ToString() =>
        $"\vtime : {Time} , present teacher : {presentTeacher.FirstName} {presentTeacher.LastName}" + 
        $"\nclass avg : {ClassAverage} , taught course : {taughtCourse}";
}

