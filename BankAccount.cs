

class BankAccount
{
     public int AccountNumber { get;  }
     public string Owner { get; set; }
     public decimal Balance { get; private set; }
     public BankAccount(int accountnum, string owner,int initialnalance)
     {
        AccountNumber=accountnum;
        Owner=owner;
        Balance= initialnalance;
     }
     public void Deposite(Decimal ammount)
     {
        Balance= Balance+ammount;
     }
}