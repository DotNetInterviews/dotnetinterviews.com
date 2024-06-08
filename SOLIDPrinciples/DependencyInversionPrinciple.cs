public class LightBulb
{
    public void TurnOn()
    {
        /*Turn on logic */
    }

    public void TurnOff()
    {
        /*Turn off logic */
    }
}

public class Switch
{
    private LightBulb _bulb;

    public Switch(LightBulb bulb)
    {
        _bulb = bulb;
    }

    public void Operate()
    {
        /*Switch logic */
    }

}

//To follow DIP
public interface ILightBulb
{
    void TurnOn();
    void TurnOff();
}

public class LightBulb : ILightBulb
{
    public void TurnOn()
    {
        /*Turn on logic */
    }

    public void TurnOff()
    {
        /*Turn off logic */
    }
}

public class Switch
{
    private ILightBulb _bulb;

    public Switch(ILightBulb bulb)
    {
        _bulb = bulb;
    }

    public void Operate()
    {
        /*Switch logic */
    }

}