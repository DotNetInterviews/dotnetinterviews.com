public interface IShape
{
    double GetArea();
}

public class Square : IShape
{
    public double Side { get; set; }

    public double GetArea()
    {
        return Side \*Side;
    }
}