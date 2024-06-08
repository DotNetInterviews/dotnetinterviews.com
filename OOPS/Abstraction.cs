public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{

    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI \*Radius \*Radius;
    }

}