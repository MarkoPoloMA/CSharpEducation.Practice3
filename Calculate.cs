using System;

namespace CSharpEducation.Practice3;

internal class Calculate
{
    public double SecondValue { get; set; }
    public double FirstValue { get; set; }

public Calculate(double firstValue, double secondValue)
    {
        this.FirstValue = firstValue;
        this.SecondValue = secondValue;
    }
    public static Calculate operator +(Calculate f1, Calculate f2)
    {
        return new Calculate(f1.SecondValue * f2.FirstValue + f2.SecondValue * f1.FirstValue,
            f1.FirstValue * f2.FirstValue);
    }
    public static Calculate operator -(Calculate f1, Calculate f2)
    {
        return new Calculate(f1.SecondValue * f2.FirstValue - f2.SecondValue * f1.FirstValue,
            f1.FirstValue * f2.FirstValue);
    }
    public static Calculate operator *(Calculate f1, Calculate f2)
    {
        return new Calculate(f1.SecondValue * f2.SecondValue, f1.FirstValue * f2.FirstValue);
    }
    public static Calculate operator /(Calculate f1, Calculate f2)
    {
        return new Calculate(f1.SecondValue * f2.FirstValue, f1.FirstValue * f2.SecondValue);
    }

    public void To_String() => Console.WriteLine($"{SecondValue} / {FirstValue}");

}