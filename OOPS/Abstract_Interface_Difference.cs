//ABSTRACTION 
public abstract class Vehicle
{
	public abstract void Drive();

	public void FillTank()
	{
		// Code to fill tank
	}
}

//INTERFACE
public interface IVehicle
{
	void Drive();
}

public interface IFuelable
{
	void FillTank();
}

public class Car : IVehicle, IFuelable
{
	public void Drive()
	{
		// Code to drive
	}

	public void FillTank()
	{
		// Code to fill tank
	}
}