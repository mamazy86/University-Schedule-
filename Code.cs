using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment;

public abstract class Code
{
    private string _Value;
    public Code(int length,string value)
    {
        if (length != value.Length)
        {
            throw new ArgumentException($"code must have {length} digits");
        }
        if(!value.All(char.IsDigit) )
        {
            throw new ArgumentException("only integer numbers are allowed");
        }
        if (value.Distinct().Count() == 1)
        {
            throw new ArgumentException("all numbers can not have the same value");
        }
        _Value = value;
    }
    public override string ToString()=>_Value;
}
public sealed class NationalCode : Code
{
    private const int Length = 10;
    public NationalCode(string value) : base(Length, value) { }
    public static NationalCode Create(string value)=>new (value);
}
public sealed class TeacherCode : Code
{
    private const int Length = 8;
    public TeacherCode(string value) : base(Length, value) { }
    public static TeacherCode Create(string value) => new(value);
}

public sealed class StudentCode : Code
{
    private const int Length = 14;
    public StudentCode(string value) : base(Length, value) { }
    public static StudentCode Create(string value) => new(value);
}
public sealed class ClassCode : Code
{
    private const int Length = 5;
    public ClassCode(string value) : base(Length, value) { }
    public static ClassCode Create(string value) => new(value);
}

