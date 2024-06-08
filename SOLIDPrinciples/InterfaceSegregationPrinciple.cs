public interface IWorker
{
    void Work();
    void Eat();
}

//To follow ISP
public interface IWork
{
    void Work();
}

public interface IEat
{
    void Eat();
}

public class Worker : IWork, IEat
{
    public void Work()
    {
        /*Work logic */
    }

    public void Eat()
    {
        /*Eat logic */
    }
}