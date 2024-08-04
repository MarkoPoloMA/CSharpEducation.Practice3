namespace CSharpEducation.Practice3;

class Rectangle
{
    public double Height { get; set; }
    public double Weight { get; set; }
    public Rectangle(double height, double weight)
    {
        Height = height;
        Weight = weight;
    }
    public double Square()
    {
        return Height * Weight;
    }
}