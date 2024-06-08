public class ExceptionHandling
{
    public void Divide(int a, int b)
    {
        try
        {
            int result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Division operation completed.");
        }
    }
}