//Today We Need Three thinks
//account Bank: Owner,Balance,AccountNumber
//deposite
//Whithdraw
// ToString("c")); this for dollar sing

var account1= new BankAccount(1,"abdiaziiz",0);
// account1.Balance=200;
account1.Deposit(20);
account1.Deposit(-300);
account1.Deposit(300);
account1.Deposit(-300);
account1.Deposit(300);
account1.Deposit(300);
account1.Withdraw(10);
System.Console.WriteLine("owner is :"+account1.Owner +"balance:"+account1.Balance.ToString("c"));
foreach (var item in account1.Transactions)
{
    
System.Console.Write("Reference"+item.Reference);
System.Console.Write("\t ammount"+item.Amount);
System.Console.Write("\t date"+item.Date);
System.Console.WriteLine();
}