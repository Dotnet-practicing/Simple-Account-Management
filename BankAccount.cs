

class BankAccount
{
     public int AccountNumber { get;  }
     public string Owner { get; set; }
     public decimal Balance { get;  }
     public BankAccount(int accountnum, string owner,int initialnalance)
     {
        AccountNumber=accountnum;
        Owner=owner;
        Balance= initialnalance;
     }
}