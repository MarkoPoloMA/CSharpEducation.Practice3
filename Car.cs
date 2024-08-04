using System;

namespace CSharpEducation.Practice3;

internal class Car
{
    public string Marka { get; set; }

    public Car(string marka)
    {
        Marka = marka;
    }
    private void PrintMarkaforCar(Car p1)
    {
        Console.WriteLine($"Марка автомобиля: {p1.Marka}");
    }

}