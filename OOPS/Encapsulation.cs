public class Account
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

}