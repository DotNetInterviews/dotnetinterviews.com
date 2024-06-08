public class Bird
{
    public virtual void Fly()
    {
        /*Flying logic*/
    }
}

public class Eagle : Bird
{
    public override void Fly()
    {
        /*Flying logic specific to Eagle */
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException();
    }
}

//To follow LSP
public abstract class Bird { }

public class FlyingBird : Bird
{
    public virtual void Fly()
    {
        /*Flying logic */
    }
}

public class Eagle : FlyingBird
{
    public override void Fly()
    {
        /*Flying logic specific to Eagle */
    }
}

public class Ostrich : Bird
{
    /* Ostrich-specific logic */
}