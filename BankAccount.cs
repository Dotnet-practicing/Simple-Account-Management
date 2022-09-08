

class BankAccount
{
    public int AccountNumber { get; }
    public string Owner { get; set; }
    public decimal Balance { get; private set; }
    public BankAccount(int accountnum, string owner, int initialnalance)
    {
        AccountNumber = accountnum;
        Owner = owner;
        Balance = initialnalance;
    }
    public void Deposit(Decimal ammount)
    {
        Balance = Balance + ammount;
    }
    public void Whithdraw(decimal ammount)
    {
        if (ammount > Balance)
        {
            System.Console.WriteLine("ma haysatid lacag kugu filan");
            return;
        }
        Balance = Balance - ammount;
    }
}