public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
   public override void Speak()
    {
        Console.WriteLine("Bark");
    }
}