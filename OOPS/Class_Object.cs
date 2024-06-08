public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }

    public void Drive()
    {
        Console.WriteLine("Driving the car");
    }

}

Car myCar = new Car();

myCar.Make = "Toyota";

myCar.Model = "Corolla";

myCar.Drive();