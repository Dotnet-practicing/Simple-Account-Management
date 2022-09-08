//Today We Need Three thinks
//account Bank: Owner,Balance,AccountNumber
//deposite
//Whithdraw
// ToString("c")); this for dollar sing

var account1= new BankAccount(1,"abdiaziiz",40);
// account1.Balance=200;
// account1.Deposit(100);
account1.Whithdraw(50);
System.Console.WriteLine("owner is :"+account1.Owner +"balance:"+account1.Balance.ToString("c"));