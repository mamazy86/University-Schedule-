using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment;

public class Student : Person
{
    public required StudentCode StudentCode { get; init; }
    public required List<string>? Studentcourses { get; init; }
    public required List<string>? Teachers { get; init; }
    public double StudentAverage { get; }
    public Student(List<double> grades)
    {
        double sumOfGrades = 0;
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i]>=0 && grades[i] <= 20)
            {
                sumOfGrades += grades[i];
            }
        }  
        if(grades.Count > 0)
        {
            StudentAverage=Math.Round(sumOfGrades/grades.Count,2);
        }
    }
    public override string ToString() =>
       base.ToString() + $" , course average : {StudentAverage}";
}



