public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea() => Math.PI \* Radius \* Radius;
}

public class Rectangle : Shape
{
    public double Width { get; set; }

    public double Height { get; set; }

    public override double GetArea() => Width \* Height;
}